using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint;

namespace masterleasing.RaportDziennyTimerJob
{
    public class TestTimerJob : SPJobDefinition
    {
        public const string JobName = "Test Timer Job";
        private string List_JOB_NAME;
        private SPWebApplication sPWebApplication;

        public TestTimerJob() : base() { }

        public TestTimerJob(SPWebApplication webApp)
            : base(JobName, webApp, null, SPJobLockType.Job)
        { this.Title = JobName; }

        public override void Execute(Guid targetInstanceId)
        {
            // Execute the timer job logic
            const string TARGET_LIST = "tabRaporty";
            const string DEV_SITE = "sites/ml";

            SPWebApplication webApp = this.Parent as SPWebApplication;

            #if DEBUG
            SPList taskList = webApp.Sites[DEV_SITE].RootWeb.Lists.TryGetList(TARGET_LIST);
            #else
            SPList taskList = webApp.Sites[0].RootWeb.Lists.TryGetList(TARGET_LIST);
            #endif


            if (taskList != null)
            {
                SPListItem newTask = taskList.Items.Add();
                newTask["ContentType"] = "RaportDzienny";
                newTask["Title"] = DateTime.Now.ToString();
                newTask.Update();
            }

        }
    }
}
