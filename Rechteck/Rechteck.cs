using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    public class Rechteck
    {
        public Rechteck() { }

        double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        double width;
        public double Width
        {
            get { return width; }
            set { height=value; }      
        }
      
        public double GetArea(double hoehe, double breite)
        {
          return hoehe * breite;
        }
    }
}
