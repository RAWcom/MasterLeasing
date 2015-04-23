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
        public const string STATUS_AKTYWNY = "W trakcie obsługi";
        public const string STATUS_ZAKONCZONY = "Zakończony";
        public const string STATUS_ANULOWANY = "Anulowany";


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
            this.EventFiringEnabled = false;

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                //określ rodzaj raportu
                string ct = properties.ListItem["ContentType"].ToString();
                switch (ct)
                {
                    case "RaportVIP":
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
                        properties.ListItem["colStatus"] = STATUS_ANULOWANY;
                        properties.ListItem.Update();
                        break;
                }
            });

            this.EventFiringEnabled = true;
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
            try
            {
                properties.ListItem["colStatus"] = STATUS_AKTYWNY;
                properties.ListItem.Update();


                //get parameters
                bool isRaportTestowy = true;

                if (properties.ListItem["colTrybUruchomienia"] != null)
                {
                    if (properties.ListItem["colTrybUruchomienia"].ToString() == "Produkcyjny")
                    {
                        isRaportTestowy = false;
                    }
                }

                //przygotuj listę rekordów spełniających kryteria
                StringBuilder sb = new StringBuilder(@"<OrderBy><FieldRef Name=""colDataZgloszenia"" Ascending=""FALSE"" /></OrderBy><Where><Geq><FieldRef Name=""colWartoscKontraktuPLN"" /><Value Type=""Currency"">200000</Value></Geq></Where>");
                SPQuery query = new SPQuery();
                query.Query = sb.ToString();

                ArrayList recordsAL = SelectContracts_VIP(properties, query);

                //validate contracts

                DateTime targetDate = DateTime.Now.AddDays(-14);

                foreach (Kontrakt r in recordsAL)
                {
                    r.IsValid = true;

                    if (r.Status == "Stracony" || r.Status == "Rozliczenie")
                    {
                        if (r.DataModyfikacji < targetDate)
                        {
                            r.IsValid = false;
                        }
                    }
                }

                for (int i = recordsAL.Count - 1; i <= 0; i--)
                {
                    Kontrakt r = (Kontrakt)recordsAL[i];
                    if (!r.IsValid)
                    {
                        recordsAL.RemoveAt(i);
                    }
                }

                //uzupełnij dane partnera
                UpdatePartnerDetails(properties, recordsAL);

                //przygotuj raport
                CreateReportVIP(properties, recordsAL, isRaportTestowy);

                properties.ListItem["colStatus"] = STATUS_ZAKONCZONY;
                properties.ListItem.Update();

            }
            catch (Exception ex)
            {
                properties.ListItem["colMEMO"] = ex.ToString();
                properties.ListItem["colStatus"] = STATUS_ANULOWANY;
                properties.ListItem.Update();
            }

        }
        private void CreateReportVIP(SPItemEventProperties properties, ArrayList recordsAL, bool isTestowy)
        {
            MailMsg msg = new MailMsg();
            SPListItem item = properties.ListItem;

            string s = "Raport VIP";

            //To = bieżący użytkownik
            if (item["Author"] != null)
            {
                SPFieldUserValue op = new SPFieldUserValue(properties.Web, item["Author"].ToString());
                msg.To = op.User.Email;
            }
            //SPUser currentUser = properties.Web.SiteUsers.GetByID(properties.CurrentUserId);
            //msg.To = currentUser.Email;

            //Cc, Subject
            if (!s.StartsWith(":: "))
            {
                s = ":: " + s;
            }

            if (isTestowy)
            {
                msg.Cc = string.Empty;
                msg.Subject = ":: TESTOWY " + s;

            }
            else
            {
                //msg.Cc = GetManagingPartnersEmails(properties);
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
.auto-style2 {
	font-family: Arial, Helvetica, sans-serif;
	font-size: xx-small;
	text-align: left;
}
</style>
</head><body style=""font-family: Arial""><table style=""width: 680px""><tr><td><table style=""width: 100%""><tr><td align=""center"" valign=""middle""><h3>Raport VIP</h3>
<ul><li class=""auto-style2"">Uwzględnia wyłącznie rekordy o wartości 
kontraktu &gt; 200000 PLN</li>
<li class=""auto-style2"">Nie wyświetla rekordów o statusie <strong>
Stracony</strong> i <strong>Rozliczenie</strong> modyfikowanych dawniej 
niż 14 dni temu</li>
	<li class=""auto-style2"">Sortowanie w/g Daty zgłoszenia - malejąco</li>
</ul>
<p>&nbsp;</p></td>
	<td align=""right""><img alt=""logo"" src=""http://stafix24cdn.blob.core.windows.net/sharedfiles/masterleasingLogo.PNG"" width=""110"" /></td></tr></table></td></tr><tr><td><table cellpadding=""2"" cellspacing=""1"" class=""style1"" style=""width: 100%; font-size: x-small""><thead style=""background: silver""><tr><td class=""style2"">#</td><td class=""style2"">Grupa</td><td class=""style2"">Menedżer</td><td class=""style2"">Agent</td><td class=""style2"">Klient</td><td class=""style2"">Data zgłoszenia</td><td class=""style2"">Wartość PLN</td><td class=""style2"">Cel finansowania</td><td class=""style2"">Status</td><td class=""style2"">Ustalenia z klientem</td><td class=""style2"">Data następnego kontaktu</td><td class=""style2"">Operator</td></tr></thead>***TBody*** </table></td></tr><tr><td>&nbsp;</td></tr>
</table></body>");

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
                       r.DataZgloszeniaDisplay,
                       r.WartoscPLNDisplay,
                       r.CelFinansowania,
                       r.Status,
                       r.Ustalenia,
                       r.PlanowanyKontaktDisplay,
                       r.Operator));
            }

            sb0.Append("</tbody>");

            sb.Replace(@"***TBody***", sb0.ToString());

            //legenda
            sb.Append(@"<table style=""width: 680px""><tbody><tr><td colspan=""2"" style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><strong>Legenda</strong></td></tr><tr valign=""top""><td style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozmowa - wniosek w trakcie weryfikacji telefonicznej</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Oferta - przygotwanie i decyzja Klienta w sprawie oferty</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Wniosek - oferta zaakceptowana, przygotowanie i decyzja Banku w sprawie przyznania środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Umowa - wniosek zaaprobowany przez Bank, przygotowanie i akceptacja umowy przez Klienta</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Uruchomienie - umowa zaakceptowana, uruchomienie środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozliczenie - środki uruchomione, kontrakt do rozliczenie prowizji</li></ul></td><td><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Stracony - wniosek stracony, klient nie zaakceptował oferty lub odstąpił od kontraktu z innych przyczyn</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Telefon - zaplanowany kontakt z Klientem w późniejszym terminie</li></ul></td></tr></tbody></table>");

            msg.Body = sb.ToString();


            //wyślij raport mailem

            SendMail(properties, msg);
        }
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
        private ArrayList SelectContracts_VIP(SPItemEventProperties properties, SPQuery query)
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
                            SPFieldUserValue temp = new SPFieldUserValue(properties.Web, item["colOperator"].ToString());
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

        #endregion

        #region Raport1Sprawa

        private void Create_Raport1Sprawa(SPItemEventProperties properties)
        {
            try
            {
                properties.ListItem["colStatus"] = STATUS_AKTYWNY;
                properties.ListItem.Update();

                //get parameters
                bool isRaportTestowy = true;

                if (properties.ListItem["colTrybUruchomienia"] != null)
                {
                    if (properties.ListItem["colTrybUruchomienia"].ToString() == "Produkcyjny")
                    {
                        isRaportTestowy = false;
                    }
                }

                ArrayList agentsAL = SelectAgents_1Sprawa(properties);
                ArrayList recordsAL = SelectContracts_1Sprawa(properties, agentsAL);

                //przygotuj raport
                CreateReport1Sprawa(properties, recordsAL, isRaportTestowy);

                properties.ListItem["colStatus"] = STATUS_ZAKONCZONY;
                properties.ListItem.Update();

            }
            catch (Exception ex)
            {
                properties.ListItem["colMEMO"] = ex.ToString();
                properties.ListItem["colStatus"] = STATUS_ANULOWANY;
                properties.ListItem.Update();
            }
        }
        private void CreateReport1Sprawa(SPItemEventProperties properties, ArrayList recordsAL, bool isRaportTestowy)
        {
            MailMsg msg = new MailMsg();
            SPListItem item = properties.ListItem;

            string s = "Raport - Pierwsza Sprawa";

            //To = bieżący użytkownik
            if (item["Author"] != null)
            {
                SPFieldUserValue op = new SPFieldUserValue(properties.Web, item["Author"].ToString());
                msg.To = op.User.Email;
            }
            //SPUser currentUser = properties.Web.SiteUsers.GetByID(properties.CurrentUserId);
            //msg.To = currentUser.Email;

            //Cc, Subject
            if (!s.StartsWith(":: "))
            {
                s = ":: " + s;
            }

            if (isRaportTestowy)
            {
                msg.Cc = string.Empty;
                msg.Subject = ":: TESTOWY " + s;

            }
            else
            {
                //msg.Cc = GetManagingPartnersEmails(properties);
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
.auto-style2 {
	font-family: Arial, Helvetica, sans-serif;
	font-size: xx-small;
	text-align: left;
}
</style>
</head><body style=""font-family: Arial""><table style=""width: 680px""><tr><td><table style=""width: 100%""><tr><td align=""center"" valign=""middle""><h3>
	Raport - Pierwsza Sprawa</h3>
<ul><li class=""auto-style2"">Dla aktywnych agentów wyświetla informacje o 
	pierwszej sprawie</li>
</ul>
	</td>
	<td align=""right""><img alt=""logo"" src=""http://stafix24cdn.blob.core.windows.net/sharedfiles/masterleasingLogo.PNG"" width=""110"" /></td></tr></table></td></tr><tr><td><table cellpadding=""2"" cellspacing=""1"" class=""style1"" style=""width: 100%; font-size: x-small""><thead style=""background: silver""><tr><td class=""style2"">#</td><td class=""style2"">Grupa</td><td class=""style2"">Menedżer</td><td class=""style2"">Agent</td><td class=""style2"">Klient</td><td class=""style2"">Data zgłoszenia</td><td class=""style2"">Wartość PLN</td><td class=""style2"">Cel finansowania</td><td class=""style2"">Status</td><td class=""style2"">Ustalenia z klientem</td><td class=""style2"">Data następnego kontaktu</td><td class=""style2"">Operator</td></tr></thead>***TBody*** </table></td></tr><tr><td>&nbsp;</td></tr>
</table></body>");

            //TBody

            StringBuilder sb0 = new StringBuilder(@"<tbody>");

            if (recordsAL.Count > 0)
            {
                string groupHeader = string.Empty;

                string groupHeaderBackgroundColor = @"style=""background:#CCCCCC"""; //szary



                foreach (Kontrakt r in recordsAL)
                {

                    string newGroupHeader = r.AgentName;
                    if (newGroupHeader != groupHeader)
                    {
                        sb0.Append(String.Format(@"<tr {0}><td class=""style2"" colspan=""12"">{1}</td></tr>",
                            groupHeaderBackgroundColor,
                            newGroupHeader));
                        groupHeader = newGroupHeader;
                    }

                    string backgroundColor = string.Empty;
                    if (r.Status == "Stracony") backgroundColor = @"style=""background:#CCCCCC"""; //szary
                    if (r.Status == "Uruchomienie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony
                    if (r.Status == "Rozliczenie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony
                    if (r.DataZgloszenia == DateTime.MinValue) backgroundColor = @"style=""background:#F1D0A7"""; //pomarańcz

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
                           r.DataZgloszeniaDisplay,
                           r.WartoscPLNDisplay,
                           r.CelFinansowania,
                           r.Status,
                           r.Ustalenia,
                           r.PlanowanyKontaktDisplay,
                           r.Operator));

                }
            }

            sb0.Append("</tbody>");

            sb.Replace(@"***TBody***", sb0.ToString());

            //legenda
            //sb.Append(@"<table style=""width: 680px""><tbody><tr><td colspan=""2"" style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><strong>Legenda</strong></td></tr><tr valign=""top""><td style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozmowa - wniosek w trakcie weryfikacji telefonicznej</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Oferta - przygotwanie i decyzja Klienta w sprawie oferty</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Wniosek - oferta zaakceptowana, przygotowanie i decyzja Banku w sprawie przyznania środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Umowa - wniosek zaaprobowany przez Bank, przygotowanie i akceptacja umowy przez Klienta</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Uruchomienie - umowa zaakceptowana, uruchomienie środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozliczenie - środki uruchomione, kontrakt do rozliczenie prowizji</li></ul></td><td><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Stracony - wniosek stracony, klient nie zaakceptował oferty lub odstąpił od kontraktu z innych przyczyn</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Telefon - zaplanowany kontakt z Klientem w późniejszym terminie</li></ul></td></tr></tbody></table>");

            msg.Body = sb.ToString();

            //wyślij raport mailem

            SendMail(properties, msg);

        }
        private ArrayList SelectContracts_1Sprawa(SPItemEventProperties properties, ArrayList agentsAL)
        {
            //wybierz posortowane kontrakty w/g daty agenta i daty zgłoszenia
            StringBuilder sb = new StringBuilder(@"<OrderBy><FieldRef Name=""colPartner_x002e_OsobaKontaktowa"" /><FieldRef Name=""colDataZgloszenia"" /></OrderBy>");
            SPQuery query = new SPQuery();
            query.Query = sb.ToString();

            ArrayList result = new ArrayList();

            using (SPSite site = new SPSite(properties.SiteId))
            {
                using (SPWeb web = site.AllWebs[properties.Web.ID])
                {
                    SPList list = web.Lists[@"tabKontrakty"];

                    SPListItemCollection items = list.GetItems(query);

                    //dla wybranej listy agentów
                    foreach (Agent oAgent in agentsAL)
                    {
                        int caseCounter = 0;

                        //wyszukaj pierwszego kontraktu
                        bool isContractFound = false;
                        foreach (SPListItem item in items)
                        {
                            int agentId = 0;

                            if (item["colPartner_x002e_OsobaKontaktowa"] != null)
                            {
                                SPFieldLookupValue temp = new SPFieldLookupValue(item["colPartner_x002e_OsobaKontaktowa"].ToString());
                                agentId = temp.LookupId;
                            }

                            if (oAgent.AgentId == agentId)
                            {
                                AddKontrakt_1Sprawa(properties, result, item, oAgent);
                                isContractFound = true;
                                caseCounter += 1;
                                if (caseCounter >= 3)
                                {
                                    break;
                                }
                            }
                        }
                        if (!isContractFound)
                        {
                            AddKontrakt_1Sprawa(properties, result, null, oAgent);
                        }
                    }
                }
            }

            return result;
        }
        private void AddKontrakt_1Sprawa(SPItemEventProperties properties, ArrayList result, SPListItem item, Agent oAgent)
        {
            Kontrakt r = new Kontrakt();

            r.AgentId = oAgent.AgentId;
            r.AgentName = oAgent.AgentName;
            r.AgentEmail = oAgent.AgentEmail;
            r.ManagerName = oAgent.ManagerName;
            r.ManagerEmail = oAgent.ManagerEmail;
            r.Grupa = oAgent.Grupa;
            r.IsValid = true;

            if (item != null)
            {
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
                    SPFieldUserValue temp = new SPFieldUserValue(properties.Web, item["colOperator"].ToString());
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
            }


            result.Add(r);
        }
        private ArrayList SelectAgents_1Sprawa(SPItemEventProperties properties)
        {
            //wybierz tylko aktywnych handlowców posortowanych w/g grupy, managera i agenta
            //StringBuilder sb = new StringBuilder(@"<GroupBy Collapse=""FALSE"" GroupLimit=""10000""><FieldRef Name=""colGrupa"" /><FieldRef Name=""colManager"" /></GroupBy><OrderBy><FieldRef Name=""colOsobaKontaktowa"" /></OrderBy><Where><Eq><FieldRef Name=""colAktywny"" /><Value Type=""Boolean"">1</Value></Eq></Where>");

            //wybierz tylko aktywnych handlowców posortowanych w/g grupy, managera i agenta z grupy Księgowi
            StringBuilder sb = new StringBuilder(@"<GroupBy Collapse=""FALSE"" GroupLimit=""10000""><FieldRef Name=""colGrupa"" /><FieldRef Name=""colManager"" /></GroupBy><OrderBy><FieldRef Name=""colOsobaKontaktowa"" /></OrderBy><Where><And><Eq><FieldRef Name=""colAktywny"" /><Value Type=""Boolean"">1</Value></Eq><Eq><FieldRef Name=""colGrupa"" /><Value Type=""Text"">Księgowi</Value></Eq></And></Where>");


            SPQuery query = new SPQuery();
            query.Query = sb.ToString();

            ArrayList result = new ArrayList();

            using (SPSite site = new SPSite(properties.SiteId))
            {
                using (SPWeb web = site.AllWebs[properties.Web.ID])
                {
                    SPList list = web.Lists[@"tabPartnerzy"];

                    SPListItemCollection items = list.GetItems(query);
                    foreach (SPListItem item in items)
                    {
                        //wybierze tylko agentów z linii leasing
                        if (item["colLinie"] != null)
                        {
                            string s = item["colLinie"].ToString();
                            if (s.Contains("#Leasing"))
                            {

                                Agent r = new Agent();

                                r.AgentId = item.ID;

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

                                result.Add(r);

                            }
                        }
                    }
                }
            }

            return result;
        }

        #endregion

        #region RaportDlaGrupy

        private void Create_RaportDlaGrupy(SPItemEventProperties properties)
        {
            try
            {
                properties.ListItem["colStatus"] = STATUS_AKTYWNY;
                properties.ListItem.Update();

                //get parameters
                bool isRaportTestowy = true;
                DateTime beginDate = DateTime.MinValue;
                DateTime endDate = DateTime.MinValue;
                SPFieldMultiChoiceValue groupsCollection = new SPFieldMultiChoiceValue();

                if (properties.ListItem["colTrybUruchomienia"] != null)
                {
                    if (properties.ListItem["colTrybUruchomienia"].ToString() == "Produkcyjny")
                    {
                        isRaportTestowy = false;
                    }
                }

                if (properties.ListItem["colOdDatyZgloszenia"] != null)
                {
                    DateTime.TryParse(properties.ListItem["colOdDatyZgloszenia"].ToString(), out beginDate);
                }

                if (properties.ListItem["colDoDatyZgloszenia"] != null)
                {
                    DateTime.TryParse(properties.ListItem["colDoDatyZgloszenia"].ToString(), out endDate);
                }

                if (properties.ListItem["colGrupa"] != null)
                {
                    groupsCollection = new SPFieldMultiChoiceValue(properties.ListItem["colGrupa"].ToString());
                }

                //validacja danych
                string errorMessage = string.Empty;
                if (endDate<beginDate)
                {
                    errorMessage = String.Format(@"{0}<li>{1}</li>",
                        errorMessage,
                        "Nieprawidłowy zakres dat");
                }
                if (groupsCollection.Count == 0)
                {
                    errorMessage = String.Format(@"{0}<li>{1}</li>",
                        errorMessage,
                        "Nie wybrano grup do raportowania");
                }

                if (errorMessage.Length > 0)
                {
                    properties.ListItem["colMEMO"] = errorMessage.ToString();
                    properties.ListItem["colStatus"] = STATUS_ANULOWANY;
                    properties.ListItem.Update();
                }
                else
                {
                    //ArrayList recordsAL = SelectContracts_DlaGrupy(properties, beginDate, endDate, groupsCollection);
                    //CreateReportDlaGrupy(properties, recordsAL, isRaportTestowy, beginDate, endDate, groupsCollection);

                    ArrayList totalsAL = SelectTotals_DlaGrupy(properties, beginDate, endDate, groupsCollection);
                    CreateReportDlaGrupy_Summary(properties, totalsAL, isRaportTestowy, beginDate, endDate, groupsCollection);

                    properties.ListItem["colStatus"] = STATUS_ZAKONCZONY;
                    properties.ListItem.Update();
                }

            }
            catch (Exception ex)
            {
                properties.ListItem["colMEMO"] = ex.ToString();
                properties.ListItem["colStatus"] = STATUS_ANULOWANY;
                properties.ListItem.Update();
            }
        }

        private ArrayList SelectTotals_DlaGrupy(SPItemEventProperties properties, DateTime beginDate, DateTime endDate, SPFieldMultiChoiceValue groupsCollection)
        {
            ArrayList agentsAL = SelectAgents_DlaGrupy(properties,groupsCollection);

            string mGroup = string.Empty ;
            string mManager = string.Empty;
            string mAgent = string.Empty ;
            int mLiczbaNowychSpraw = 0;
            int mLiczbaSpraw_Wniosek = 0;
            int mLiczbaSpraw_Uruchomienie = 0;

            ArrayList result = new ArrayList();

            if (agentsAL.Count > 0)
            {
                //otwórz bazę kontraktów
                using (SPSite site = new SPSite(properties.SiteId))
                {
                    using (SPWeb web = site.AllWebs[properties.Web.ID])
                    {
                        
                        //wybierze kontrakty zgłoszone w zadanym przedziale dat
                        StringBuilder sb = new StringBuilder(@"<OrderBy><FieldRef Name=""ID"" /><FieldRef Name=""colDataZgloszenia"" /></OrderBy><Where><And><Geq><FieldRef Name=""colDataZgloszenia"" /><Value Type=""DateTime"">***beginDate***</Value></Geq><Leq><FieldRef Name=""colDataZgloszenia"" /><Value Type=""DateTime"">***endDate***</Value></Leq></And></Where>");
                        sb.Replace("***beginDate***", beginDate.ToShortDateString());
                        sb.Replace("***endDate***", endDate.ToShortDateString());
                        SPQuery query = new SPQuery();
                        query.Query = sb.ToString();

                        SPList list = web.Lists[@"tabKontrakty"];
                        SPListItemCollection kontrakty = list.GetItems(query);

                        list = web.Lists[@"tabKontrakty_Aktywnosci"];
                        SPListItemCollection kontrakty_aktywnosci = list.GetItems();



                        Reset_gti(ref mLiczbaNowychSpraw, ref mLiczbaSpraw_Wniosek, ref mLiczbaSpraw_Uruchomienie);
                        Agent o = (Agent)agentsAL[0];

                        foreach (Agent r in agentsAL)
                        {
                            int counterLiczbaNowychSpraw = 0;
                            int counterLiczbaSpraw_Wniosek = 0;
                            int counterLiczbaSpraw_Uruchomienie = 0;

                            if (r.Grupa == mGroup && r.ManagerName == mManager && r.AgentName == mAgent)
                            {
                                //
                            }
                            else
                            {
                                //dodaj nowy rekord
                                GroupTotalsItem gti = new GroupTotalsItem();
                                gti.Grupa = r.Grupa;
                                gti.ManagerName = r.ManagerName;
                                gti.AgentName = r.AgentName;

                                //policz nowe sprawy
                                foreach (SPListItem item in kontrakty)
                                {
                                    if (item["colPartner_x002e_OsobaKontaktowa"] != null)
                                    {
                                        SPFieldLookupValue temp = new SPFieldLookupValue(item["colPartner_x002e_OsobaKontaktowa"].ToString());
                                        int agentId = temp.LookupId;
                                        
                                        if (agentId == r.AgentId)
                                        {
                                            counterLiczbaNowychSpraw += 1;

                                            if (item["colStatusLeadu"] != null)
                                            {
                                                string status = item["colStatusLeadu"].ToString();
                                                switch (status)
                                                {
                                                    case "Wniosek":
                                                        counterLiczbaSpraw_Wniosek += 1;
                                                        break;
                                                    case "Umowa":
                                                        counterLiczbaSpraw_Wniosek += 1;
                                                        break;
                                                    case "Uruchomienie":
                                                        counterLiczbaSpraw_Wniosek += 1;
                                                        counterLiczbaSpraw_Uruchomienie += 1;
                                                        break;
                                                    case "Rozliczenie":
                                                        counterLiczbaSpraw_Wniosek += 1;
                                                        counterLiczbaSpraw_Uruchomienie += 1;
                                                        break;
                                                    case "Stracony":
                                                        if (CheckStatusOccurence("Wniosek", item.ID, kontrakty_aktywnosci))
                                                        {
                                                            counterLiczbaSpraw_Wniosek += 1;
                                                        }
                                                        break;
                                                    case "Oferta":
                                                        if (CheckStatusOccurence("Wniosek", item.ID, kontrakty_aktywnosci))
                                                        {
                                                            counterLiczbaSpraw_Wniosek += 1;
                                                        }
                                                        break;
                                                    case "Telefon":
                                                        if (CheckStatusOccurence("Wniosek", item.ID, kontrakty_aktywnosci))
                                                        {
                                                            counterLiczbaSpraw_Wniosek += 1;
                                                        }
                                                        break;

                                                    default:
                                                        break;
                                                }

                                            }
                                        }

                                    }
                                }
                                gti.LiczbaNowychSpraw = counterLiczbaNowychSpraw;
                                gti.LiczbaSpraw_Wniosek = counterLiczbaSpraw_Wniosek;
                                gti.LiczbaSpraw_Uruchmienie = counterLiczbaSpraw_Uruchomienie;
                                

                                result.Add(gti);
                                Reset_gti(ref mLiczbaNowychSpraw, ref mLiczbaSpraw_Wniosek, ref mLiczbaSpraw_Uruchomienie);
                                mGroup = gti.Grupa;
                                mManager = gti.ManagerName;
                                mAgent = gti.AgentName;
                            }

                        }
                    }
                }

            }
            return result;
        }

        private bool CheckStatusOccurence(string status, int p, SPListItemCollection kontrakty_aktywnosci)
        {
            bool statusFound = false;

            foreach (SPListItem item in kontrakty_aktywnosci)
            {
                if (item["colLinkDoKontraktu"] != null)
                {
                    SPFieldLookupValue temp = new SPFieldLookupValue(item["colLinkDoKontraktu"].ToString());
                    int kontraktId = temp.LookupId;

                    if (item["colStatusKoncowy"] != null)
                    {
                        if (item["colStatusKoncowy"]==status)
                        {
                            statusFound = true;
                            break;
                        }
                    }

                    if (item["colStatusPoczatkowy"] != null)
                    {
                        if (item["colStatusPoczatkowy"] == status)
                        {
                            statusFound = true;
                            break;
                        }

                    }
                }
            }

            return statusFound;
        }

        private static void Reset_gti(ref int mLiczbaNowychSpraw, ref int mLiczbaSpraw_Wniosek, ref int mLiczbaSpraw_Uruchomienie)
        {
            mLiczbaNowychSpraw = 0;
            mLiczbaSpraw_Wniosek = 0;
            mLiczbaSpraw_Uruchomienie = 0;
        }

        private void CreateReportDlaGrupy(SPItemEventProperties properties, ArrayList recordsAL, bool isRaportTestowy, DateTime beginDate, DateTime endDate, SPFieldMultiChoiceValue groupsCollection)
        {

            MailMsg msg = new MailMsg();
            SPListItem item = properties.ListItem;

            string groupList = string.Empty;
            for (int i = 0; i < groupsCollection.Count; i++)
			{
			    if (i>0)
	            {
		             groupList = groupList + ",";
	            }
                groupList = groupList+groupsCollection[i].ToString();
                
			}
            string s = String.Format("Raport dla Grupy [{0}] za okres {1}..{2}",
                groupList,
                beginDate.ToShortDateString(),
                endDate.ToShortDateString());

            //To = bieżący użytkownik
            if (item["Author"] != null)
            {
                SPFieldUserValue op = new SPFieldUserValue(properties.Web, item["Author"].ToString());
                msg.To = op.User.Email;
            }
            //SPUser currentUser = properties.Web.SiteUsers.GetByID(properties.CurrentUserId);
            //msg.To = currentUser.Email;

            //Cc, Subject
            if (!s.StartsWith(":: "))
            {
                s = ":: " + s;
            }

            if (isRaportTestowy)
            {
                msg.Cc = string.Empty;
                msg.Subject = ":: TESTOWY " + s;

            }
            else
            {
                //msg.Cc = GetManagingPartnersEmails(properties);
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
.auto-style2 {
	font-family: Arial, Helvetica, sans-serif;
	font-size: xx-small;
	text-align: left;
}
</style>
</head><body style=""font-family: Arial""><table style=""width: 680px""><tr><td><table style=""width: 100%""><tr><td align=""center"" valign=""middle""><h3>
	Raport dla Grupy</h3>
<ul><li class=""auto-style2"">Dla aktywnych agentów wyświetla informacje o 
	pierwszej sprawie</li>
</ul>
	</td>
	<td align=""right""><img alt=""logo"" src=""http://stafix24cdn.blob.core.windows.net/sharedfiles/masterleasingLogo.PNG"" width=""110"" /></td></tr></table></td></tr><tr><td><table cellpadding=""2"" cellspacing=""1"" class=""style1"" style=""width: 100%; font-size: x-small""><thead style=""background: silver""><tr><td class=""style2"">#</td><td class=""style2"">Grupa</td><td class=""style2"">Menedżer</td><td class=""style2"">Agent</td><td class=""style2"">Klient</td><td class=""style2"">Data zgłoszenia</td><td class=""style2"">Wartość PLN</td><td class=""style2"">Cel finansowania</td><td class=""style2"">Status</td><td class=""style2"">Ustalenia z klientem</td><td class=""style2"">Data następnego kontaktu</td><td class=""style2"">Operator</td></tr></thead>***TBody*** </table></td></tr><tr><td>&nbsp;</td></tr>
</table></body>");

            //TBody

            StringBuilder sb0 = new StringBuilder(@"<tbody>");

            if (recordsAL.Count > 0)
            {
                string groupHeader = string.Empty;

                string groupHeaderBackgroundColor = @"style=""background:#CCCCCC"""; //szary

                foreach (Kontrakt r in recordsAL)
                {

                    string newGroupHeader = r.Grupa;
                    if (newGroupHeader != groupHeader)
                    {
                        sb0.Append(String.Format(@"<tr {0}><td class=""style2"" colspan=""12"">{1}</td></tr>",
                            groupHeaderBackgroundColor,
                            newGroupHeader));
                        groupHeader = newGroupHeader;
                    }

                    string backgroundColor = string.Empty;
                    if (r.Status == "Stracony") backgroundColor = @"style=""background:#CCCCCC"""; //szary
                    if (r.Status == "Uruchomienie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony
                    if (r.Status == "Rozliczenie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony
                    if (r.DataZgloszenia == DateTime.MinValue) backgroundColor = @"style=""background:#F1D0A7"""; //pomarańcz

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
                           r.DataZgloszeniaDisplay,
                           r.WartoscPLNDisplay,
                           r.CelFinansowania,
                           r.Status,
                           r.Ustalenia,
                           r.PlanowanyKontaktDisplay,
                           r.Operator));

                }


            }

            sb0.Append("</tbody>");

            sb.Replace(@"***TBody***", sb0.ToString());

            //legenda
            //sb.Append(@"<table style=""width: 680px""><tbody><tr><td colspan=""2"" style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><strong>Legenda</strong></td></tr><tr valign=""top""><td style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozmowa - wniosek w trakcie weryfikacji telefonicznej</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Oferta - przygotwanie i decyzja Klienta w sprawie oferty</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Wniosek - oferta zaakceptowana, przygotowanie i decyzja Banku w sprawie przyznania środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Umowa - wniosek zaaprobowany przez Bank, przygotowanie i akceptacja umowy przez Klienta</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Uruchomienie - umowa zaakceptowana, uruchomienie środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozliczenie - środki uruchomione, kontrakt do rozliczenie prowizji</li></ul></td><td><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Stracony - wniosek stracony, klient nie zaakceptował oferty lub odstąpił od kontraktu z innych przyczyn</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Telefon - zaplanowany kontakt z Klientem w późniejszym terminie</li></ul></td></tr></tbody></table>");

            msg.Body = sb.ToString();

            //wyślij raport mailem

            SendMail(properties, msg);
        }
        private void CreateReportDlaGrupy_Summary(SPItemEventProperties properties, ArrayList recordsAL, bool isRaportTestowy, DateTime beginDate, DateTime endDate, SPFieldMultiChoiceValue groupsCollection)
        {

            MailMsg msg = new MailMsg();
            SPListItem item = properties.ListItem;

            string groupList = string.Empty;
            for (int i = 0; i < groupsCollection.Count; i++)
            {
                if (i > 0)
                {
                    groupList = groupList + ",";
                }
                groupList = groupList + groupsCollection[i].ToString();

            }
            string s = String.Format("Raport dla Grupy [{0}] za okres {1}..{2}",
                groupList,
                beginDate.ToShortDateString(),
                endDate.ToShortDateString());

            //To = bieżący użytkownik
            if (item["Author"] != null)
            {
                SPFieldUserValue op = new SPFieldUserValue(properties.Web, item["Author"].ToString());
                msg.To = op.User.Email;
            }
            //SPUser currentUser = properties.Web.SiteUsers.GetByID(properties.CurrentUserId);
            //msg.To = currentUser.Email;

            //Cc, Subject
            if (!s.StartsWith(":: "))
            {
                s = ":: " + s;
            }

            if (isRaportTestowy)
            {
                msg.Cc = string.Empty;
                msg.Subject = ":: TESTOWY " + s;

            }
            else
            {
                //msg.Cc = GetManagingPartnersEmails(properties);
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
.auto-style2 {
	font-family: Arial, Helvetica, sans-serif;
	font-size: xx-small;
	text-align: left;
}
</style>
</head><body style=""font-family: Arial""><table style=""width: 680px""><tr><td><table style=""width: 100%""><tr><td align=""center"" valign=""middle""><h3>Raport dla Grupy</h3><ul><li class=""auto-style2"">Dla wybranych grup i zakresu dat wyświetla statystyki spraw</li></ul></td><td align=""right""><img alt=""logo"" src=""http://stafix24cdn.blob.core.windows.net/sharedfiles/masterleasingLogo.PNG"" width=""110"" /></td></tr></table></td></tr><tr><td><table cellpadding=""2"" cellspacing=""1"" class=""style1"" style=""width: 100%; font-size: x-small""><thead style=""background: silver""><tr><td class=""style2"">Grupa</td><td class=""style2"">Menedżer</td><td class=""style2"">Agent</td><td class=""style2"">Liczba nowych spraw</td><td class=""style2"">Liczba spraw które osiągnęły status <strong>Wniosek</strong></td><td class=""style2"">Liczba spraw które osiągnęły status <strong>Uruchomienie</strong></td></tr></thead>***TBody*** </table></td></tr><tr><td>&nbsp;</td></tr>
</table></body>");

            //TBody

            StringBuilder sb0 = new StringBuilder(@"<tbody>");
            StringBuilder sb0footer = new StringBuilder();

            if (recordsAL.Count > 0)
            {
                string groupHeader = string.Empty;
                int totalLiczbaNowychSpraw = 0;
                int totalLiczbaSpraw_Wniosek = 0;
                int totalLiczbaSpraw_Uruchomienie = 0;

                string groupHeaderBackgroundColor = @"style=""background:#CCCCCC"""; //szary

                bool isActiveGroupFooter = false;
                string newGroupHeader = string.Empty;

                foreach (GroupTotalsItem r in recordsAL)
                {

                    newGroupHeader = r.Grupa;
                    if (newGroupHeader != groupHeader)
                    {
                        if (isActiveGroupFooter)
                        {
                            AppendGroupFooter(sb0, totalLiczbaNowychSpraw, totalLiczbaSpraw_Wniosek, totalLiczbaSpraw_Uruchomienie, groupHeaderBackgroundColor, groupHeader);
                        }

                        sb0.Append(String.Format(@"<tr {0}><td class=""style2"" colspan=""6"">{1}</td></tr>",
                            groupHeaderBackgroundColor,
                            newGroupHeader));


                        groupHeader = newGroupHeader;
                        totalLiczbaNowychSpraw = 0;
                        totalLiczbaSpraw_Wniosek = 0;
                        totalLiczbaSpraw_Uruchomienie = 0;

                        isActiveGroupFooter = true;
                    }

                    string backgroundColor = string.Empty;
                    if (r.AgentIsActive) backgroundColor = @"style=""background:#CCCC00"""; //szary jaśniejszy

                    sb0.Append(String.Format(@"
                     <tr {0} valign=""top"">
        				<td class=""style2"">{1}</td>
        				<td class=""style2"">{2}</td>
        				<td class=""style2"">{3}</td>
        				<td class=""style2"" align=""center"">{4}</td>
        				<td class=""style2"" align=""center"">{5}</td>
        				<td class=""style2"" align=""center"">{6}</td>
        			</tr>",
                           backgroundColor,
                           r.Grupa,
                           r.ManagerName,
                           r.AgentName,
                           r.LiczbaNowychSpraw.ToString(),
                           r.LiczbaSpraw_Wniosek.ToString(),
                           r.LiczbaSpraw_Uruchmienie.ToString()));

                    totalLiczbaNowychSpraw = totalLiczbaNowychSpraw + r.LiczbaNowychSpraw;
                    totalLiczbaSpraw_Wniosek = totalLiczbaSpraw_Wniosek + r.LiczbaSpraw_Wniosek;
                    totalLiczbaSpraw_Uruchomienie = totalLiczbaSpraw_Uruchomienie + r.LiczbaSpraw_Uruchmienie;

                }
                if (isActiveGroupFooter)
                {
                    AppendGroupFooter(sb0, totalLiczbaNowychSpraw, totalLiczbaSpraw_Wniosek, totalLiczbaSpraw_Uruchomienie, groupHeaderBackgroundColor, groupHeader);
                }
            }

            sb0.Append("</tbody>");

            sb.Replace(@"***TBody***", sb0.ToString());

            //legenda
            //sb.Append(@"<table style=""width: 680px""><tbody><tr><td colspan=""2"" style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><strong>Legenda</strong></td></tr><tr valign=""top""><td style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozmowa - wniosek w trakcie weryfikacji telefonicznej</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Oferta - przygotwanie i decyzja Klienta w sprawie oferty</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Wniosek - oferta zaakceptowana, przygotowanie i decyzja Banku w sprawie przyznania środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Umowa - wniosek zaaprobowany przez Bank, przygotowanie i akceptacja umowy przez Klienta</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Uruchomienie - umowa zaakceptowana, uruchomienie środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozliczenie - środki uruchomione, kontrakt do rozliczenie prowizji</li></ul></td><td><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Stracony - wniosek stracony, klient nie zaakceptował oferty lub odstąpił od kontraktu z innych przyczyn</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Telefon - zaplanowany kontakt z Klientem w późniejszym terminie</li></ul></td></tr></tbody></table>");

            msg.Body = sb.ToString();

            //wyślij raport mailem

            SendMail(properties, msg);
        }

        private static void AppendGroupFooter(StringBuilder sb0, int totalLiczbaNowychSpraw, int totalLiczbaSpraw_Wniosek, int totalLiczbaSpraw_Uruchomienie, string groupHeaderBackgroundColor, string newGroupHeader)
        {
            sb0.Append(String.Format(@"<tr {0}>
                            <td class=""style2"" colspan=""3"">{1} RAZEM:</td>
                            <td class=""style2"" align=""center"">{2}</td>
                            <td class=""style2"" align=""center"">{3}</td>
                            <td class=""style2"" align=""center"">{4}</td>
                            </tr>",
            groupHeaderBackgroundColor,
            newGroupHeader,
            totalLiczbaNowychSpraw.ToString(),
            totalLiczbaSpraw_Wniosek.ToString(),
            totalLiczbaSpraw_Uruchomienie.ToString()));
        }

        private ArrayList SelectContracts_DlaGrupy(SPItemEventProperties properties, DateTime beginDate, DateTime endDate, SPFieldMultiChoiceValue groupsCollection)
        {
            ArrayList agentsAL = SelectAgents_DlaGrupy(properties, groupsCollection);

            //wybierze kontrakty zgłoszone w zadanym przedziale dat
            StringBuilder sb = new StringBuilder(@"<OrderBy><FieldRef Name=""ID"" /><FieldRef Name=""colDataZgloszenia"" /></OrderBy><Where><And><Geq><FieldRef Name=""colDataZgloszenia"" /><Value Type=""DateTime"">***beginDate***</Value></Geq><Leq><FieldRef Name=""colDataZgloszenia"" /><Value Type=""DateTime"">***endDate***</Value></Leq></And></Where>");
            sb.Replace("***beginDate***", beginDate.ToShortDateString());
            sb.Replace("***endDate***", endDate.ToShortDateString());
            SPQuery query = new SPQuery();
            query.Query = sb.ToString();

            ArrayList result = new ArrayList();

            using (SPSite site = new SPSite(properties.SiteId))
            {
                using (SPWeb web = site.AllWebs[properties.Web.ID])
                {
                    SPList list = web.Lists[@"tabKontrakty"];

                    SPListItemCollection items = list.GetItems(query);

                    //dla wybranej listy agentów
                    foreach (Agent oAgent in agentsAL)
                    {

                        //wyszukaj pierwszego kontraktu
                        bool isContractFound = false;
                        foreach (SPListItem item in items)
                        {
                            int agentId = 0;

                            if (item["colPartner_x002e_OsobaKontaktowa"] != null)
                            {
                                SPFieldLookupValue temp = new SPFieldLookupValue(item["colPartner_x002e_OsobaKontaktowa"].ToString());
                                agentId = temp.LookupId;
                            }

                            if (oAgent.AgentId == agentId)
                            {
                                AddKontrakt_1Sprawa(properties, result, item, oAgent);
                                isContractFound = true;
                            }
                        }
                        if (!isContractFound)
                        {
                            AddKontrakt_1Sprawa(properties, result, null, oAgent);
                        }
                    }
                }
            }

            return result;

        }

        private ArrayList SelectAgents_DlaGrupy(SPItemEventProperties properties, SPFieldMultiChoiceValue groupsCollection)
        {
            //wybierz tylko aktywnych handlowców posortowanych w/g grupy, managera i agenta gdzie grupa nie jest pusta
            StringBuilder sb = new StringBuilder(@"<GroupBy Collapse=""FALSE"" GroupLimit=""30000""><FieldRef Name=""colGrupa"" /><FieldRef Name=""colManager"" /></GroupBy><OrderBy><FieldRef Name=""colOsobaKontaktowa"" Ascending=""FALSE"" /></OrderBy><Where><IsNotNull><FieldRef Name=""colGrupa"" /></IsNotNull></Where>");

            SPQuery query = new SPQuery();
            query.Query = sb.ToString();

            ArrayList result = new ArrayList();

            using (SPSite site = new SPSite(properties.SiteId))
            {
                using (SPWeb web = site.AllWebs[properties.Web.ID])
                {
                    SPList list = web.Lists[@"tabPartnerzy"];

                    SPListItemCollection items = list.GetItems(query);
                    foreach (SPListItem item in items)
                    {
                        //wybierze tylko agentów z linii leasing
                        if (item["colLinie"] != null)
                        {
                            string s = item["colLinie"].ToString();
                            if (s.Contains("#Leasing"))
                            {

                                Agent r = new Agent();

                                r.AgentId = item.ID;

                                if (item["colAktywny"] != null)
                                {
                                    r.AgentIsActive = (bool)item["colAktywny"];
                                }

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

                                //dodaj wyłącznie agentów spełniających kryteria grupy

                                if (!String.IsNullOrEmpty(r.Grupa))
                                {
                                    for (int i = 0; i < groupsCollection.Count; i++)
			                        {
                                        if (r.Grupa == groupsCollection[i].ToString())
                                        {
                                            //dodaj agenta do listy
                                            result.Add(r);
                                            break;
                                        }
			                        }
                                    
                                }  

                                

                            }
                        }
                    }
                }
            }

            return result;

        }

        private void AddKontrakt_DlaGrupy(SPItemEventProperties properties, ArrayList result, SPListItem item)
        {
            Kontrakt r = new Kontrakt();

            r.IsValid = true;

            if (item != null)
            {
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
                    SPFieldUserValue temp = new SPFieldUserValue(properties.Web, item["colOperator"].ToString());
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
            }

            result.Add(r);

        }

        #endregion

        #region RaportOpoznione

        private void Create_RaportOpoznione(SPItemEventProperties properties)
        {
            try
            {
                properties.ListItem["colStatus"] = STATUS_AKTYWNY;
                properties.ListItem.Update();

                //get parameters
                bool isRaportTestowy = true;

                if (properties.ListItem["colTrybUruchomienia"] != null)
                {
                    if (properties.ListItem["colTrybUruchomienia"].ToString() == "Produkcyjny")
                    {
                        isRaportTestowy = false;
                    }
                }

                ArrayList recordsAL = SelectContracts_Opoznione(properties);

                //przygotuj raport
                CreateReportOpoznione(properties, recordsAL, isRaportTestowy);

                properties.ListItem["colStatus"] = STATUS_ZAKONCZONY;
                properties.ListItem.Update();

            }
            catch (Exception ex)
            {
                properties.ListItem["colMEMO"] = ex.ToString();
                properties.ListItem["colStatus"] = STATUS_ANULOWANY;
                properties.ListItem.Update();
            }
        }

        private void CreateReportOpoznione(SPItemEventProperties properties, ArrayList recordsAL, bool isRaportTestowy)
        {
            MailMsg msg = new MailMsg();
            SPListItem item = properties.ListItem;

            string s = "Sprawy Opóźnione";

            //To = bieżący użytkownik
            if (item["Author"] != null)
            {
                SPFieldUserValue op = new SPFieldUserValue(properties.Web, item["Author"].ToString());
                msg.To = op.User.Email;
            }
            //SPUser currentUser = properties.Web.SiteUsers.GetByID(properties.CurrentUserId);
            //msg.To = currentUser.Email;

            //Cc, Subject
            if (!s.StartsWith(":: "))
            {
                s = ":: " + s;
            }

            if (isRaportTestowy)
            {
                msg.Cc = string.Empty;
                msg.Subject = ":: TESTOWY " + s;

            }
            else
            {
                //msg.Cc = GetManagingPartnersEmails(properties);
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
.auto-style2 {
	font-family: Arial, Helvetica, sans-serif;
	font-size: xx-small;
	text-align: left;
}
</style>
</head><body style=""font-family: Arial""><table style=""width: 680px""><tr><td><table style=""width: 100%""><tr><td align=""center"" valign=""middle""><h3>Raport - Sprawy opóźnione</h3><ul><li class=""auto-style2"">Dla spraw w statusie: Oferta, Telefon, Wniosek, Umowa wyświetla sprawy przypisane do operatorów z przekroczonym terminem następnego kontaktu</li></ul></td><td align=""right""><img alt=""logo"" src=""http://stafix24cdn.blob.core.windows.net/sharedfiles/masterleasingLogo.PNG"" width=""110"" /></td></tr></table></td></tr><tr><td><table cellpadding=""2"" cellspacing=""1"" class=""style1"" style=""width: 100%; font-size: x-small""><thead style=""background: silver""><tr><td class=""style2"">#</td><td class=""style2"">Menedżer</td><td class=""style2"">Agent</td><td class=""style2"">Klient</td><td class=""style2"">Data zgłoszenia</td><td class=""style2"">Wartość PLN</td><td class=""style2"">Cel finansowania</td><td class=""style2"">Status</td><td class=""style2"">Ustalenia z klientem</td><td class=""style2"">Data następnego kontaktu</td><td class=""style2"">Operator</td><td class=""style2"">Ilość dni opóźnienia</td></tr></thead>***TBody*** </table></td></tr><tr><td>&nbsp;</td></tr></table></body>");

            //TBody

            int totalCounter = 0;

            //StringBuilder sb0 = new StringBuilder(@"<tbody>");
            StringBuilder sb0 = new StringBuilder();

            if (recordsAL.Count > 0)
            {
                string groupHeader = string.Empty;

                foreach (Kontrakt r in recordsAL)
                {
                    string groupHeaderBackgroundColor = @"style=""background:#CCCCCC"""; //szary

                    string newGroupHeader = r.Operator;
                    if (newGroupHeader != groupHeader)
                    {
                        sb0.Append(String.Format(@"<tr {0}><td class=""style2"" colspan=""12"">{1}</td></tr>",
                            groupHeaderBackgroundColor,
                            newGroupHeader));
                        groupHeader = newGroupHeader;
                    }

                    string backgroundColor = string.Empty;
                    //if (r.Status == "Stracony") backgroundColor = @"style=""background:#CCCCCC"""; //szary
                    //if (r.Status == "Uruchomienie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony
                    //if (r.Status == "Rozliczenie") backgroundColor = @"style=""background:#CCFFCC"""; //zielony

                    sb0.Append(String.Format(@"
                     <tr {0} valign=""top"">
        				<td class=""style2"">{1}</td>
        				<td class=""style2"">{2}</td>
        				<td class=""style2"">{3}</td>
        				<td class=""style2"">{4}</td>
        				<td class=""style2"">{5}</td>
        				<td class=""style2"" align=""right"">{6}</td>
                        <td class=""style2"">{7}</td>
        				<td class=""style2"">{8}</td>
        				<td class=""style2"">{9}</td>
                        <td class=""style2"">{10}</td>
                        <td class=""style2"">{11}</td>
                        <td class=""style2"" align=""center"">{12}</td>
        			</tr>",
                           backgroundColor,
                           r.ID,
                           r.ManagerName,
                           r.AgentName,
                           r.Klient,
                           r.DataZgloszeniaDisplay,
                           r.WartoscPLNDisplay,
                           r.CelFinansowania,
                           r.Status,
                           r.Ustalenia,
                           r.PlanowanyKontaktDisplay,
                           r.Operator,
                           r.IloscDniOpoznienia));

                    totalCounter += 1;
                }
            }
            else
            {
                sb0.Append(String.Format(@"<tr {0}><td class=""style2"" colspan=""12"">{1}</td></tr>",
                            String.Empty,
                            "Brak rekordów spełniających kryteria"));
            }
            //sb0.Append("</tbody>");

            sb.Replace(@"***TBody***", sb0.ToString());

            //legenda
            //sb.Append(@"<table style=""width: 680px""><tbody><tr><td colspan=""2"" style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><strong>Legenda</strong></td></tr><tr valign=""top""><td style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small""><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozmowa - wniosek w trakcie weryfikacji telefonicznej</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Oferta - przygotwanie i decyzja Klienta w sprawie oferty</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Wniosek - oferta zaakceptowana, przygotowanie i decyzja Banku w sprawie przyznania środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Umowa - wniosek zaaprobowany przez Bank, przygotowanie i akceptacja umowy przez Klienta</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Uruchomienie - umowa zaakceptowana, uruchomienie środków</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Rozliczenie - środki uruchomione, kontrakt do rozliczenie prowizji</li></ul></td><td><ul><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Stracony - wniosek stracony, klient nie zaakceptował oferty lub odstąpił od kontraktu z innych przyczyn</li><li style=""font-family: Arial, Helvetica, sans-serif; font-size: xx-small"">Telefon - zaplanowany kontakt z Klientem w późniejszym terminie</li></ul></td></tr></tbody></table>");



            msg.Body = sb.ToString();

            if (totalCounter > 0)
            {
                msg.Subject = String.Format("{0} [{1}]",
                    msg.Subject,
                    totalCounter.ToString());
            }


            //wyślij raport mailem

            SendMail(properties, msg);
        }

        private ArrayList SelectContracts_Opoznione(SPItemEventProperties properties)
        {
            //wybierz sprawy w statusie oferta, telefon, wniosek lub umowa przypisane do operatorów z przekroczoną datą planowanego kontaktu
            //agregacja w/g statusu i operatora
            StringBuilder sb = new StringBuilder(@"<GroupBy Collapse=""TRUE"" GroupLimit=""30""><FieldRef Name=""colStatusLeadu"" /><FieldRef Name=""colOperator"" /></GroupBy><OrderBy><FieldRef Name=""colOperator"" Ascending=""FALSE"" /><FieldRef Name=""colDataNastepnegoKontaktu""  /></OrderBy><Where><And><And><Or><Or><Or><Eq><FieldRef Name=""colStatusLeadu"" /><Value Type=""Text"">Oferta</Value></Eq><Eq><FieldRef Name=""colStatusLeadu"" /><Value Type=""Text"">Telefon</Value></Eq></Or><Eq><FieldRef Name=""colStatusLeadu"" /><Value Type=""Text"">Umowa</Value></Eq></Or><Eq><FieldRef Name=""colStatusLeadu"" /><Value Type=""Text"">Wniosek</Value></Eq></Or><Lt><FieldRef Name=""colDataNastepnegoKontaktu"" /><Value Type=""DateTime""><Today /></Value></Lt></And><IsNotNull><FieldRef Name=""colOperator"" /></IsNotNull></And></Where>");
            SPQuery query = new SPQuery();
            query.Query = sb.ToString();

            ArrayList result = new ArrayList();

            using (SPSite site = new SPSite(properties.SiteId))
            {
                using (SPWeb web = site.AllWebs[properties.Web.ID])
                {
                    SPList list = web.Lists[@"tabKontrakty"];

                    SPListItemCollection items = list.GetItems(query);

                    foreach (SPListItem item in items)
                    {
                        if (item["colOperator"] != null)
                        {

                            SPFieldUserValue op = new SPFieldUserValue(properties.Web, item["colOperator"].ToString());
                            string opName = op.LookupValue;
                            opName = op.User.Name;

                            AddKontrakt_Opoznione(properties, result, item, op);

                        }
                        else
                        {
                            AddKontrakt_Opoznione(properties, result, item, null);
                        }
                    }
                }
            }

            return result;
        }

        private void AddKontrakt_Opoznione(SPItemEventProperties properties, ArrayList result, SPListItem item, SPFieldUserValue op)
        {
            Kontrakt r = new Kontrakt();

            if (op != null)
            {
                r.Operator = op.User.Name;
            }
            else
            {
                r.Operator = string.Empty;
            }

            r.IsValid = true;

            if (item != null)
            {
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
                    SPFieldUserValue temp = new SPFieldUserValue(properties.Web, item["colOperator"].ToString());
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
            }


            result.Add(r);
        }

        #endregion

        private void Create_RaportHandlowca(SPItemEventProperties properties)
        {
            throw new NotImplementedException();
        }

        #region Helpers



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

        private void SendMail(SPItemEventProperties properties, MailMsg msg)
        {
            string url = properties.WebUrl;

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (SPSite site = new SPSite(url))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        // myemail@test.com is obviously replaced with a real working email
                        SendMail(properties.Web, "Master Leasing<noreply@stafix24.pl>", msg.To, msg.Subject, msg.Body, msg.Cc, msg.Bcc);
                    }
                }
            });
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
        public bool AgentIsActive { get; set; }

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
        public bool IsValid { get; set; }

        public String PlanowanyKontaktDisplay
        {
            get
            {
                if (PlanowanyKontakt == DateTime.MinValue)
                {
                    return string.Empty;
                }
                else
                {
                    return PlanowanyKontakt.ToShortDateString();
                }
            }
        }
        public String DataZgloszeniaDisplay
        {
            get
            {
                if (DataZgloszenia == DateTime.MinValue)
                {
                    return string.Empty;
                }
                else
                {
                    return DataZgloszenia.ToShortDateString();
                }
            }
        }

        public String WartoscPLNDisplay
        {
            get
            {
                if (WartoscPLN == 0)
                {
                    return string.Empty;
                }
                else
                {
                    return WartoscPLN.ToString();
                }
            }
        }

        public String IloscDniOpoznienia
        {
            get
            {
                if (PlanowanyKontakt <= DateTime.Today)
                {
                    return (DateTime.Today - PlanowanyKontakt).Days.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }

    public class MailMsg
    {
        public String To { get; set; }
        public String Cc { get; set; }
        public String Bcc { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }
    }

    public class GroupTotalsItem : Agent
    {
        public int LiczbaNowychSpraw { get; set; }
        public int LiczbaSpraw_Wniosek { get; set; }
        public int LiczbaSpraw_Uruchmienie { get; set; }

    }
    

    #endregion

}
    

