using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System.Text;

namespace masterleasing.Reports.tabKontraktyAktywnosciEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class tabKontraktyAktywnosciEventReceiver : SPItemEventReceiver
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
            this.EventFiringEnabled = false;

            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    string result = ElasticEmailSendMailApp.ElasticTestMail.SendTestEmail("Start", DateTime.Now.ToString());    
                    
                    SPListItem item = properties.ListItem;
                    int kontraktId = new SPFieldLookupValue(item["colLinkDoKontraktu"] as string).LookupId;
                    string status = GetText(item, "colStatusKoncowy");

                    //SPFieldUser user = (SPFieldUser)properties.ListItem["Editor"];

                    Update_tabStatusTracking(properties, kontraktId, status, DateTime.Today);
                    result = ElasticEmailSendMailApp.ElasticTestMail.SendTestEmail("End", DateTime.Now.ToString());
                });

                properties.ListItem["colMEMO"] = DateTime.Now.ToString();
                properties.ListItem.Update();
            }
            catch (Exception ex)
            {
                string result = ElasticEmailSendMailApp.ElasticTestMail.SendTestEmail("Error", ex.ToString());
                properties.ListItem["colMEMO"] = ex.ToString();
                properties.ListItem.Update();
            }
           


           this.EventFiringEnabled = true;
       }

       private void Update_tabStatusTracking(SPItemEventProperties properties, int kontraktId, string status, DateTime targetDate)
       {

           //sprawdź czy istnieje
           StringBuilder sb = new StringBuilder(@"<Where><And><And><Eq><FieldRef Name=""colKontraktId"" /><Value Type=""Number"">___KontraktId___</Value></Eq><Eq><FieldRef Name=""colStatusLeadu"" /><Value Type=""Text"">___Status___</Value></Eq></And><Eq><FieldRef Name=""Modified"" /><Value Type=""DateTime"">___TargetDate___</Value></Eq></And></Where>");
           sb.Replace("___KontraktId___", kontraktId.ToString());
           sb.Replace("___Status___", status.ToString());
           sb.Replace("___TargetDate___", targetDate.ToShortDateString());

           SPQuery query = new SPQuery();
           query.Query = sb.ToString();

           using (SPSite site = new SPSite(properties.SiteId))
           {
               using (SPWeb web = site.AllWebs[properties.Web.ID])
               {
                   SPList list = web.Lists[@"tabStatusTracking"];

                   SPListItemCollection items = list.GetItems(query);
                   if (items.Count == 0)
                   {
                       SPListItem li = list.AddItem();
                       li["colKontraktId"] = kontraktId;
                       li["colStatusLeadu"] = status.ToString();
                       li["Modified"] = targetDate.ToShortDateString();

                       li.SystemUpdate();
                   }
               }
           }
       }

       private string GetText(SPListItem sPListItem, string p)
       {
           string result = string.Empty;

           if (sPListItem[p] != null)
           {
               result = sPListItem[p].ToString();
           }
           return result;
       }
    }
}
