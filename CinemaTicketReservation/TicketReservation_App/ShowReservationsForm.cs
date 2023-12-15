using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using CinemaTicketReservation.Model;

namespace CinemaTicketReservation
{
    public partial class ShowReservationsForm : Form
    {
        PrintDocument printDoc = new PrintDocument();
        Bitmap screenshot;
        private Show SelectedShow;
        public ShowReservationsForm(Show Show)
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(_printDoc_PrintPage);
            this.SelectedShow = Show;
        }

        private void ShowReservationsForm_Load(object sender, EventArgs e)
        {
            if (SelectedShow != null)
            {
                textBoxShow.Text = SelectedShow.ToString();

                // Anzeigen der Reservierungen
                StringBuilder reservationsText = new StringBuilder();
                foreach (var reservation in SelectedShow.GetReservations())
                {
                    reservationsText.AppendLine($"Code: {reservation.reservationCode}, Kunde: {reservation.Customer.FirstName}  {reservation.Customer.LastName}, Sitz: Reihe {reservation.Seat.Row.Number}, Sitznummer {reservation.Seat.Number}");
                }

                textBoxShowReservations.Text = reservationsText.ToString();
            }
            else
            {
                textBoxShow.Text = "Keine Aufführung ausgewählt.";
                textBoxShowReservations.Text = "Keine Reservationen verfügbar.";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Screenshot der Textbox machen
                screenshot = new Bitmap(textBoxShowReservations.Width, textBoxShowReservations.Height);

                Rectangle r = new Rectangle(textBoxShowReservations.Left, textBoxShowReservations.Top
                    , textBoxShowReservations.Width, textBoxShowReservations.Height);

                textBoxShowReservations.DrawToBitmap(screenshot, r);

                printDialog1.AllowSomePages = true;
                printDialog1.Document = printDoc;

                // Druck-Dialog öffnen 
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Screenshot drucken 
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Drucken", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void _printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(screenshot, 0, 0);
        }
    }
}
