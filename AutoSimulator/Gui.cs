﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Gui()
        {
            InitializeComponent();
        }

        private void pictureBoxHupe_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("");
            player.Play();
        }
    }
}
