using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint;

namespace masterleasing.RaportDziennyTimerJob
{
    class RaportDziennyTimerJob : SPJobDefinition
    {
        public static void CreateTimerJob(SPSite site)
        {
            var timerJob = new RaportDziennyTimerJob(site);
            timerJob.Schedule = new SPHourlySchedule()
            {
                BeginMinute = 0,
                EndMinute = 5
            };
            timerJob.Update();
        }

        public static void DelteTimerJob(SPSite site)
        {
            site.WebApplication.JobDefinitions
                .OfType<RaportDziennyTimerJob>()
                .Where(i => string.Equals(i.SiteUrl, site.Url, StringComparison.InvariantCultureIgnoreCase))
                .ToList()
                .ForEach(i => i.Delete());
        }

        public RaportDziennyTimerJob()
            : base()
        {

        }

        public RaportDziennyTimerJob(SPSite site)
            : base(string.Format("MasterLeasing_Raport Dzienny Timer Job2 ({0})", site.Url), site.WebApplication, null, SPJobLockType.Job)
        {
            Title = Name;
            SiteUrl = site.Url;
        }

        public string SiteUrl
        {
            get { return (string)this.Properties["SiteUrl"]; }
            set { this.Properties["SiteUrl"] = value; }
        }

        public override void Execute(Guid targetInstanceId)
        {
            // Execute the timer job logic
            
            using (var site = new SPSite(SiteUrl))
            {
                var list = site.RootWeb.Lists.TryGetList("tabRaporty");
                if (list != null)
                {
                    SPListItem newItem = list.Items.Add();
                    newItem["ContentType"] = "RaportDzienny";
                    newItem["Title"] = DateTime.Now.ToString();
                    newItem.Update();
                }
            }

        }
    }
}
