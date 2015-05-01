using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Administration;
using System.Linq;

namespace masterleasing.RaportDziennyTimerJob.Features.TestTimerJobFeature
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("66b52dca-cc82-4d5f-b671-f7d9a2a55ccc")]
    public class TestTimerJobFeatureEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.
        private const string List_JOB_NAME = "MasterlesingRaportDziennyTimerJob";

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
  

            //WebApp Scope
            SPWebApplication webApp = properties.Feature.Parent as SPWebApplication;
            DeleteJob(webApp.JobDefinitions);
            TestTimerJob simpleJob = new TestTimerJob(webApp);
            SPMinuteSchedule schedule = new SPMinuteSchedule();
            schedule.BeginSecond = 0;
            schedule.EndSecond = 59;
            schedule.Interval = 1;
            simpleJob.Schedule = schedule;
            simpleJob.Update();
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
           

            //WebApp Scope
            SPWebApplication webApp = properties.Feature.Parent as SPWebApplication;
            DeleteJob(webApp.JobDefinitions);
        }


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}

        private void DeleteJob(SPJobDefinitionCollection jobs) 
        {
            foreach (SPJobDefinition job in jobs)
            {
                if (job.Name.Equals(TestTimerJob.JobName, StringComparison.OrdinalIgnoreCase)) 
                { job.Delete(); }
            } }
    }
}
