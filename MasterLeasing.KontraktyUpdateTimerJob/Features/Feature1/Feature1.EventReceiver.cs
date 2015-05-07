using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;

namespace MasterLeasing.KontraktyUpdateTimerJob.Features.Feature1
{
   
    [Guid("f9ab52c9-a144-4e04-80e4-e617b0617317")]
    public class Feature1EventReceiver : SPFeatureReceiver
    {
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            var site = properties.Feature.Parent as SPSite;
            KontraktyUpdateTimerJob.CreateTimerJob(site);
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            var site = properties.Feature.Parent as SPSite;
            KontraktyUpdateTimerJob.DelteTimerJob(site);
        }
    }
}
