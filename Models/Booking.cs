using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Booking_MVC.Models
{
    //Showtime booking for a movie
    public class Booking
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int ShowTimeId { get; set; }

        public ShowTime ShowTime { get; set; }

        public Movie Movie { get; set; }

        [NotMapped]
        public string BookingReference {

            get {
                return "MV0000" + Id;
            }
        }

    }
}
