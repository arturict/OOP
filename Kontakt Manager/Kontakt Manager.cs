using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;


namespace Kontakt_Manager
{
    public partial class Form1 : Form
    {
        ContactList contactList = new ContactList();
        public Form1()
        {
            InitializeComponent();
            dataGridView.DataSource = contactList.Contacts;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
                // neue Contact-Instanz
                Contact contact = new Contact();
                contact.Name = textBoxName.Text;
                contact.Email = textBoxEmail.Text;
                contact.Phone = textBoxPhone.Text;
            // neuen Kontakt zur Kontaktliste hinzufügen
                contactList.Contacts.Add(contact);

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            contactList.ImportCsv();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            contactList.ExportCsv();
        }

        private void buttonDeleteList_Click(object sender, EventArgs e)
        {
            contactList.Clear();
        }
    }
}
