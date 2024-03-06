using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOOP
{
    internal class Hotel
    {
        private Dictionary<string, Customer> customers = new Dictionary<string, Customer>();
        private Dictionary<int, Room> rooms = new Dictionary<int, Room>();
        private int nextRoomNumber = 0;
        private int next2RoomNumber = 0;
        private int next3RoomNumber = 0;

        public Hotel()
        {
            //Set up 40 rooms
            for (int i = 1; i <= 40; i++)
            {

                rooms.Add(i, new Room(i));
                
            }
        }

        public void RegisterCustomer(string customerName)
        {
            //Create customer
            Customer tempCustomer = new Customer(customerName);
            customers[customerName] = tempCustomer;
        }

        //public void RegisterRoom()
        //{
            //Create room
            //Room tempRoom = new Room(nextRoomNumber++);
            //rooms[nextRoomNumber] = tempRoom;
        //}

        public Customer GetCustomer(string customerName)
        {
            return customers[customerName];
        }

        public Room GetRoom()
        {
            nextRoomNumber++;
            return rooms[nextRoomNumber];
        }

        public Room GetRoomBook()
        {
            next2RoomNumber++;
            return rooms[next2RoomNumber];
        }

        public Room GetRoomVacate()
        {
            next3RoomNumber++;
            return rooms[next3RoomNumber];
        }


        //Methods
        public int resetRoomNumber()
        {
            if (nextRoomNumber >= rooms.Count)
            {
                nextRoomNumber = 0;
            }
            return nextRoomNumber;
        }

        public int reset2RoomNumber()
        {
            if (next2RoomNumber >= rooms.Count)
            {
                next2RoomNumber = 0;
            }
            return next2RoomNumber;
        }

        public int reset3RoomNumber()
        {
            if (next3RoomNumber >= rooms.Count)
            {
                next3RoomNumber = 0;
            }
            return next3RoomNumber;
        }

        public void BookRoom()
        {

        }

        public void VacateRoom()
        {

        }

        public List<int> ReportOnRooms()
        {
            //List for room numbers
            List<int> occupiedRooms = new List<int>();
            for (int b = 1; b <= 40; b++)
            {
                //Checking which rooms are occupied
                if (rooms[b].IsOccupied() == true)
                {
                    //If the room is occupied add the room number to the list
                    occupiedRooms.Add(b);
                }
                
            }
            return occupiedRooms;
        }

        public int CountCustomers()
        {
            int count = 0;
            for (int c = 1; c <= 40; c++)
            {
                bool occupiedRooms = rooms[c].IsOccupied();
                //Checking which rooms are occupied
                if (occupiedRooms == true)
                {
                    //If the room is occupied one is added to count
                    count += 1;
                }
            }
            return count;
        }

        public int ShowIncome()
        {
            int num = 0;
            for (int d = 1; d <= 40;  d++)
            {
                //Checking which rooms are occupied
                if (rooms[d].IsOccupied() == true)
                {
                    //If the room is occupied one is added to num
                    num += 1;
                }
            }
            return num;
        }
    }
}
