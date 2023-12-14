using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    public class Tannenbaum
    {
        public double BreiteStamm { get; set; }
        public double HoeheStamm { get; set; }
        public double HoehenKrone { get; set; }
        public Tannenbaum(int Breite, int Hoehe, int HoeheK)
        {
            BreiteStamm = Breite;
            HoeheStamm = Hoehe;
            HoehenKrone = HoeheK;
        }

        public string Zeichne()
        {
            StringBuilder baumZeichnung = new StringBuilder();

            for (int i = 1; i <= HoehenKrone; i++)
            {
                for (int j = 1; j <= HoehenKrone - i; j++)
                {
                    baumZeichnung.Append(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    baumZeichnung.Append("*");
                }
                baumZeichnung.AppendLine();
            }

            for (int i = 0; i < HoeheStamm; i++)
            {
                for (int j = 0; j < HoehenKrone - 1 - BreiteStamm / 2; j++)
                {
                    baumZeichnung.Append(" ");
                }
                for (int k = 0; k < BreiteStamm; k++)
                {
                    baumZeichnung.Append("*");
                }
                baumZeichnung.AppendLine();
            }

            return baumZeichnung.ToString();
        }

    }

}
