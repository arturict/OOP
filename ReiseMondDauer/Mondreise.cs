using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReiseMondDauer
{
    public class Mondreise
    {
        private double geschwindigkeit;

        public Mondreise(double speed)
        {
            geschwindigkeit = speed;
        }

        public double GetTravelDurationHours()
        {
            double distanz = 385000; 
            return distanz / geschwindigkeit; 
        }

        public double GetTravelDurationDays()
        {
            double stunden = GetTravelDurationHours();
            return stunden / 24; 
        }
    }
}
