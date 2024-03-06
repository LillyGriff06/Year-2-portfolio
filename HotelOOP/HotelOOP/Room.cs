using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOOP
{
    internal class Room
    {
        //Attributes
        private int roomNumber;
        private bool occupied;
        private string customerName;
        private Customer customer;

        //Constructor
        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
            occupied = false;
        }

        //Methods
        public Customer GetCustomerName()
        {
            return customer;
        }

        public int GetRoomNumber()
        {
            return roomNumber;
        }

        public bool IsOccupied()
        {
            return occupied;
        }

        public void OccupyRoom()
        {
            occupied = true;
        }

        public void Vacate()
        {
            occupied = false;
        }
    }
}
