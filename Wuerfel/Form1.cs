using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Wuerfel wuerfel = new Wuerfel();

        private void buttonWuerfeln_Click(object sender, EventArgs e)
        {
            LabelAktuellerWurf.Text = wuerfel.Werfen().ToString();
            LabelLetzterWurf.Text = wuerfel.LetzterWurf.ToString();
        }
    }
}
