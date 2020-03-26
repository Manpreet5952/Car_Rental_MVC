using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Car_Rental_MVC.Models;

namespace Car_Rental_MVC.Data
{
    public class Car_Rental_DBContext : DbContext
    {
        public Car_Rental_DBContext (DbContextOptions<Car_Rental_DBContext> options)
            : base(options)
        {
        }

        public DbSet<Car_Rental_MVC.Models.Booking> Booking { get; set; }

        public DbSet<Car_Rental_MVC.Models.Car> Car { get; set; }

        public DbSet<Car_Rental_MVC.Models.Driver> Driver { get; set; }

        public DbSet<Car_Rental_MVC.Models.User> User { get; set; }
    }
}
