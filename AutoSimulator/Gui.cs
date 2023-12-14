using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSimulator
{
    public partial class Gui : Form
    {
        private Auto car;

        public Gui()
        {
            InitializeComponent();
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));
           
        }
       
        private void pictureBoxHupe_Click(object sender, EventArgs e)
        {
          
                SoundPlayer player = new SoundPlayer(Properties.Resources.hupeS);
                player.Play();
           
        }

        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            car = comboBoxAutos.SelectedItem as Auto;
            labelPS.Text = car.PS.ToString() + " PS";
        }


        private void pictureBoxStartCar_Click(object sender, EventArgs e)
        {
            if (car != null)
            {
                if (!car.IstMotorGestartet && car.TankFuellstand > 0)
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.startS);
                    player.Play();
                    car.StartMotor();
                    pictureBoxStartC.BackColor = Color.Green;
                }
                else if (car.TankFuellstand == 0)
                {
                    MessageBox.Show($"Bitte füllen Sie den Tank, bevor Sie den {car.Marke} starten.");
                }
                else if (car.IstMotorGestartet)
                {
                    car.SchalteMotorAus();
                    pictureBoxStartC.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
            }

        }

        private void pictureBoxTanken_MouseDown(object sender, MouseEventArgs e)
        {
            if (car != null)
            {
                if (!car.IstMotorGestartet)
                {
                    timerTanken.Start();
                }
                else
                {
                    MessageBox.Show("Schalten Sie bitte den Motor aus, bevor Sie tanken!");
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
            }
        }

        private void pictureBoxTanken_MouseUp(object sender, MouseEventArgs e)
        {
            timerTanken.Stop();
        }

        private void timerTanken_Tick(object sender, EventArgs e)
        {
            if (car.TankFuellstand < 100)
            {
                car.TankFuellstand += 5;
                progressBarTank.Value = Convert.ToInt32(car.TankFuellstand);
            }
            else
            {
                timerTanken.Stop(); 
            }
            labelTankProzent.Text = car.TankFuellstand.ToString() + "%";
        }

        private void buttonGas_MouseDown(object sender, MouseEventArgs e)
        {
            if (car != null && car.IstMotorGestartet)
            {
                timerGas.Start();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus und starten Sie den Motor.");
            }
        }

        private void buttonGas_MouseUp(object sender, MouseEventArgs e)
        {
            timerGas.Stop();
        }

        private void timerGas_Tick(object sender, EventArgs e)
        {
            if (car.TankFuellstand > 0)
            {
                car.gibGas();
               

            }
            else
            {
                timerGas.Stop();
                MessageBox.Show("Der Tank ist leer. Bitte tanken Sie.");
            }
            labelKmh.Text = car.AktuelleGeschwindigkeit.ToString();
            labelTankProzent.Text = Convert.ToInt32(car.TankFuellstand).ToString() + "%";
            progressBarTank.Value = Convert.ToInt32(car.TankFuellstand);
            labelSchalter.Text = car.AktuellerGang.ToString();
        }


        private void buttonBremsen_MouseDown(object sender, MouseEventArgs e)
        {
            if (car != null)
            {
                timerBremsen.Start(); 
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
            }
            labelSchalter.Text = car.AktuellerGang.ToString();
            labelKmh.Text = car.AktuelleGeschwindigkeit.ToString();

        }
        private void buttonBremsen_MouseUp(object sender, MouseEventArgs e)
        {
            timerBremsen.Stop(); 
        }
        private void timerBremsen_Tick(object sender, EventArgs e)
        {
            double geschwindigkeit;
            if (double.TryParse(labelKmh.Text, out geschwindigkeit))
            {
                car.bremsen();
                labelKmh.Text = car.AktuelleGeschwindigkeit.ToString();
            }
        }
    }
}
