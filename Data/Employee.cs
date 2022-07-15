using System;
using System.Text;

namespace HotelManagementApp.Data
{
    class Employee : Table
    {
        public Employee(string id, string firstName, string lastName, string phone, string username, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Username = username;
            Password = password;
        }

        public string Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Phone {get; set;}  
        public string Username {get; set;}  
        public string Password {get; set;}

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(GetStringWithLengthN(Id,12));
            builder.Append(GetStringWithLengthN(FirstName,20));
            builder.Append(GetStringWithLengthN(LastName,20));
            builder.Append(GetStringWithLengthN(Phone,20));
            return builder.ToString();
        }
    }
}
