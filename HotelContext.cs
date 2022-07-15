using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HotelManagementApp.Data;

namespace HotelManagementApp.Context
{
    class HotelContext : DbContext
    {
        public DbSet<Guest> Guest { get; set; }
        public DbSet<Employee> Employee { get; set;}
        public DbSet<Room> Room { get; set; }
        public DbSet<Reservation> Reservation {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.0.112, 1434;Initial Catalog=hotel; User ID=novistudent;Password=novistudent");
        }

    }
}