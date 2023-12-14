using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AutoSimulator
{
    public class Auto
    {
        public string Marke { get; set; }
        public int PS { get; set; }
        public int AktuelleGeschwindigkeit { get; set; }
        public int AktuellerGang { get; set; }
        public bool IstMotorGestartet { get;  set; }
        public double TankFuellstand { get; set; }

        public Auto(string marke, int ps)
        {
            this.Marke = marke;
            this.PS = ps;
            AktuelleGeschwindigkeit = 0;
            AktuellerGang = 0;
            IstMotorGestartet = false;
            TankFuellstand = 0; 
        }
       
        public void StartMotor()
        {
            if (TankFuellstand > 0)
            {
                IstMotorGestartet = true;
            }
            else
            {
                throw new InvalidOperationException("Der Tank ist leer. Motor kann nicht gestartet werden.");
            }
        }
        public void SchalteMotorAus()
        {
            IstMotorGestartet = false;
        }



        public override string ToString()
        {
            return this.Marke.ToString();
        }

        public void gibGas()
        {
            
            if (IstMotorGestartet && TankFuellstand > 0)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.fahren);
                player.Play();
                double grundbeschleunigung = PS * 0.03;
                double beschleunigungsFaktor = 1 - (AktuelleGeschwindigkeit / 200.0);

                int neueGeschwindigkeit = (int)Math.Round(AktuelleGeschwindigkeit + grundbeschleunigung * beschleunigungsFaktor);

                AktuelleGeschwindigkeit = Math.Min(neueGeschwindigkeit, PS);

                TankFuellstand -= (PS * 0.005 + AktuelleGeschwindigkeit * 0.0005);
                if (TankFuellstand < 0) TankFuellstand = 0;
            }

            if (TankFuellstand == 0)
            {
                IstMotorGestartet = false;
                AktuelleGeschwindigkeit = 0;
            }
            updateGear();
            
        }




        public void bremsen()
        {
            if (AktuelleGeschwindigkeit > 0)
            {
                AktuelleGeschwindigkeit = AktuelleGeschwindigkeit - 10;
            }
            else AktuelleGeschwindigkeit = 0;
            updateGear();
        }
        public void updateGear()
        {
            switch (AktuelleGeschwindigkeit)
            {
                case int n when (n >= 0 && n < 11):
                    AktuellerGang = 1;
                    break;
                case int n when (n < 21):
                    AktuellerGang = 2;
                    break;
                case int n when (n < 41):
                    AktuellerGang = 3;
                    break;
                case int n when (n < 71):
                    AktuellerGang = 4;
                    break;
                case int n when (n < 101):
                    AktuellerGang = 5;
                    break;
                case int n when (n >= 101):
                    AktuellerGang = 6;
                    break;
                default:
                     break;
            }
        }





    }
}
