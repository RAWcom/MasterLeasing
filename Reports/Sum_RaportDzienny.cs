using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace masterleasing.Reports
{
    public class Sum_RaportDzienny
    {
        public DateTime Data { get; set; }
        public int LiczbaRekordow { get; set; }
    }

    public class Sum_RaportDzienny_Grupa:Sum_RaportDzienny
    {
        public string Grupa { get; set; }
	}

    public class Sum_RaportDzienny_Operator : Sum_RaportDzienny
    {
        public SPFieldUserValue Operator { get; set; }
    }
}
