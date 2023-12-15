using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaTicketReservation.Model
{
    public class Customer : Person
    {
        // TODO: Klasse implementieren gemäss Klassendiagramm 
        public string PhoneNumber { get; set; }

        // Konstruktor
        public Customer(string firstName, string lastName, string phoneNumber)
            : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }

    }
}
