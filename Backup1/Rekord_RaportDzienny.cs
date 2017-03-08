using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace masterleasing.Reports
{
    public class Rekord_RaportDzienny
    {
        public DateTime Data { get; set; }
        public int NoweWnioski { get; set; }
        public int Koszyk { get; set; }
        public int WnioskiZlozoneDanegoDnia { get; set; }
        public int WnioskiWObrobce { get; set; }
        public int DecyzjePozytywneDanegoDnia { get; set; }
        public int DecyzjePozytywneWObrobce { get; set; }
        public int Uruchomienia { get; set; }
        public int Stracone { get; set; }
        public int OpoznioneNaEtapieTelemarketing { get; set; }
        public int OpoznioneNaEtapieAkceptacjaOferty { get; set; }
        public int UruchomieniaNetto { get; set; }
    }

    public class Rekord_RaportDzienny_Grupa : Rekord_RaportDzienny
    {
        public string Grupa { get; set; }
    }

    public class Rekord_RaportDzienny_Operator : Rekord_RaportDzienny
    {
        public SPFieldUserValue Operator { get; set; }
    }
}
