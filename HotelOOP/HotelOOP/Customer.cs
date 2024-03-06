using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOOP
{
    internal class Customer
    {
        //Attributes
        private string name;
        private int roomNumber;

        //Constructor
        public Customer() 
        { 
            name = string.Empty;
            roomNumber = 0;
        }

        public Customer(string customerName)
        {
            name = customerName;
        }

        //Methods
        public string GetName()
        { 
            return name; 
        }
        public void GetRoomNumber(int newRoomNumber)
        {
            roomNumber = newRoomNumber;
        }
        public int ReturnRoomNumber()
        {
            return roomNumber;
        }
    }
}
