using System;

namespace HotelManagementApp.Data
{
    class Room : Table
    {
        public Room(int number, string phone)
        {
            Number = number;
            Phone = phone;
        }

        public int Number {get; set;}
        public string Phone {get; set;}

        public override string ToString()
        {
            return GetStringWithLengthN(Number.ToString(),5) + GetStringWithLengthN(Phone,20);
        }
    }
}