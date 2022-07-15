using System;
using HotelManagementApp.Data;
using HotelManagementApp.Context;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementApp
{
    class Program
    {
        public static void Main()
        {
            using(HotelContext db = new HotelContext()){
                Guest g1 = new Guest("1936", "1935", "1935", "1935");
                Room r1 = new Room("1936","1935");
                Employee e1 = new Employee("1936","1935","1935","1935","1936","1936");
                Reservation re1 = new Reservation("1936",g1.Id,r1.Number,DateTime.Now,DateTime.Now);

                db.Guest.Add(g1);
                db.Room.Add(r1);
                db.Employee.Add(e1);

                if(db.SaveChanges()>0)
                    System.Console.WriteLine("Upisano 1");

                db.Reservation.Add(re1);

                if(db.SaveChanges()>0)
                    System.Console.WriteLine("Upisano 2");

                System.Console.WriteLine("Guests:\n" 
                + string.Join("\n",db.Guest)); 
                System.Console.WriteLine("Rooms:\n" 
                + string.Join("\n",db.Room)); 
                System.Console.WriteLine("Employees:\n" 
                + string.Join("\n",db.Employee));
                System.Console.WriteLine("Reservations:\n" 
                + string.Join("\n",db.Reservation)); 
            }
        }
    }
}
