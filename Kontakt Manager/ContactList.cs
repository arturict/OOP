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
    public class ContactList
    {

        public BindingList<Contact> Contacts { get; set; }

        public ContactList()
        {
            Contacts = new BindingList<Contact>();
        }

        public void Clear()
        {
            Contacts.Clear();
        }

        public void ExportCsv()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Kontakte exportieren";
            saveFileDialog.Filter = "CSV-Dateien (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                StringBuilder csvContent = new StringBuilder();

                // CSV-Header
                csvContent.AppendLine("Name,Email,Phone");

                foreach (var contact in Contacts)
                {
                    // Zitatzeichen für den Fall, dass Kommata in den Daten sind
                    csvContent.AppendLine($"\"{contact.Name}\",\"{contact.Email}\",\"{contact.Phone}\"");
                }

                File.WriteAllText(path, csvContent.ToString());
            }
        }
        public void ImportCsv()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Kontakte importieren";
            openFileDialog.Filter = "CSV-Dateien (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(path);

                Contacts.Clear();

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data.Length >= 3)
                    {
                        Contact contact = new Contact
                        {
                            Name = data[0].Trim('"'),
                            Email = data[1].Trim('"'),
                            Phone = data[2].Trim('"')
                        };
                        Contacts.Add(contact);
                    }
                }
            }
        }

    }
}
