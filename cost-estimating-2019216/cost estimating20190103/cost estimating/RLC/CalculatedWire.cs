using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cost_estimating.RLC
{
    class CalculatedWire
    {
        public static string CalculatedWireSize(double dCurrent)
        {
            string wire = "1.5";
            double dvalue = dCurrent / 5;
            if (dvalue <= 10)
            {
                if (dvalue <= 1)
                    wire = "1";
                else if (dvalue <= 1.5)
                    wire = "1.5";
                else if (dvalue <= 2.5)
                    wire = "2.5";
                else if (dvalue <= 4)
                    wire = "4";
                else if (dvalue <= 6)
                    wire = "6";
                else
                    wire = "10";
            }
            else if ((dCurrent / 4) <= 25)
            {
                dvalue=dCurrent / 4;
                if (dvalue <= 16)
                {
                    wire = "16";
                }
                else
                {
                    wire = "25";
                }
            }
            else if ((dCurrent / 3) <= 50)
            {
                dvalue = dCurrent / 3;
                if (dvalue <= 35)
                {
                    wire = "35";
                }
                else
                {
                    wire = "50";
                }
            }
            else if ((dCurrent / 2.5) <= 95)
            {
                dvalue = dCurrent / 2.5;
                if (dvalue <= 70)
                {
                    wire = "70";
                }
                else
                {
                    wire = "95";
                }
            }
            else
            {
                dvalue = dCurrent / 2;
                if (dvalue <= 120)
                {
                    wire = "120";
                }
                else if (dvalue <= 150)
                {
                    wire = "150";
                }
                else if (dvalue <= 180)
                {
                    wire = "180";
                }
                else
                {
                    wire = "大于180";
                }
            }
            return wire;
        }
    }
}
