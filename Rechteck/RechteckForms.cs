using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechteck
{
    public partial class RechteckForms : Form
    {

        public RechteckForms()
        {
            InitializeComponent();

        }
        Rechteck rechteck = new Rechteck();
        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            string eingabeBreite = textBoxBreite.Text;
            double breite = Convert.ToDouble(eingabeBreite);
            string eingabeHoehe = textBoxHoehe.Text;
            double hoehe = Convert.ToDouble(eingabeHoehe);
            textBoxAusgabe.Text = rechteck.GetArea(hoehe,breite).ToString();

        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
