using System;
using System.Text;

namespace HotelManagementApp.Data
{
    class Reservation 
    {
        public Reservation(string id, string guestid, string roomnumber, DateTime datein, DateTime dateout)
        {
            Id = id;
            Guestid = guestid;
            Roomnumber = roomnumber;
            Datein = datein;
            Dateout = dateout;
        }

        public string Id {get; set;}
        public string Guestid {get; set;}
        public string Roomnumber {get; set;}
        public DateTime Datein {get; set;}
        public DateTime Dateout {get; set;}
    }
}