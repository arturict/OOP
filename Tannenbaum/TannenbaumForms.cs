using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum
{
    public partial class TannenbaumForms : Form
    {
        public TannenbaumForms()
        {
            InitializeComponent();
        }

        private void buttonBaumErstellen_Click(object sender, EventArgs e)
        {
            int breite = Convert.ToInt32(textBoxStamm.Text);
            int hoehe = Convert.ToInt32(textBoxStammhoehe.Text);
            int KroneHoehe = Convert.ToInt32(textBoxKrone.Text);
            Tannenbaum T = new Tannenbaum(breite,hoehe,KroneHoehe);
            textBoxAusgabe.Text = T.Zeichne().ToString();
        }
    }
}
