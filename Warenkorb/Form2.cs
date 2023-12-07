using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warenkorb
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void AddItemToListView(string item, int menge)
        {
            ListViewItem listViewItem = new ListViewItem(item);
            listViewItem.SubItems.Add(menge.ToString());
            listViewWarenkorb.Items.Add(listViewItem);
        }


    }
}
