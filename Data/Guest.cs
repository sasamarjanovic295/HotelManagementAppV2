using System;
using System.Text;

namespace HotelManagementApp.Data
{
    class Guest : Table
    {
        public Guest(string id, string first_name, string last_name, string phone)
        {
            Id = id;
            First_name = first_name;
            Last_name = last_name;
            Phone = phone;
        }

        public string Id {get; set;}
        public string First_name {get; set;}
        public string Last_name {get; set;}
        public string Phone {get; set;}

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(GetStringWithLengthN(Id,20));
            builder.Append(GetStringWithLengthN(First_name,20));
            builder.Append(GetStringWithLengthN(Last_name,20));
            builder.Append(GetStringWithLengthN(Phone,20));
            builder.Append("\n");
            return builder.ToString();
        }
    }
}