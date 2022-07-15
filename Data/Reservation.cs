using System;
using System.Text;

namespace HotelManagementApp.Data
{
    class   Reservatio 
    {
        public string Id {get; set;}
        public string Guestid {get; set;}
        public string Roomnumber {get; set;}
        public DateTime Datein {get; set;}
        public DateTime Dateout {get; set;}
        
    }
}