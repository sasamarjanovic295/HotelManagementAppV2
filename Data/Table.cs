using System;

namespace HotelManagementApp.Data
{
    abstract public class Table
    {
        protected string GetStringWithLengthN(string message, int N)
        {
            for(int i = 0; i < N - message.Length; i++)
                message+=' ';
            return message;
        }

        public abstract override string ToString();
    }
}