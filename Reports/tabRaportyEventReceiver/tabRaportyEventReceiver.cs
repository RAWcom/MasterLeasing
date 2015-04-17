using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System.Net.Mail;
using System.Text;
using System.Collections;
using Microsoft.SharePoint.Administration;
using System.Collections.Specialized;

namespace Reports.tabRaportyEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class tabRaportyEventReceiver : SPItemEventReceiver
    {
        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            base.ItemAdded(properties);
            Execute(properties);
        }

        /// <summary>
        /// An item was updated.
        /// </summary>
        public override void ItemUpdated(SPItemEventProperties properties)
        {
            base.ItemUpdated(properties);
            Execute(properties);
        }

        private void Execute(SPItemEventProperties properties)
        {
            //określ rodzaj raportu
            string ct = properties.ListItem["ContentType"].ToString();
            switch (ct)
            {
                case "ctRaportVIP":
                    Create_RaportVIP(properties);
                    break;
                case "Raport1Sprawa":
                    Create_Raport1Sprawa(properties);
                    break;
                case "RaportDlaGrupy":
                    Create_RaportDlaGrupy(properties);
                    break;
                case "RaportOpoznione":
                    Create_RaportOpoznione(properties);
                    break;
                case "RaportHandlowca":
                    Create_RaportHandlowca(properties);
                    break;
                default:
                    break;
            }
        }

        #region RaportVIP

        /// <summary>
        /// R1.raport VIP – ma to być taki sam jak raport dla handlowców tyko z zaznaczeniem,
        /// że dotyczy tylko spraw gdzie wartość przedmiotu jest równe lub większe 200.000 zł.
        /// Raport ten powinien zawierać także nazwisko handlowca i managera.
        /// Raport ten ma być wysyłany tylko do mnie, Kasi i Norberta
        /// </summary>
        /// <param name="properties"></param>
        private void Create_RaportVIP(SPItemEventProperties properties)
        {
            //przygotuj listę rekordów spełniających kryteria
            SPQuery query = new SPQuery();
            query.Query = @"<OrderBy><FieldRef Name='colWartoscKontraktuPLN' /></OrderBy><Where><Geq><FieldRef Name='colWartoscKontraktuPLN' /><Value Type='Currency'>200000</Value></Geq></Where>";

            ArrayList recordsAL = SelectContracts(properties, query);

            //uzupełnij dane partnera
            UpdatePartnerDetails(properties, recordsAL);

            //przygotuj raport
            CreateReportVIP(properties, recordsAL, true);

        }

        private void CreateReportVIP(SPItemEventProperties properties, ArrayList recordsAL, bool isTestowy)
        {
            MailMessage msg = new MailMessage();
            SPListItem item = properties.ListItem;

            string s = "Raport VIP";

            //To = bieżący użytkownik
            //if (item["Author"] != null)
            //{
            //    SPFieldUserValue temp = (SPFieldUserValue)item["Author"];
            //    msg.To = temp.User.Email; 
            //}
            SPUser currentUser = properties.Web.SiteUsers.GetByID(properties.CurrentUserId);
            msg.To = currentUser.Email;

            //Cc, Subject
            if (!s.StartsWith(":: "))
            {
                s = ":: " + s ;
            }
            
            if (isTestowy)
            {
                msg.Cc = string.Empty;
                msg.Subject = ":: TESTOWY " + s;

            }
            else
            {
                msg.Cc = GetManagingPartnersEmails(properties);
                msg.Cc = "biuro@rawcom24.pl";
                msg.Subject = s;
            }

                
            //Body

            StringBuilder sb = new StringBuilder(@"<head><style type=""text/css"">
.style1 {
	border-style: solid;
	border-width: 0px;
}
.style2 {
	border-style: solid;
	border-width: 1px;
}
</style>
</head><body style=""font-family: Arial""><table style=""width: 680px""><tr><td><table style=""width: 100%""><tr><td align=""center"" valign=""middle""><h3>Raport VIP</h3></td><td align=""right""><img alt=""logo"" src=""http://stafix24cdn.blob.core.windows.net/sharedfiles/masterleasingLogo.PNG"" width=""110"" /></td></tr></table></td></tr><tr><td><table cellpadding=""2"" cellspacing=""1"" class=""style1"" style=""width: 100%; font-size: x-small""><thead style=""background: silver""><tr><td class=""style2"">#</td><td class=""style2"">Grupa</td><td class=""style2"">Menedżer</td><td class=""style2"">Agent</td><td class=""style2"">Klient</td><td class=""style2"">Data zgłoszenia</td><td class=""style2"">Wartość PLN</td><td class=""style2"">Cel finansowania</td><td class=""style2"">Status</td><td class=""style2"">Ustalenia z klientem</td><td class=""style2"">Data następnego kontaktu</td><td class=""style2"">Operator</td></tr></thead>***TBody*** </table></td></tr><tr><td>&nbsp;</td></tr></table></body>");

            //TBody

            StringBuilder sb0 = new StringBuilder(@"<tbody>");

            foreach (Kontrakt r in recordsAL)
            {

                string backgroundColor = string.Empty;
                if (r.Status == "Stracony") backgroundColor = @"style=""background:#CCCCCC"""; //szary
                if (r.Status == "Uruchomienie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony
                if (r.Status == "Rozliczenie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony

                sb0.Append(String.Format(@"
                     <tr {0} valign=""top"">
        				<td class=""style2"">{1}</td>
        				<td class=""style2"">{2}</td>
        				<td class=""style2"">{3}</td>
        				<td class=""style2"">{4}</td>
        				<td class=""style2"">{5}</td>
        				<td class=""style2"">{6}</td>
                        <td class=""style2"" align=""right"">{7}</td>
        				<td class=""style2"">{8}</td>
        				<td class=""style2"">{9}</td>
                        <td class=""style2"">{10}</td>
                        <td class=""style2"">{11}</td>
                        <td class=""style2"">{12}</td>
        			</tr>",
                       backgroundColor,
                       r.ID,
                       r.Grupa,
                       r.ManagerName,
                       r.AgentName,
                       r.Klient,
                       r.DataZgloszenia.ToShortDateString(),
                       r.WartoscPLN.ToString(),
                       r.CelFinansowania,
                       r.Status,
                       r.Ustalenia,
                       r.PlanowanyKontakt.ToShortDateString(),
                       r.Operator));
            }

            sb0.Append("</tbody>");

            sb.Replace(@"***TBody***", sb0.ToString());

            //legenda
            sb.Append(@"<table style=""width: 680px""><tbody><tr><td colspan=""2"" style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><strong>Legenda</strong></td></tr><tr valign=""top""><td style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozmowa - wniosek w trakcie weryfikacji telefonicznej</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Oferta - przygotwanie i decyzja Klienta w sprawie oferty</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Wniosek - oferta zaakceptowana, przygotowanie i decyzja Banku w sprawie przyznania środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Umowa - wniosek zaaprobowany przez Bank, przygotowanie i akceptacja umowy przez Klienta</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Uruchomienie - umowa zaakceptowana, uruchomienie środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozliczenie - środki uruchomione, kontrakt do rozliczenie prowizji</li></ul></td><td><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Stracony - wniosek stracony, klient nie zaakceptował oferty lub odstąpił od kontraktu z innych przyczyn</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Telefon - zaplanowany kontakt z Klientem w późniejszym terminie</li></ul></td></tr></tbody></table>");

            msg.Body = sb.ToString();


            //wyślij raport mailem

            string url = properties.WebUrl;

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (SPSite site = new SPSite(url))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        // myemail@test.com is obviously replaced with a real working email
                        SendMail(properties.Web, "noreply@stafix24.pl", msg.To, msg.Subject, msg.Body, msg.Cc, msg.Bcc);
                    }
                }
            });
        }



        #endregion

        private void Create_Raport1Sprawa(SPItemEventProperties properties)
        {
            throw new NotImplementedException();
        }

        private void Create_RaportDlaGrupy(SPItemEventProperties properties)
        {
            throw new NotImplementedException();
        }

        private void Create_RaportOpoznione(SPItemEventProperties properties)
        {
            throw new NotImplementedException();
        }

        private void Create_RaportHandlowca(SPItemEventProperties properties)
        {
            throw new NotImplementedException();
        }

        #region Helpers

        /// <summary>
        /// Aktualizuje tablicę wyselekcjonowanych kontraktów informacjami z tablicy Partnerów
        /// Dane o Agencie, Managerze i Grupie
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="RecordsAL"></param>
        private void UpdatePartnerDetails(SPItemEventProperties properties, ArrayList RecordsAL)
        {
            using (SPSite site = new SPSite(properties.SiteId))
            {
                using (SPWeb web = site.AllWebs[properties.Web.ID])
                {
                    SPList list = web.Lists[@"tabPartnerzy"];

                    foreach (Kontrakt r in RecordsAL)
                    {
                        SPListItem item = list.GetItemById(r.AgentId);
                        if (item != null)
                        {
                            if (item["colEmailOsobyKontaktowej"] != null)
                            {
                                r.AgentEmail = item["colEmailOsobyKontaktowej"].ToString();
                            }
                            if (item["colOsobaKontaktowa"] != null)
                            {
                                r.AgentName = item["colOsobaKontaktowa"].ToString();
                            }

                            if (item["colManager"] != null)
                            {
                                SPFieldLookupValue value = new SPFieldLookupValue(item["colManager"].ToString());
                                if (value.LookupId > 0)
                                {
                                    //pobierz dane managera
                                    SPListItem itemManager = list.GetItemById(value.LookupId);
                                    if (itemManager["colEmailOsobyKontaktowej"] != null)
                                    {
                                        r.ManagerEmail = itemManager["colEmailOsobyKontaktowej"].ToString();
                                    }
                                    if (itemManager["colOsobaKontaktowa"] != null)
                                    {
                                        r.ManagerName = itemManager["colOsobaKontaktowa"].ToString();
                                    }
                                }
                            }

                            if (item["colGrupa"] != null)
                            {
                                r.Grupa = item["colGrupa"].ToString();
                            }

                        }
                    }
                }
            }
        }

        /// <summary>
        /// fitr: wartość PLN >= 200000,
        /// usuń Status Leadu=Stracony|Rozliczenie starsze niż 60 dni (w/g daty modyfikacji)
        /// 
        /// sort: wartość PLN (malejąco)
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        private ArrayList SelectContracts(SPItemEventProperties properties, SPQuery query)
        {
            ArrayList result = new ArrayList();

            using (SPSite site = new SPSite(properties.SiteId))
            {
                using (SPWeb web = site.AllWebs[properties.Web.ID])
                {
                    SPList list = web.Lists[@"tabKontrakty"];

                    SPListItemCollection items = list.GetItems(query);
                    foreach (SPListItem item in items)
                    {
                        Kontrakt r = new Kontrakt();

                        if (item["colDataZgloszenia"] != null)
                        {
                            r.DataZgloszenia = DateTime.Parse(item["colDataZgloszenia"].ToString());
                        }
                        if (item["colPartner_x002e_OsobaKontaktowa"] != null)
                        {
                            SPFieldLookupValue temp = new SPFieldLookupValue(item["colPartner_x002e_OsobaKontaktowa"].ToString());
                            r.AgentId = temp.LookupId;
                        }
                        if (item["colKlient"] != null)
                        {
                            r.Klient = (String)item["colKlient"];
                        }
                        if (item["colWartoscKontraktuPLN"] != null)
                        {
                            double temp = (double)item["colWartoscKontraktuPLN"];
                            r.WartoscPLN = temp;
                        }
                        if (item["colCelFinansowania"] != null)
                        {
                            r.CelFinansowania = (String)item["colCelFinansowania"];
                        }
                        if (item["colDataNastepnegoKontaktu"] != null)
                        {
                            r.PlanowanyKontakt = (DateTime)item["colDataNastepnegoKontaktu"];
                        }
                        if (item["colUstalenia"] != null)
                        {
                            r.Ustalenia = (String)item["colUstalenia"];
                        }
                        if (item["colOperator"] != null)
                        {
                            SPFieldUserValue temp = new SPFieldUserValue(properties.Web, item["colOperator"].ToString()) ;
                            r.Operator = temp.LookupValue;
                        }

                        if (item["Last_x0020_Modified"] != null)
                        {
                            r.DataModyfikacji = DateTime.Parse(item["Last_x0020_Modified"].ToString());
                        }

                        if (item["colStatusLeadu"] != null)
                        {
                            r.Status = item["colStatusLeadu"].ToString();
                        }
                        if (item["ID"] != null)
                        {
                            r.ID = item["ID"].ToString();
                        }


                        result.Add(r);


                    }
                }
            }

            return result;
        }

        private string GetManagingPartnersEmails(SPItemEventProperties properties)
        {

            string result = string.Empty;

            using (SPSite site = new SPSite(properties.SiteId))
            {
                using (SPWeb web = site.AllWebs[properties.Web.ID])
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

            return result;
        }

        private string GetSmtpServer()
        {
            SPWebApplicationCollection spWebApplicationCollection = SPWebService.ContentService.WebApplications;
            SPOutboundMailServiceInstance smtpServer = new SPOutboundMailServiceInstance();
            if (spWebApplicationCollection != null)
            {
                foreach (SPWebApplication spWebApplication in spWebApplicationCollection)
                {
                    smtpServer = spWebApplication.OutboundMailServiceInstance;
                    return smtpServer.Server.Address;
                }
            }
            return string.Empty;
        }

        public void SendMail(SPWeb web, string from, string to, string subject, string body, string cc, string bcc)
        {
            try
            {
                StringDictionary headers = new StringDictionary();
                headers.Add("from", from);
                headers.Add("to", to);
                headers.Add("subject", subject);
                if (!String.IsNullOrEmpty(cc)) headers.Add("cc", cc);
                if (!String.IsNullOrEmpty(bcc)) headers.Add("bcc", bcc);
                headers.Add("content-type", "text/html");
                SPUtility.SendEmail(web, headers, body);
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

    }

    #region Classes

    public class Partner
    {
        public Partner(int id, string email, string name)
        {
            Id = id;
            Email = email;
            Name = name;
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class Agent
    {
        public int AgentId { get; set; }
        public String AgentName { get; set; }
        public String AgentEmail { get; set; }
        public String ManagerName { get; set; }
        public String ManagerEmail { get; set; }
        public String Grupa { get; set; }

    }

    public class Kontrakt : Agent
    {
        public String ID { get; set; }
        public DateTime DataZgloszenia { get; set; }
        public String Klient { get; set; }
        public Double WartoscPLN { get; set; }
        public String CelFinansowania { get; set; }
        public DateTime PlanowanyKontakt { get; set; }
        public String Ustalenia { get; set; }
        public String Operator { get; set; }
        public DateTime DataModyfikacji { get; set; }
        public String Status { get; set; }
    }

    public class MailMessage
    {
        public String To { get; set; }
        public String Cc { get; set; }
        public String Bcc { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }
    }

    #endregion
}
