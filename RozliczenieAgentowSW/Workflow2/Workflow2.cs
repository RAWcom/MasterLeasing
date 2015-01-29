using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;
using System.Net.Mail;
using System.Text;

namespace masterleasing.Reports.RozliczenieAgentowSW.Workflow2
{
    public sealed partial class Workflow2 : SequentialWorkflowActivity
    {

        public Workflow2()
        {
            InitializeComponent();
        }

        public Guid workflowId = default(System.Guid);
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        public ArrayList aPartnerzy = new ArrayList();

        public String sendTo = default(System.String);
        public String sendCC = default(System.String);
        public String sendSubject = default(System.String);
        public String sendBody = default(System.String);

        public String logHistoryDescription = default(System.String);
        public String logHistoryOutcome = default(System.String);

        public bool bRaportTestowy = true;

        public int partnerIdx = -1;

        /// <summary>
        /// Wybiera z bazy wszystkich aktywnych agentów dla których będą następnie wyszukiwane dostępne rozliczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void codeGetAgentDetails_ExecuteCode(object sender, EventArgs e)
        {
            WriteToHistoryLog("Pobiera listę aktywnych agentów z linii Leasing", "");

            using (SPSite site = new SPSite(workflowProperties.SiteId))
            {
                using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                {
                    SPList list = web.Lists[@"tabPartnerzy"];
                    SPQuery query = new SPQuery();
                    query.ViewFields = @"<FieldRef Name='ID' /><FieldRef Name='colOsobaKontaktowa' /><FieldRef Name='colTelefonOsobyKontakowej' /><FieldRef Name='colEmailOsobyKontaktowej' /><FieldRef Name='colAktywny' />";
                    query.Query = @"<OrderBy><FieldRef Name='ID' /></OrderBy><Where><And><Eq><FieldRef Name='colAktywny' /><Value Type='Boolean'>1</Value></Eq><Eq><FieldRef Name='colLinie' /><Value Type='Text'>Leasing</Value></Eq></And></Where>";

                    SPListItemCollection items = list.GetItems(query);
                    foreach (SPListItem item in items)
                    {
                        aPartnerzy.Add(item);
                    }
                }
            }

            if (aPartnerzy.Count > 0)
            {
                partnerIdx = 0;
                WriteToHistoryLog(String.Format("Wyselekcjonowano {0} agentów", aPartnerzy.Count.ToString()), "");
            }
            else
            {
                partnerIdx = -1;
                WriteToHistoryLog("Żaden z agentów nie spełnia kryteriów wyboru", "");
            }
        }

        private void codeCreateReports_ExecuteCode(object sender, EventArgs e)
        {
            ReSetMailDetails();
            ReSetLogMessage();

            SPListItem partner = (SPListItem)aPartnerzy[partnerIdx];

            bool result = CreateRozliczenieAgenta(partner);

            string strPartnerName = string.Empty;
            if (partner["colOsobaKontaktowa"] != null)
            {
                strPartnerName = partner["colOsobaKontaktowa"].ToString();
            }

            logHistoryDescription = String.Format("Raport dla agenta {0} wysłany", strPartnerName);

        }

        private void ReSetLogMessage()
        {
            logHistoryDescription = string.Empty;
            logHistoryOutcome = string.Empty;
        }

        private void ReSetMailDetails()
        {
            sendTo = string.Empty;
            sendCC = string.Empty;
            sendSubject = string.Empty;
            sendBody = string.Empty;
        }

        private void codeRemoveItem_ExecuteCode(object sender, EventArgs e)
        {

        }

        #region Procedures

        private bool CreateRozliczenieAgenta(SPListItem partner)
        {
            try
            {
                using (SPSite site = new SPSite(workflowProperties.SiteId))
                {
                    using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                    {
                        System.Text.StringBuilder sb = new System.Text.StringBuilder(@"<OrderBy><FieldRef Name='colDataZgloszenia' Ascending='FALSE' /><FieldRef Name='ID' Ascending='FALSE' /></OrderBy><Where><Eq><FieldRef Name='Agent_x002e__x003a_Identyfikator' /><Value Type='Text'>{__AgentID__}</Value></Eq></Where>");
                        sb.Replace("{__AgentID__}", partner["ID"].ToString());
                        string camlQuery = sb.ToString();

                        SPList list = web.Lists[@"tabKontrakty"];
                        SPQuery query = new SPQuery();
                        query.ViewFields = "";
                        //query.ViewFields = @"<FieldRef Name='ID' /><FieldRef Name='colDataZgloszenia' /><FieldRef Name='colKlient' /><FieldRef Name='colWartoscKontraktuPLN' /><FieldRef Name='colCelFinansowania' /><FieldRef Name='colUstalenia' /><FieldRef Name='colStatusLeadu' /><FieldRef Name='colNumerKontraktu' /><FieldRef Name='colEmailKlienta' /><FieldRef Name='colTelefonKlienta' />";
                        query.Query = camlQuery;

                        SPListItemCollection items = list.GetItems(query);
                        if (items.Count > 0)
                        {
                            ReSetLogMessage();

                            if (CreateMail(partner, items))
                            {
                                logHistoryDescription = "Raport wygenerowany i wysłany";
                            }
                            else
                            {
                                logHistoryDescription = "Wystąpił problem z przygotowaniem raportu";
                                logHistoryOutcome = "ERR";
                            }

                        }
                        else
                        {
                            WriteToHistoryLog("Brak powiązanych kontraktów", "");
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private bool CreateMail(SPListItem partner, SPListItemCollection items)
        {
            DateTime datDataZgloszenia = new DateTime();
            string strKlient = string.Empty;
            string strWartoscPLN = string.Empty;
            string strCelFinansowania = string.Empty;
            string strUstalenia = string.Empty;
            string strStatusLeadu = string.Empty;

            string strSubject = string.Empty;
            string strBody = string.Empty;



            try
            {
                sendTo = partner["colEmailOsobyKontaktowej"].ToString();
                sendSubject = String.Format(":: Status kontraków : {0} : {1}",
                    DateTime.Now.ToShortDateString(),
                    partner["colOsobaKontaktowa"].ToString());

                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("<body>");
                sb.AppendFormat("<h3>Zestawienie bieżących kontraktów:<h3>");
                sb.AppendFormat("<div>");
                sb.AppendFormat("<table>");
                sb.AppendFormat("<tr><td>#</td><td>Klient</td><td>Data zgł.</td><td>Wartość PLN</td><td>Cel finansowania</td><td>Status</td><td>Ustalenia</td></tr>");

                foreach (SPListItem item in items)
                {
                    //odczyt danych z kontraktu

                    try
                    {
                        if (item["colDataZgloszenia"] != null)
                        {
                            datDataZgloszenia = Convert.ToDateTime(item["colDataZgloszenia"]);
                        }

                        if (item["colKlient"] != null)
                        {
                            strKlient = item["colKlient"].ToString();
                        }


                        try
                        {
                            if (item["colWartoscKontraktuPLN"] != null)
                            {
                                strWartoscPLN = item["colWartoscKontraktuPLN"].ToString();
                            }
                        }
                        catch (Exception)
                        { }


                        if (item["colCelFinansowania"] != null)
                        {
                            strCelFinansowania = (string)item["colCelFinansowania"];
                        }


                        if (item["colUstalenia"] != null)
                        {
                            strUstalenia = item["colUstalenia"].ToString();
                        }


                        if (item["colStatusLeadu"] != null)
                        {
                            strStatusLeadu = item["colStatusLeadu"].ToString();
                        }

                    }
                    catch (Exception exp)
                    {
                        ReportError("Odczyt danych z kontraktu", "ERR", exp, true);
                        return false;
                    }

                    sb.AppendFormat(String.Format(@"<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td></tr>",
                        item["ID"].ToString(),
                        strKlient,
                        datDataZgloszenia.ToShortDateString(),
                        strWartoscPLN,
                        strCelFinansowania,
                        strStatusLeadu,
                        strUstalenia));
                }

                sb.AppendFormat("</table>");
                sb.AppendFormat("</div>");
                sb.AppendFormat("</body>");

                sendBody = sb.ToString();

            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        #endregion

        #region Helpers

        public bool SendDirectMail(string subject, string body)
        {
            //Ustaw dla każdego modułu indywidualnie
            string from = "ERR.ML.Raport_StatusWniosków<noreply@stafix24.pl>";
            string to = "biuro@rawcom24.pl";


            //TurboSMTP config parameters
            const string sMTPServerName = "pro.turbo-smtp.com";//
            const string sMTPLoginName = "biuro@rawcom24.pl";
            const string sMTPPassword = "Rogalaewa1";
            const int sMTPPort = 587;

            MailMessage msg = new MailMessage(from, to);
            msg.Subject = subject;
            msg.Body = body;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient(sMTPServerName, sMTPPort);
            System.Net.NetworkCredential basicCredential = new System.Net.NetworkCredential(sMTPLoginName, sMTPPassword);
            client.EnableSsl = false;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential;
            try
            {
                client.Send(msg);
            }
            catch (Exception)
            {
                WriteToHistoryLog("DirectSendMail", "ERR");
                return false;
            }

            return true;
        }

        private void CustomErrorHandler(Exception e)
        {

            StringBuilder sb = new StringBuilder();

            try
            {
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Message", e.Message.ToString());
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Source", e.Source.ToString());
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Target Site", e.TargetSite.ToString());
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Stack Trace", e.StackTrace.ToString());
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Workflow Context", workflowProperties.Context.ToString());

            }
            catch (Exception)
            {
                sb.AppendLine("Problem z odczytem pozostałych szczegółów");
            }

            WriteToHistoryLog(e.Message.ToString(), "ERR");

            SendDirectMail(e.Message.ToString(), sb.ToString());

        }

        private void WriteToHistoryLog(string description, string outcome)
        {
            SPWeb web = workflowProperties.Web;
            Guid workflow = workflowProperties.WorkflowId;

            TimeSpan ts = new TimeSpan();
            SPWorkflow.CreateHistoryEvent(web, workflow, 0, web.CurrentUser, ts,
                outcome, description, string.Empty);
        }

        private void ReportError(string Message, string Outcome, Exception e, bool allowSendDirectMail)
        {
            //report to history log

            if (Message == string.Empty)
            {
                Message = e.Message;
            }

            WriteToHistoryLog(Message, Outcome);

            //report to email

            if (allowSendDirectMail)
            {
                SendDirectMail(Message, e.ToString());
            }
        }

        #endregion

        private void IsAgenciDoObslugi(object sender, ConditionalEventArgs e)
        {
            if (aPartnerzy.Count > 0)
            {
                e.Result = true;
            }
            else
            {
                e.Result = false;
            }

        }

        private void codeIncrementAgent_ExecuteCode(object sender, EventArgs e)
        {
            partnerIdx = partnerIdx + 1;
        }

        private void IsAgentAvailable(object sender, ConditionalEventArgs e)
        {
            if (partnerIdx < aPartnerzy.Count)
            {
                e.Result = true;
            }
            else
            {
                e.Result = false;
            }
        }

        private void sendRaportDlaAgenta_MethodInvoking(object sender, EventArgs e)
        {
            if (bRaportTestowy)
            {
                //podmień dane do wysyłki
                sendTo = workflowProperties.OriginatorEmail.ToString();
                sendSubject = ":: TESTOWY " + sendSubject;
            }
            else
            {
                sendCC = workflowProperties.OriginatorEmail.ToString();
            }
        }

        private bool IsTrybTestowy()
        {
            if (workflowProperties.Item["colTrybUruchomienia"] != null)
            {
                string strTrybUruchomienia = workflowProperties.Item["colTrybUruchomienia"].ToString();

                if (strTrybUruchomienia == "Produkcyjny")
                {
                    return false;
                }

            }

            return true;
        }

        private void codeGetTrybRaportu_ExecuteCode(object sender, EventArgs e)
        {
            if (IsTrybTestowy())
            {
                WriteToHistoryLog("Aktywowano tryb testowy raportu", "");
                bRaportTestowy = true;
            }
            else
            {
                bRaportTestowy = false;
            }
        }

        private CodeActivity codeIncrementAgent;

        private LogToHistoryListActivity logRaportWyslany;

        private SendEmail sendRaportDlaAgenta;

        private CodeActivity codeCreateReports;

        private SequenceActivity sequencePrzygotujRaport;

        private WhileActivity whileAgentAvailable;

        private IfElseBranchActivity AgenciDoObslugi;

        private CodeActivity codeRemoveItem;

        private IfElseActivity ifElseActivity1;

        private CodeActivity codeGetTrybRaportu;

        private CodeActivity codeGetAgentDetails;

        private OnWorkflowActivated onWorkflowActivated1;

        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            this.codeIncrementAgent = new System.Workflow.Activities.CodeActivity();
            this.logRaportWyslany = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendRaportDlaAgenta = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.codeCreateReports = new System.Workflow.Activities.CodeActivity();
            this.sequencePrzygotujRaport = new System.Workflow.Activities.SequenceActivity();
            this.whileAgentAvailable = new System.Workflow.Activities.WhileActivity();
            this.AgenciDoObslugi = new System.Workflow.Activities.IfElseBranchActivity();
            this.codeRemoveItem = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.codeGetTrybRaportu = new System.Workflow.Activities.CodeActivity();
            this.codeGetAgentDetails = new System.Workflow.Activities.CodeActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // codeIncrementAgent
            // 
            this.codeIncrementAgent.Name = "codeIncrementAgent";
            this.codeIncrementAgent.ExecuteCode += new System.EventHandler(this.codeIncrementAgent_ExecuteCode);
            // 
            // sendRaportDlaAgenta
            // 
            this.sendRaportDlaAgenta.BCC = null;
            activitybind3.Name = "Workflow2";
            activitybind3.Path = "sendBody";
            activitybind4.Name = "Workflow2";
            activitybind4.Path = "sendCC";
            correlationtoken1.Name = "workflowToken";
            correlationtoken1.OwnerActivityName = "Workflow2";
            this.sendRaportDlaAgenta.CorrelationToken = correlationtoken1;
            this.sendRaportDlaAgenta.From = null;
            this.sendRaportDlaAgenta.Headers = null;
            this.sendRaportDlaAgenta.IncludeStatus = false;
            this.sendRaportDlaAgenta.Name = "sendRaportDlaAgenta";
            activitybind5.Name = "Workflow2";
            activitybind5.Path = "sendSubject";
            activitybind6.Name = "Workflow2";
            activitybind6.Path = "sendTo";
            this.sendRaportDlaAgenta.MethodInvoking += new System.EventHandler(this.sendRaportDlaAgenta_MethodInvoking);
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // codeCreateReports
            // 
            this.codeCreateReports.Name = "codeCreateReports";
            this.codeCreateReports.ExecuteCode += new System.EventHandler(this.codeCreateReports_ExecuteCode);
            // 
            // sequencePrzygotujRaport
            // 
            this.sequencePrzygotujRaport.Activities.Add(this.codeCreateReports);
            this.sequencePrzygotujRaport.Activities.Add(this.sendRaportDlaAgenta);
            this.sequencePrzygotujRaport.Activities.Add(this.logRaportWyslany);
            this.sequencePrzygotujRaport.Activities.Add(this.codeIncrementAgent);
            this.sequencePrzygotujRaport.Name = "sequencePrzygotujRaport";
            // 
            // whileAgentAvailable
            // 
            this.whileAgentAvailable.Activities.Add(this.sequencePrzygotujRaport);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAgentAvailable);
            this.whileAgentAvailable.Condition = codecondition1;
            this.whileAgentAvailable.Name = "whileAgentAvailable";
            // 
            // AgenciDoObslugi
            // 
            this.AgenciDoObslugi.Activities.Add(this.whileAgentAvailable);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAgenciDoObslugi);
            this.AgenciDoObslugi.Condition = codecondition2;
            this.AgenciDoObslugi.Name = "AgenciDoObslugi";
            // 
            // codeRemoveItem
            // 
            this.codeRemoveItem.Name = "codeRemoveItem";
            this.codeRemoveItem.ExecuteCode += new System.EventHandler(this.codeRemoveItem_ExecuteCode);
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.AgenciDoObslugi);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // codeGetTrybRaportu
            // 
            this.codeGetTrybRaportu.Name = "codeGetTrybRaportu";
            this.codeGetTrybRaportu.ExecuteCode += new System.EventHandler(this.codeGetTrybRaportu_ExecuteCode);
            // 
            // codeGetAgentDetails
            // 
            this.codeGetAgentDetails.Name = "codeGetAgentDetails";
            this.codeGetAgentDetails.ExecuteCode += new System.EventHandler(this.codeGetAgentDetails_ExecuteCode);
            // 
            // onWorkflowActivated1
            // 
            correlationtoken2.Name = "workflowToken";
            correlationtoken2.OwnerActivityName = "Workflow2";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken2;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind7.Name = "Workflow2";
            activitybind7.Path = "workflowProperties";
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            // 
            // Workflow2
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.codeGetAgentDetails);
            this.Activities.Add(this.codeGetTrybRaportu);
            this.Activities.Add(this.ifElseActivity1);
            this.Activities.Add(this.codeRemoveItem);
            this.Name = "Workflow2";
            this.CanModifyActivities = false;

        }






    }
}
