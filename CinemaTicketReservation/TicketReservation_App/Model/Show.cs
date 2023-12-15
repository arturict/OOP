using System;
using System.Collections.Generic;

namespace CinemaTicketReservation.Model
{
    public class Show
    {   
        public Show(Movie movie, DateTime startTime)
        {
            Movie = movie;
            StartTime = startTime;
        }

        #region fields

        private List<Reservation> reservations = new List<Reservation>();
        private List<Row> rows = new List<Row>();

        #endregion 

        #region properties

        public List<Row> Rows
        {
            get
            {
                return rows;
            }
        }

        public Movie Movie
        {
            get;
            private set;
        }

        public DateTime StartTime
        {
            get;
            private set;
        }

        public DateTime EndTime
        {
            get 
            {
                // Pause = 20 Min.   
                return StartTime.AddMinutes(20 + Movie.DurationInMinutes);
            }
        }

        #endregion 

        #region methods 


        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public List<Reservation> GetReservations()
        {
            return reservations;
        }

        public Seat GetSeat(int rowNumber, int seatNumber)
        {
            foreach (Row row in this.Rows)
            {
                if (row.Number == rowNumber)
                    if (row.GetSeat(seatNumber) != null)
                        return row.GetSeat(seatNumber);
            }

            return null;
        }

        public bool IsSeatReserved(Seat seat)
        {
            foreach (var reservation in reservations) 
            {
                if (reservation.Seat == seat)
                {
                    return true;
                }
            }
            return false;
            // TODO: Methode implementieren! (sorry, ich kam nicht mehr dazu...) 
            // done

        }
        public override string ToString()
        {
            return "«" + Movie.ToString() + "» am " + StartTime.ToString("dd.MM.yyyy HH:mm") + " Uhr";
        }

        #endregion 
    }
}
