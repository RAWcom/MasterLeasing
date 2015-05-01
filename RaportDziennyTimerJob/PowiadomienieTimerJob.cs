using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;

namespace masterleasing.RaportDziennyTimerJob
{
    class RaportDziennyTimerJob : Microsoft.SharePoint.Administration.SPJobDefinition
    {


        public RaportDziennyTimerJob()
            : base()
        {
        }


        public RaportDziennyTimerJob(string jobName, SPService service, SPServer server, SPJobLockType targetType)
            : base(jobName, service, server, targetType)
        {
        }


        public RaportDziennyTimerJob(string jobName, SPWebApplication webApplication)
            : base(jobName, webApplication, null, SPJobLockType.ContentDatabase)
        {
            this.Title = "MasterLeasing_Raport Dzienny Timer Job";
        }

        public override void Execute(Guid contentDbId)
        {

            SPSecurity.RunWithElevatedPrivileges(delegate()
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

                //ElasticEmailSendMailApp.ElasticTestMail.SendTestEmail("OK: Raport Dzienny Timer Job", DateTime.Now.ToString());
            });

            //catch (Exception ex)
            //{
            //    SPSecurity.RunWithElevatedPrivileges(delegate()
            //    {
            //        //ElasticEmailSendMailApp.ElasticTestMail.SendTestEmail("ERR: Raport Dzienny Timer Job", ex.ToString());
            //    });
            //}


        }
    }
}
