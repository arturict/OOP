
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warenkorb
{
    public partial class Form1 : Form
    {
        private CartForm form2 = new CartForm();

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=mssql1.webland.ch;Database=d041e_blj;User Id=d041e_blj;Password=BljDbPw_01;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Abfrage vorbereiten
                SqlCommand command = new SqlCommand("select * from products", connection);

                // Abfrage ausführen 
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product p = new Product
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["product_name"].ToString(),
                            Price = Convert.ToDouble(reader["price"])
                        };

                        comboBoxAuswahl.Items.Add(p);
                    }
                }
            }
        }

        private void linkLabelAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form2.ShowDialog();
        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            if (comboBoxAuswahl.SelectedIndex > -1)
            {
                Product selectedProduct = (Product)comboBoxAuswahl.SelectedItem;
                if (int.TryParse(formAnzahl.Text, out int menge))
                {
                    form2.AddItemToListView(selectedProduct, menge);
                    MessageBox.Show("Erfolgreich hinzugefügt", "Success");
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine gültige Anzahl ein", "Eingabefehler");
                }
            }
        }
    }
}
