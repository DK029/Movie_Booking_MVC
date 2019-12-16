using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Booking_MVC.Models
{
    //A movie with a name and a ticket price
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal TicketPrice { get; set; }



    }
}
