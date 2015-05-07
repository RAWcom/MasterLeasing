using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace MasterLeasing.KontraktyUpdateTimerJob
{
    class KontraktyUpdateTimerJob : SPJobDefinition
    {
        public static void CreateTimerJob(SPSite site)
        {
            var timerJob = new KontraktyUpdateTimerJob(site);
            timerJob.Schedule = new SPDailySchedule()
            {
                BeginHour = 0,
                EndHour = 4
            };
            timerJob.Update();
        }

        public static void DelteTimerJob(SPSite site)
        {
            site.WebApplication.JobDefinitions
                .OfType<KontraktyUpdateTimerJob>()
                .Where(i => string.Equals(i.SiteUrl, site.Url, StringComparison.InvariantCultureIgnoreCase))
                .ToList()
                .ForEach(i => i.Delete());
        }

        public KontraktyUpdateTimerJob()
            : base()
        {

        }

        public KontraktyUpdateTimerJob(SPSite site)
            : base(string.Format("MasterLeasing_Kontrakty Update Timer Job ({0})", site.Url), site.WebApplication, null, SPJobLockType.Job)
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

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (var site = new SPSite(SiteUrl))
                {
                    var targetList = site.RootWeb.Lists.TryGetList("tabKontrakty");

                    if (targetList!=null)
                    {
                        targetList.Items.Cast<SPListItem>()
                            .Where(i => i["colStatusLeadu"].ToString() != "Rozliczenie")
                            .Where(i => i["colStatusLeadu"].ToString() != "Stracony")
                            .ToList()
                            .ForEach(item =>
                                {
                                    if (item["colDataNastepnegoKontaktu"] != null)
                                    {
                                        if (DateTime.Parse(item["colDataNastepnegoKontaktu"].ToString()) < DateTime.Today)
                                        {

                                            //item["Title"] = "TEST";
                                            item.Update();

                                        }
                                    }
                                });
                    }

                }
            });
        }
    }
}
