using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;

namespace masterleasing.RaportDziennyTimerJob.Features.Feature1
{
 
    [Guid("4cba921a-f0f9-48fe-ab1a-59412fb22c9d")]
    public class Feature1EventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            var site = properties.Feature.Parent as SPSite;
            RaportDziennyTimerJob.CreateTimerJob(site);
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            var site = properties.Feature.Parent as SPSite;
            RaportDziennyTimerJob.DelteTimerJob(site);
        }
    }
}
