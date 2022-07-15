using System;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementApp.Data
{
    class Room : Table
    {
        public Room(string number, string phone)
        {
            Number= number;
            Phone = phone;
        }
        [Key]
        public string Number{get; set;}
        public string Phone {get; set;}

        public override string ToString()
        {
            return GetStringWithLengthN(Number.ToString(),5) + GetStringWithLengthN(Phone,20);
        }
    }
}