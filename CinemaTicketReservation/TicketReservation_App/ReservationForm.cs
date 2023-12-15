using CinemaTicketReservation.Model;
using CinemaTicketReservation.Model.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CinemaTicketReservation
{
    public partial class ReservationForm : Form
    {
        #region fields 

        private User user;
        private Seat selectedSeat;

        #endregion

        #region constructor

        public ReservationForm(User registeredUser)
        {
            user = registeredUser;
            InitializeComponent();
        }

        #endregion 

        #region event handler 

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            if (user.IsLoggedIn)
            {
                textBoxFirstLastName.Text = user.FirstName + " " + user.LastName;
               
                List<Show> shows = (new Database()).GetShows();
                comboBoxShows.DataSource = shows;
            }
            else
            {
                MessageBox.Show("Kein Zugang. Benutzer nicht authentifiziert.", "Fehler"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private void comboBoxShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show selectedShow = comboBoxShows.SelectedItem as Show;
            CreateSeatPlan(selectedShow);
        }
       
        void buttonSeat_Click(object sender, EventArgs e)
        {
            Show show = (Show)comboBoxShows.SelectedItem;
            selectedSeat = (Seat)((Button)sender).Tag;

            if (show.IsSeatReserved(selectedSeat))
            {
                SetEnablements(false);

                MessageBox.Show("Dieser Sitz ist bereits reserviert!", "Keine Reservation möglich"
                   , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                selectedSeat = null;
                return;
            }

            SetEnablements(true);

            textBoxShow.Text = show.ToString();
            textBoxRow.Text = selectedSeat.Row.Number.ToString();
            textBoxSeat.Text = selectedSeat.Number.ToString();

            textBoxCustomerFirstName.Select();
        }

        private void buttonMakeReservation_Click(object sender, EventArgs e)
        {
            Show show = (Show)comboBoxShows.SelectedItem;

            string phoneNumber = textBoxCustomerPhoneNr.Text;
            string vorname = textBoxCustomerFirstName.Text;
            string nachname = textBoxCustomerLastName.Text;
            Customer customer = new Customer(vorname, nachname, phoneNumber);

            Seat seat = selectedSeat;

            if (show.IsSeatReserved(seat))
            {
                MessageBox.Show("Dieser Sitzplatz ist bereits reserviert", "Reservierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string reservationCode = Guid.NewGuid().ToString("N").Substring(0, 8);

            Reservation reservation = new Reservation
            {
                Customer = customer,
                Seat = seat,
                reservationCode = reservationCode
            };

            show.AddReservation(reservation);

            // Anzeigen des Reservierungscodes
            MessageBox.Show("Die Reservierung wurde registriert. " + Environment.NewLine +
                    "Der Reservationscode lautet: " + reservationCode, "Reservierung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxCustomerFirstName.Text = string.Empty;
            textBoxCustomerLastName.Text = string.Empty;
            textBoxCustomerPhoneNr.Text = string.Empty;

            CreateSeatPlan(show);
        }

        
        private void buttonShowReservations_Click(object sender, EventArgs e)
        {
            // TODO: alle bestehenden Reservationen für die ausgewählte Vorführung im "ShowReservationsForm" anzeigen
            Show show = (Show)comboBoxShows.SelectedItem;
            ShowReservationsForm f = new ShowReservationsForm(show);
            f.ShowDialog();
        }

        private void ReservationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region methods 

        private void CreateSeatPlan(Show show)
        {
            const int ButtonHeight = 25;
            const int ButtonWidth = 58;

            panelSeatsPlan.Controls.Clear();
            SetEnablements(false);

            if (show != null)
            {
                int y = 0; 
                foreach (Row row in show.Rows)
                {
                    Label l = new Label();
                    l.Text = "Reihe " + row.Number.ToString();
                    l.Width = ButtonWidth;
                    l.Location = new Point(0, y * ButtonHeight + 5);
                    panelSeatsPlan.Controls.Add(l);

                    int x = 1; 
                    foreach (Seat seat in row.GetSeats())
                    {
                        Button b = new Button();
                        b.Text = "Sitz " + seat.Number.ToString();

                        if (show.IsSeatReserved(seat))
                        {
                            b.BackColor = Color.Red; 
                        }
                        else
                        {
                            b.BackColor = Color.LightGreen; 
                        }

                        b.Height = ButtonHeight;
                        b.Width = ButtonWidth;
                        b.Location = new Point(x * ButtonWidth, y * ButtonHeight); 
                        panelSeatsPlan.Controls.Add(b);

           
                        b.Click += new EventHandler(buttonSeat_Click);

                        
                        b.Tag = seat;

                        x++; 
                    }
                    y++; 
                }
            }
        }



        private void SetEnablements(bool isEnabled)
        {
            textBoxCustomerFirstName.Enabled
                = textBoxCustomerLastName.Enabled
                = textBoxCustomerPhoneNr.Enabled
                = buttonMakeReservation.Enabled = isEnabled;

            if (!isEnabled)
            {
                textBoxShow.Clear();
                textBoxSeat.Clear();
                textBoxRow.Clear();
            }
        }

        #endregion 
    }
}
