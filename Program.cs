using System;
using HotelManagementApp.Data;
using HotelManagementApp.Context;

namespace HotelManagementApp
{
    class Program
    {
        public static void Main()
        {
            using(GuestContext GuestDb = new GuestContext())
            {
                Guest g1 = new Guest("783","2sfdsf","453","fsdf");
                GuestDb.Guest.Add(g1);
                if(GuestDb.SaveChanges()>0)
                    System.Console.WriteLine("Radi");
                else 
                    System.Console.WriteLine("Vec ima!");

                System.Console.WriteLine(string.Join("\n",GuestDb.Guest));
            }
        }
    }
}
