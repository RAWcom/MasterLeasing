using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System.Text;

namespace masterleasing.Reports.tabKontraktyEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class tabKontraktyEventReceiver : SPItemEventReceiver
    {
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

           string status = GetText(properties.ListItem, "colStatusLeadu");
           int kontraktId = properties.ListItemId;
           //SPFieldUser user = (SPFieldUser)properties.ListItem["Editor"];

           SPSecurity.RunWithElevatedPrivileges(delegate()
           {
               Update_tabStatusTracking(properties, kontraktId, status, DateTime.Today);
           });

           this.EventFiringEnabled = true;
       }

private void Update_tabStatusTracking(SPItemEventProperties properties,int kontraktId,string status,DateTime targetDate)
{

           //sprawdź czy istnieje
            StringBuilder sb = new StringBuilder(@"<Where><And><And><Eq><FieldRef Name=""colKontraktId"" /><Value Type=""Number"">___KontraktId___</Value></Eq><Eq><FieldRef Name=""colStatusLeadu"" /><Value Type=""Text"">___Status___</Value></Eq></And><Eq><FieldRef Name=""Modified"" /><Value Type=""DateTime"">___TargetDate___</Value></Eq></And></Where>");
            sb.Replace("___KontraktId___",kontraktId.ToString());
           sb.Replace("___Status___",status.ToString());
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
                        li["colStatusLeadu"]= status.ToString();
                        li["Modified"] = targetDate.ToShortDateString();

                        li.Update();
                    }
                }
            }
       }

       #region Helpers

private SPUser GetUser_ModifiedBy(SPListItem item)
{
    SPFieldUserValue user = (SPFieldUserValue)item["Editor"];
    return user.User;
}

//SPUser user = properties.Web.EnsureUser("domain\\username");
//SPListItem item = properties.Item;
//item[SPBuiltInFieldId.Modified_x20_By] = user.ID + ";#" + user.loginName;
//item.SystemUpdate();

       private string GetText(SPListItem sPListItem, string p)
       {
           string result = string.Empty;

           if (sPListItem[p] != null)
           {
               result = sPListItem[p].ToString();
           }
           return result;
       }

       #endregion



    }
}
