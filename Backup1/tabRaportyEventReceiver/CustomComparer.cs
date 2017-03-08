using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Reports.tabRaportyEventReceiver;

namespace masterleasing.Reports.tabRaportyEventReceiver
{
    public class CustomComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            int a = (x as GroupTotalsItem).LiczbaNowychSpraw;
            string left = (x as GroupTotalsItem).Grupa + string.Format("{0:0000000}", a).ToString();

            int b = (y as GroupTotalsItem).LiczbaNowychSpraw;
            string right = (y as GroupTotalsItem).Grupa + string.Format("{0:0000000}", b).ToString();
            int max = Math.Min(left.Length, right.Length);
            for (int i = 0; i < max; i++)
            {
                if (left[i] != right[i])
                {
                    return right[i] - left[i];
                }
            }
            return right.Length - left.Length ;

        }
    }
}
