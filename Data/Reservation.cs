using System;
using System.Text;

namespace HotelManagementApp.Data
{
    class Reservation : Table
    {
        public Reservation(string id, string guest_id, string room_number, DateTime date_in, DateTime date_out)
        {
            Id = id;
            Guest_id = guest_id;
            Room_number = room_number;
            Date_in = date_in;
            Date_out = date_out;
        }

        public string Id {get; set;}
        public string Guest_id {get; set;}
        public string Room_number {get; set;}
        public DateTime Date_in {get; set;}
        public DateTime Date_out {get; set;}

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(GetStringWithLengthN(Id, 12));
            builder.Append(GetStringWithLengthN(Guest_id, 12));
            builder.Append(GetStringWithLengthN(Room_number, 5));
            builder.Append(Date_in.ToString() + " ");
            builder.Append(Date_out.ToString());
            return builder.ToString();
        }
    }
}