using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReiseMondDauer
{
    public partial class Mond : Form
    {
        public Mond()
        {
            InitializeComponent();
        }

        private void buttonDauerBerechnen_Click(object sender, EventArgs e)
        {
            string v = textBoxGeschwindigkeit.Text;
            double geschwindigkeit = Convert.ToDouble(v);
            Mondreise mondreise = new Mondreise(geschwindigkeit);
            if (radioButtonDays.Checked == true)
            {
              textBoxAusgabe.Text =  mondreise.GetTravelDurationDays().ToString();
            }
            else if (radioButtonHours.Checked == true)
            {
                textBoxAusgabe.Text = mondreise.GetTravelDurationHours().ToString();

            }

        }
    }
}
