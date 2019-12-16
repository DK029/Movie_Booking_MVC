using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Movie_Booking_MVC.Models;

[assembly: HostingStartup(typeof(Movie_Booking_MVC.Areas.Identity.IdentityHostingStartup))]
namespace Movie_Booking_MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Movie_Booking_IdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Movie_Booking_IdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Movie_Booking_IdentityContext>();
            });
        }
    }
}