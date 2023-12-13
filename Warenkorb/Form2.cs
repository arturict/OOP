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
        List<OrderItem> orderedItems = new List<OrderItem>();

        public Form2()
        {
            InitializeComponent();
            listViewWarenkorb.Columns.Add("Produktname", -2, HorizontalAlignment.Left);
            listViewWarenkorb.Columns.Add("Preis", -2, HorizontalAlignment.Left);
            listViewWarenkorb.Columns.Add("Menge", -2, HorizontalAlignment.Left);
            listViewWarenkorb.Columns.Add("Gesamtbetrag", -2, HorizontalAlignment.Left);

            listViewWarenkorb.View = View.Details;

        }
        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void AddItemsToListView(List<OrderItem> orderedItems)
        {
            double totalSum = 0;

            foreach (OrderItem item in orderedItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.Product.Name);
                listViewItem.SubItems.Add(item.Product.Price.ToString() + " fr.");
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add(item.GetAmount().ToString() + " fr.");

                listViewWarenkorb.Items.Add(listViewItem);

                totalSum += item.GetAmount();
            }

            labelSumme.Text = totalSum.ToString() + " fr.";
        }
    }
}

