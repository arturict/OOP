﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Warenkorb
{
    public partial class Form1 : Form
    {
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
        List<OrderItem> orderedItems = new List<OrderItem>();



        private void UpdateTotalQuantity()
        {
            int totalQuantity = 0;
            foreach (OrderItem item in orderedItems)
            {
                totalQuantity += item.Quantity; 
            }

            labelAnzeigeAnz.Text = "(" + totalQuantity.ToString() +")";
        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            int menge = Convert.ToInt32(formAnzahl.Value);

            if (comboBoxAuswahl.SelectedIndex > -1)
            {
                Product selectedProduct = comboBoxAuswahl.SelectedItem as Product;
                OrderItem item = new OrderItem(selectedProduct, menge);
                orderedItems.Add(item);
                UpdateTotalQuantity(); 
            }
        }

        private void linkLabelAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 war = new Form2();
            war.AddItemsToListView(orderedItems);  
            war.ShowDialog();
        }

    }
}

