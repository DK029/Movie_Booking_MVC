using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie_Booking_MVC.Models;

namespace Movie_Booking_MVC.Models
{
    public class Movie_Booking_DataContext : DbContext
    {
        public Movie_Booking_DataContext (DbContextOptions<Movie_Booking_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Movie_Booking_MVC.Models.Booking> Booking { get; set; }

        public DbSet<Movie_Booking_MVC.Models.Movie> Movie { get; set; }

        public DbSet<Movie_Booking_MVC.Models.ShowTime> ShowTime { get; set; }
    }
}
