using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Booking_MVC.Models
{
    //Movie Show times
    public class ShowTime
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime ShowDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime {get; set;}

        public int Duration { get; set;  }

        public string ShowTimeDisplay {

            get {

                return ShowDate.ToShortDateString() + "-" + StartTime.ToShortTimeString();
            }
        
        }


    }
}
