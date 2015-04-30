using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;

namespace masterleasing.RaportDziennyTimerJob
{
    class RaportDziennyTimerJob:Microsoft.SharePoint.Administration.SPJobDefinition
    {
        /// <summary>
        /// wskazuje który site ma zostać wybrany jako domyślny, koniecznie należy go przestawić przed wgraniem na produkcję
        /// </summary>
        /// <remarks>
        /// true = sites["sites/ml"]
        /// false = sites[0]
        /// </remarks>
        bool DEV_MODE = false; 

       
        /// <summary> 
        /// Default Consructor 
        /// </summary> 
        public RaportDziennyTimerJob()
            : base()
        {
        }

        /// <summary> 
        /// Parameterized Constructor 
        /// </summary> 
        /// <param name="jobName">Name of Job to display in central admin</param> 
        /// <param name="service">SharePoint Service </param> 
        /// <param name="server">Name of the server</param> 
        /// <param name="targetType">job type is for content db or job</param> 
        public RaportDziennyTimerJob(string jobName, SPService service, SPServer server, SPJobLockType targetType)
            : base(jobName, service, server, targetType)
        {
        }

        /// <summary> 
        /// Parameterized Constructor 
        /// </summary> 
        /// <param name="jobName"></param> 
        /// <param name="webApplication"></param> 
        public RaportDziennyTimerJob(string jobName, SPWebApplication webApplication)
            : base(jobName, webApplication, null, SPJobLockType.ContentDatabase)
        {
            this.Title = "MasterLeasing_Raport Dzienny Timer Job";
        }

        public override void  Execute(Guid contentDbId)
        {

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {

                // get a reference to the current site collection's content database 
                SPWebApplication webApplication = this.Parent as SPWebApplication;
                SPContentDatabase contentDb = webApplication.ContentDatabases[contentDbId];

                SPWeb rootWeb;

                if (DEV_MODE)
                {
                    rootWeb = contentDb.Sites["sites/ml"].RootWeb; //wartość developerska
                }
                else
                {
                    rootWeb = contentDb.Sites[0].RootWeb;
                }

                SPList list = rootWeb.Lists.TryGetList("tabRaporty");

                if (list != null)
                {
                    SPListItem li = list.AddItem();
                    li["ContentType"] = "RaportDzienny";
                    li["Title"] = DateTime.Now.ToString();
                    li["colTrybUruchomienia"] = "Testowy";
                    li["colTargetDate"] = DateTime.Today.AddDays(-7);
                    //li["colTargetRecepient"] = "biuro@rawcom24.pl";
                    li.Update();
                }

                rootWeb.Dispose();
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
