﻿using System;
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
using System.Diagnostics;

namespace masterleasing.Reports.StatusWnioskowSW.Workflow2
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
        public string sendBCC = default(System.String);
        public String sendSubject = default(System.String);
        public String sendBody = default(System.String);

        public String logHistoryDescription = default(System.String);
        public String logHistoryOutcome = default(System.String);

        public bool bRaportTestowy = true;
        public bool bZnalezioneKontrakty = false;
        public bool bRaportUtworzony = false;

        public int partnerIdx = -1;

        private void codeGetAgentDetails_ExecuteCode(object sender, EventArgs e)
        {
            WriteToHistoryLog("Pobiera listę agentów z aktywną subskrybcją", "");

            using (SPSite site = new SPSite(workflowProperties.SiteId))
            {
                using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                {
                    SPList list = web.Lists[@"tabPartnerzy"];
                    SPQuery query = new SPQuery();
                    query.Query = @"<OrderBy><FieldRef Name='ID' /></OrderBy><Where><And><And><Eq><FieldRef Name='colAktywny' /><Value Type='Boolean'>1</Value></Eq><Eq><FieldRef Name='colLinie' /><Value Type='Text'>Leasing</Value></Eq></And><Eq><FieldRef Name='colWysylkaRaportuTygodniowego' /><Value Type='Boolean'>1</Value></Eq></And></Where>";

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

            bool result = CreateMailReport(partner);

            bRaportUtworzony = result;

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

        private bool CreateMailReport(SPListItem partner)
        {
            bool result = false;

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
                                result = true;
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

            return result;
        }

        private bool CreateMail(SPListItem partner, SPListItemCollection items)
        {
            bZnalezioneKontrakty = false;

            DateTime datDataZgloszenia = new DateTime();
            string strKlient = string.Empty;
            string strWartoscPLN = string.Empty;
            string strCelFinansowania = string.Empty;
            string strUstalenia = string.Empty;
            string strStatusLeadu = string.Empty;
            DateTime datDataNastepnegoKontaktu = new DateTime();
            string strDataNastepnegoKontaktu = string.Empty;
            DateTime datModified = new DateTime();

            string strSubject = string.Empty;
            string strBody = string.Empty;



            try
            {
                sendTo = partner["colEmailOsobyKontaktowej"].ToString();
                WriteToHistoryLog("To:" + sendTo, "");
                sendCC = GetManagerEmail(partner);
                sendBCC = GetManagingPartnersEmails();

                string strOsobaKontaktowa = partner["colOsobaKontaktowa"].ToString();

                //modyfikacja opisu jeżeli partner należy do grupy księgowi
                if (partner["colGrupa"] != null)
                {
                    string strGrupa = partner["colGrupa"].ToString();
                    if (strGrupa == "Księgowi")
                    {
                        strOsobaKontaktowa = strOsobaKontaktowa + " - Biuro Rachunkowe";
                    }

                }



                sendSubject = String.Format(":: Status kontraków : {0} : {1}",
                    DateTime.Now.ToShortDateString(),
                    strOsobaKontaktowa);

                StringBuilder sb = new StringBuilder();

                sb.Append(@"<head><style type=""text/css"">.style1 {border-style: solid;border-width: 0px;}style2 {border-style: solid;border-width: 1px;}</style>
</head><body style=""font-family: Arial""><table style=""width: 680px""><tr><td><table style=""width: 100%""><tr><td align=""center"" valign=""middle""><h3>Zestawienie bieżących kontraktów</h3></td><td align=""right""><img alt=""logo"" src=""http://stafix24cdn.blob.core.windows.net/sharedfiles/masterleasingLogo.PNG"" width=""110""></td></tr></table></td></tr><tr><td><table cellpadding=""2"" cellspacing=""1"" class=""style1"" style=""width: 100%; font-size: x-small""><thead style=""background: silver""><tr><td class=""style2"">#</td><td class=""style2"">Klient</td><td class=""style2"">Data zgłoszenia</td><td class=""style2"">Wartość PLN</td><td class=""style2"">Cel finansowania</td><td class=""style2"">Status</td><td class=""style2"">Ustalenia z klientem</td><td class=""style2"">Data następnego kontaktu</td></tr></thead>***rows*** </table></td></tr><tr><td style=""background-color: #DAF6CE""><div style=""background-color: #DAF6CE""><blockquote><p><span style=""font-size: x-small"">Witamy serdecznie</span></p><p style=""font-size: x-small"">Przypominamy Państwu o gotowości naszych doradców do pomocy w zakresie wsparcia handlowego. Zapewniamy Państwa Klientom nie tylko poradę w zakresie wyboru odpowiedniej formy leasingu, ale także doradzamy w obszarze optymalizacji podatkowej. Jeśli potrzebujecie Państwo dodatkowego wsparcia marketingowego również chętnie służymy pomocą.</p><p style=""font-size: x-small"">Jednocześnie informujemy, że w przypadku kilku naszych Partnerów procedury umożliwiają renegocjowanie ofert. Warunkiem renegocjacji jest dostarczenie do nas kontroferty.<br>W przypadku posiadania takiej kontroferty będziemy reprezentować Państwa firmę w procesie negocjacji warunków umowy. </p><p style=""font-size: x-small""><span style=""font-size: small"">Współpracujemy z </span><span style=""color: #1A3F93""><strong><span style=""font-size: small"">20 bankami i firmami leasingowymi</span></strong></span><br>dlatego naszymi największymi atutami są:</p><ul><li style=""font-size: x-small""><span style=""color: #1A3F93""><strong>duże doświadczenie</strong></span> w doborze najbardziej zoptymalizowanej formy finansowania dla klienta </li><li style=""font-size: x-small"">współpracując z kilkunastoma bankami mamy możliwość wyboru <span style=""color: #1A3F93""><strong>najkorzystniejszego leasingu na rynku</strong></span> </li><li style=""font-size: x-small"">mamy możliwość reprezentowania klienta w <strong><span style=""color: #1A3F93"">procesie renegocjacji</span> <span style=""color: #1A3F93"">warunków umowy</span></strong> leasingu (warunkiem renegocjacji jest dostarczenie do nas kontroferty) </li><li style=""font-size: x-small"">jako broker mamy możliwość<span style=""color: #1A3F93""> <strong>sprawdzenia wszystkich kosztów</strong></span> związanych z umową leasingu, także tych ukrytych </li><li style=""font-size: x-small"">zapewniamy swoim klientom <span style=""color: #1A3F93""><strong>opiekę przez cały okres trwania umowy</strong></span> leasingu, bez konieczności komunikowania się z bankiem przez telemarketing </li></ul><p style=""font-size: x-small"">Zapraszamy Państwa do odwiedzenia naszej nowej strony internetowej pod adresem <a href=""http://www.masterleasing.pl/""><span style=""color: #FF0000"">masterleasing.pl</span></a></p><p style=""font-size: x-small; text-align: left;"">W przypadku jakichkolwiek pytań służymy pomocą.</p><p style=""font-size: x-small; text-align: right;""><em>Zespół Master Leasing</em></p></blockquote></div></td></tr></table></body>");
                StringBuilder sb2 = new StringBuilder();

                foreach (SPListItem item in items)
                {
                    //odczyt danych z kontraktu

                    try
                    {
                        if (item["Modified"] != null)
                        {
                            datModified = Convert.ToDateTime(item["Modified"]);
                        }

                        if (item["colDataZgloszenia"] != null)
                        {
                            datDataZgloszenia = Convert.ToDateTime(item["colDataZgloszenia"]);
                        }

                        if (item["colKlient"] != null)
                        {
                            strKlient = item["colKlient"].ToString();
                        }
                        else strKlient = String.Empty;


                        try
                        {
                            if (item["colWartoscKontraktuPLN"] != null)
                            {
                                strWartoscPLN = item["colWartoscKontraktuPLN"].ToString();
                            }
                            else strWartoscPLN = String.Empty;
                        }
                        catch (Exception)
                        { }


                        if (item["colCelFinansowania"] != null)
                        {
                            strCelFinansowania = (string)item["colCelFinansowania"];
                        }
                        else strCelFinansowania = String.Empty;

                        if (item["colUstalenia"] != null)
                        {
                            strUstalenia = item["colUstalenia"].ToString();
                        }
                        else strUstalenia = String.Empty;

                        if (item["colStatusLeadu"] != null)
                        {
                            strStatusLeadu = item["colStatusLeadu"].ToString();
                        }
                        else strStatusLeadu = String.Empty;

                        if (item["colDataNastepnegoKontaktu"] != null)
                        {

                            if (strStatusLeadu == "Stracony" || strStatusLeadu == "Rozliczenie")
                            {
                                datDataNastepnegoKontaktu = new DateTime();
                                strDataNastepnegoKontaktu = String.Empty;
                            }
                            else
                            {
                                datDataNastepnegoKontaktu = Convert.ToDateTime(item["colDataNastepnegoKontaktu"]);
                                strDataNastepnegoKontaktu = datDataNastepnegoKontaktu.ToShortDateString();
                            }
                        }
                        else
                        {
                            datDataNastepnegoKontaktu = new DateTime();
                            strDataNastepnegoKontaktu = String.Empty;
                        }

                    }
                    catch (Exception exp)
                    {
                        ReportError("Odczyt danych z kontraktu", "ERR", exp, true);
                        return false;
                    }

                    //if (strStatusLeadu == "Stracony" && datModified < DateTime.Now.AddDays(60))
                    if (strStatusLeadu == "Stracony" && datModified < DateTime.Now.AddDays(-7))
                    {
                        //ignoruj rekordy o statusie stracony, których status został nadany więcej niż 7 dni temu (ostatnia aktulizacja rekordu)
                    }
                    else
                    {
                        string backgroundColor = string.Empty;
                        if (strStatusLeadu == "Stracony") backgroundColor = @"style=""background:#CCCCCC"""; //szary
                        if (strStatusLeadu == "Uruchomienie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony
                        if (strStatusLeadu == "Rozliczenie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony

                        sb2.Append(String.Format(@"
             <tr {8}>
				<td class=""style2"">{0}</td>
				<td class=""style2"">{1}</td>
				<td class=""style2"">{2}</td>
				<td class=""style2"">{3}</td>
				<td class=""style2"">{4}</td>
				<td class=""style2"">{5}</td>
				<td class=""style2"">{6}</td>
                <td class=""style2"">{7}</td>
			</tr>",
                            item["ID"].ToString(),
                            strKlient,
                            datDataZgloszenia.ToShortDateString(),
                            strWartoscPLN.ToString(),
                            strCelFinansowania,
                            strStatusLeadu,
                            strUstalenia,
                            strDataNastepnegoKontaktu.ToString(),
                            backgroundColor));

                    }
                }

                sb.Replace(@"***rows***", sb2.ToString());

                sb.Append(@"
<table style=""width: 680px"">
	<tbody>
	<tr>
		<td colspan=""2"" style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">
		<strong>Legenda</strong></td>
	</tr>
	<tr valign=""top"">
		<td style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><ul>	
	<li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozmowa 
	- wniosek w trakcie weryfikacji telefonicznej</li>	
	<li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Oferta 
	- przygotwanie i decyzja Klienta w sprawie oferty</li>
	<li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Wniosek 
	- oferta zaakceptowana, przygotowanie i decyzja Banku w sprawie przyznania 
	środków</li>
	<li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Umowa 
	- wniosek zaaprobowany przez Bank, przygotowanie i akceptacja umowy przez 
	Klienta</li>
	<li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Uruchomienie 
	- umowa zaakceptowana, uruchomienie środków</li>
	<li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozliczenie 
	- środki uruchomione, kontrakt do rozliczenie prowizji</li>
	
	
	
	
</ul>
</td>
		<td>
		<ul>
				<li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Stracony 
				- wniosek stracony, klient nie zaakceptował oferty lub odstąpił 
				od kontraktu z innych przyczyn</li>
	<li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Telefon 
	- zaplanowany kontakt z Klientem w późniejszym terminie</li>

		</ul>
		</td>
	</tr>
</tbody>
</table>

");

                sendBody = sb.ToString();

                bZnalezioneKontrakty = true;

            }
            catch (Exception exp)
            {
                WriteToHistoryLog(exp.Message, "ERR");
                return false;
            }

            return true;

        }

        private string GetManagerEmail(SPListItem partner)
        {
            WriteToHistoryLog("Pobiera dane managera", "");

            string result = String.Empty;

            if (partner["colManager"] != null)
            {
                string manager = partner["colManager"].ToString();

                if (!String.IsNullOrEmpty(manager))
                {
                    int foundId = GetLookupIndex(manager);
                    if (foundId > 0)
                    {
                        result = GetEmailAgenta(foundId);
                        WriteToHistoryLog("Manager:" + result, "");
                    }
                }
            }

            return result;
        }

        private int GetLookupIndex(string lookupString)
        {
            int result = 0;

            string idValue = lookupString;
            int partial = idValue.LastIndexOf(";");
            string idPure = idValue.Substring(0, partial);

            result = Convert.ToInt32(idPure);

            return result;
        }

        private string GetManagingPartnersEmails()
        {
            WriteToHistoryLog("Pobiera listę dystrybucyjną BCC", "");

            string result = string.Empty;

            using (SPSite site = new SPSite(workflowProperties.SiteId))
            {
                using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                {
                    SPList list = web.Lists[@"admSetup"];

                    foreach (SPListItem item in list.Items)
                    {
                        string key = item["colKEY"].ToString();

                        if (key == @"RAPORT_OKRESOWY_BCC_COPY")
                        {
                            result = item["colVALUE"].ToString();
                            break;
                        }
                    }
                }
            }

            WriteToHistoryLog("BCC:" + result, "");

            return result;
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

        private string GetEmailAgenta(int partnerID)
        {
            using (SPSite site = new SPSite(workflowProperties.SiteId))
            {
                using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder(@"<Where><Eq><FieldRef Name='ID'/><Value Type='Counter'>{__partnerID__}</Value></Eq></Where>");
                    sb.Replace("{__partnerID__}", partnerID.ToString());
                    string camlQuery = sb.ToString();

                    SPList list = web.Lists[@"tabPartnerzy"];
                    SPQuery query = new SPQuery();
                    query.ViewFields = @"";
                    query.Query = camlQuery;

                    SPListItemCollection items = list.GetItems(query);
                    if (items.Count == 1)
                    {
                        SPListItem item = items[0];

                        if (item["colEmailOsobyKontaktowej"] != null)
                        {
                            return item["colEmailOsobyKontaktowej"].ToString();
                        }
                    }
                }

                return String.Empty;
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
            Debug.WriteLine(sendTo + "::" + sendSubject);

            if (bRaportTestowy)
            {
                //podmień dane do wysyłki
                sendTo = workflowProperties.OriginatorEmail.ToString();
                sendSubject = ":: TESTOWY " + sendSubject;
                sendCC = String.Empty;
                sendBCC = String.Empty;
            }
            else
            {
                //dodaj w kopii osobę generującą raport
                sendCC = sendCC + ";" + workflowProperties.OriginatorEmail.ToString();
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

        private void hasZnalezioneKontrakty(object sender, ConditionalEventArgs e)
        {
            e.Result = (bZnalezioneKontrakty && bRaportUtworzony);
        }

        private void codeResetFlags_ExecuteCode(object sender, EventArgs e)
        {
            bZnalezioneKontrakty = false;
            bRaportUtworzony = false;
        }

        private void isCTStatusWnioskow(object sender, ConditionalEventArgs e)
        {
            if (workflowProperties.Item.ContentType.Name == "Raport_Status Wniosków")
            {
                e.Result = true;
            }
            else
            {
                e.Result = false;
            }
        }

        private void cmdErrorHandler_ExecuteCode(object sender, EventArgs e)
        {
            FaultHandlerActivity fa = ((Activity)sender).Parent as FaultHandlerActivity;
            if (fa != null)
            {
                Debug.WriteLine(fa.Fault.Source);
                Debug.WriteLine(fa.Fault.Message);
                Debug.WriteLine(fa.Fault.StackTrace);

                logErrorMessage_HistoryDescription = string.Format("{0}::{1}",
                    fa.Fault.Message,
                    fa.Fault.StackTrace);
            }
        }

        public String logErrorMessage_HistoryDescription = default(System.String);

        private void onWorkflowActivated1_Invoked(object sender, ExternalDataEventArgs e)
        {
            Debug.WriteLine(string.Format(@"Workflow: {0} - initiated", workflowProperties.WorkflowId.ToString()));
        }

    }
}
