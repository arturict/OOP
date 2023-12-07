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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void linkLabelAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private bool isComboBoxLoaded = false;

      
        private void Form1_Load(object sender, EventArgs e)
        {
            // Verbindung zur Datenbank herstellen
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

                        comboBoxAuswahl.Items.Add(p.Name);
                    }
                }
            }
        }

       
        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            if (comboBoxAuswahl.SelectedIndex > -1)
            {
                string selectedItem = comboBoxAuswahl.SelectedItem.ToString();
                int menge = Convert.ToInt32(formAnzahl.Text);

                Form2 form2 = new Form2();
                form2.AddItemToListView(selectedItem, menge);
               
            }
        }



    }
}
