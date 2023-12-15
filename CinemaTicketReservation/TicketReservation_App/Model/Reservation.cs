using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public class Reservation
    {
        // TODO: Klasse implementieren gemäss Klassendiagramm  
        public Customer Customer { get; set; }
        public string reservationCode {  get; set; }
        public Seat Seat { get; set; }
    }
}
