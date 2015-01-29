using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace masterleasing.RozliczenieKontraktu.OnUpdate.EventReceiver1
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class EventReceiver1 : SPItemEventReceiver
    {
       /// <summary>
       /// An item was added
       /// </summary>
       public override void ItemAdded(SPItemEventProperties properties)
       {
           UpdateAgendId(properties);
           
           base.ItemAdded(properties);
       }

       private void UpdateAgendId(SPItemEventProperties properties)
       {
           if (properties.ListItem.ParentList.Title=="tabRozliczeniaKontraktow")
           {
               //if (properties.ListItem["colPartner_x002e_OsobaKontaktowa"] != null)
               //{
               try
               {
                   properties.ListItem["colPartner_x002e_OsobaKontaktowa"] = 87;
                   properties.ListItem.Update();
               }
               catch (Exception)
               {

               }

               //}              
           }
           

       }

       /// <summary>
       /// An item was updated
       /// </summary>
       public override void ItemUpdated(SPItemEventProperties properties)
       {
           //UpdateAgendId(properties);

           base.ItemUpdated(properties);
       }

       /// <summary>
       /// An item is being added
       /// </summary>
       public override void ItemAdding(SPItemEventProperties properties)
       {
           //UpdateAgendId(properties);
           base.ItemAdding(properties);
       }

       /// <summary>
       /// An item is being updated
       /// </summary>
       public override void ItemUpdating(SPItemEventProperties properties)
       {
           //UpdateAgendId(properties);
           base.ItemUpdating(properties);
       }


    }
}
