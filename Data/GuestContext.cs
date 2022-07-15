using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HotelManagementApp.Data
{
    class GuestContext : DbContext
    {
        public DbSet<Guest> Guest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.0.112, 1434;Initial Catalog=stuslu; User ID=novistudent;Password=novistudent");
        }

    }
}