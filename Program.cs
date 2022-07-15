using System;
using HotelManagementApp.Data;

namespace HotelManagementApp
{
    class Program
    {
        public static void Main()
        {
            using(GuestContext GuestDb = new GuestContext())
            {
                Guest g1 = new Guest("1212","234","43553","fsdf");
                GuestDb.Guest.Add(g1);
                if(GuestDb.SaveChanges()>0)
                    System.Console.WriteLine("Radi");
                else 
                    System.Console.WriteLine("Vec ima!");

                System.Console.WriteLine(string.Join("",GuestDb.Guest));
            }
        }
    }
}
