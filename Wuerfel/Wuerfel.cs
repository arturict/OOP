﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfel
{
    public class Wuerfel
    {
        Random r = new Random();
        int aktuellerWurf;
        int letzterWurf;

        public int LetzterWurf
        {
            get { return letzterWurf; }
        }

        public int Werfen()
        {
            letzterWurf = aktuellerWurf;
            aktuellerWurf = r.Next(1, 7);
            return aktuellerWurf;
        }
    }
}
