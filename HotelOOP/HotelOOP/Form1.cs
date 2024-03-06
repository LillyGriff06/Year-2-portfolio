using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Hotel hotel1 = new Hotel();
        private Restaurant restaurant = new Restaurant();
        private Spa spa = new Spa();
        private string customerName;
        private Customer customer;


        private void button1_Click(object sender, EventArgs e)
        {
            //Registering the customer
            customerName = txtCustomerName.Text;
            hotel1.RegisterCustomer(customerName);
            customer = hotel1.GetCustomer(customerName);
            groupBox2.Visible = true;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            //Looping through all of the rooms
            for (int x = 1; x <= 40; x++)
            {
                //Get room
                Room room = hotel1.GetRoomBook();
                hotel1.reset2RoomNumber();
                //Check if room is occupied
                bool roomVacancy = room.IsOccupied();
                if (roomVacancy == false)
                {
                    //Book vacant room
                    int roomNumber = room.GetRoomNumber();
                    customer.GetRoomNumber(roomNumber);
                    room.GetCustomerName();
                    room.OccupyRoom();
                    string roomNum = roomNumber.ToString();
                    //Message to display which room the customer has booked
                    MessageBox.Show("Your room is room " + roomNum);
                    break;
                }

            }
        }


        private void btnVacateRoom_Click(object sender, EventArgs e)
        {
            //Looping through all of the rooms
            for (int a = 1; a <= 40; a++)
            {
                Room room = hotel1.GetRoomVacate();
                hotel1.reset3RoomNumber();
                int roomNumber = customer.ReturnRoomNumber();
                //Checking if the room number and the customer's room number are the same
                if (roomNumber == room.GetRoomNumber())
                {
                    //If they are the same vacate the room
                    room.Vacate();
                    MessageBox.Show("You have successfully vacated your room");
                    break;
                }
            }
        }

        private void btnShowReports_Click(object sender, EventArgs e)
        {
            //Making the groupbox visible so that the reports can be seen
            groupBox3.Visible = true;
            //Calling methods for the reports
            ReportOnRooms();
            CountCustomers();
            ShowIncome();

        }
        private void ReportOnRooms()
        {
            List<int> occupiedRooms = hotel1.ReportOnRooms();
            //Turning the list to a string with a message to explain what the data means
            string reportOnRooms = "The numbers of the rooms that are currently booked are: ";
            //Displaying the data in the textbox
            txtReportOnRooms.Text = reportOnRooms;
            for (int e = 0; e <= occupiedRooms.Count - 1; e++) 
            {
                int tempVar = occupiedRooms[e];
                txtReportOnRooms.Text += tempVar.ToString() + "  ";
            }
            //List for customer names
            List<string> customerName = new List<string>();
            for (int z = 1; z <= 40;  z++)
            {
                Room room = hotel1.GetRoom();
                hotel1.resetRoomNumber();
                //Checking which rooms are occupied
                if (room.IsOccupied() == true)
                {
                    int roomNumber = room.GetRoomNumber();
                    //Checking if the room number is equal to the customer's room number
                    if (roomNumber == customer.ReturnRoomNumber())
                    {
                        string name = customer.GetName();
                        //If the room number and the customer's room number are equal add the customer name to the list
                        customerName.Add(name);
                    }
                }
            }
            //Turning the list to a string with a message to explain what the data means
            string reportOnRooms2 = "\nThe customers that are currently booked into the hotel are ";
            //Displaying the data in the textbox
            txtReportOnRooms.Text += reportOnRooms2;
            for (int f = 0; f <= customerName.Count - 1; f++)
            {
                string tempVar = customerName[f];
                txtReportOnRooms.Text += tempVar + "  ";
            }
        }

        private void CountCustomers()
        {
            int count = hotel1.CountCustomers();
            //Adding a message to explain the data
            string countCustomers = "The number of residents currently booked into the hotel is " + count.ToString();
            //Displaying the data in the textbox
            txtCountCustomers.Text = countCustomers;
        }

        private void ShowIncome()
        {
            int num = hotel1.ShowIncome();
            //Calculating the income
            int income = num * 120;
            //Adding a message to explain the data
            string showIncome = "The hotel's income for the day is £" + income.ToString();
            //Displaying the data in the textbox
            txtShowIncome.Text = showIncome;

        }

        private void btnBookAmenity_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void btnEnterChoice_Click(object sender, EventArgs e)
        {
            string amenity = txtChooseAmenity.Text;
            amenity = amenity.ToLower();
            switch(amenity)
            {
                case ("restaurant"):
                    groupBox5.Visible = true;
                    groupBox6.Visible = false;
                    break;
                case ("spa"):
                    groupBox6.Visible = true;
                    groupBox5.Visible = false;
                    break;
            }
        }

        private void btnBookRestaurant_Click(object sender, EventArgs e)
        {
            int startTime = int.Parse(txtRestaurantTime.Text);
            //Check booking
            restaurant.CheckBookingTimes(startTime);
            if (restaurant.IsFree() == true)
            {
                //Make booking
                restaurant.MakeRestaurantBooking(startTime);
                switch (startTime)
                {
                    case 7:
                        MessageBox.Show("Breakfast will cost £9.50.");
                        break;
                    case 8:
                        MessageBox.Show("Breakfast will cost £9.50.");
                        break;
                    case 9:
                        MessageBox.Show("Breakfast will cost £9.50.");
                        break;
                    case 10:
                        MessageBox.Show("Breakfast will cost £9.50.");
                        break;
                    case 11:
                        MessageBox.Show("Lunch will cost £17.50.");
                        break;
                    case 12:
                        MessageBox.Show("Lunch will cost £17.50.");
                        break;
                    case 13:
                        MessageBox.Show("Lunch will cost £17.50.");
                        break;
                    case 14:
                        MessageBox.Show("Lunch will cost £17.50.");
                        break;
                    case 15:
                        MessageBox.Show("Afternoon tea will cost £22.50.");
                        break;
                    case 16:
                        MessageBox.Show("Afternoon tea will cost £22.50.");
                        break;
                    case 17:
                        MessageBox.Show("Afternoon tea will cost £22.50.");
                        break;
                    case 18:
                        MessageBox.Show("Dinner will cost £35.");
                        break;
                    case 19:
                        MessageBox.Show("Dinner will cost £35.");
                        break;
                    case 20:
                        MessageBox.Show("Dinner will cost £35.");
                        break;
                    case 21:
                        MessageBox.Show("Dinner will cost £35.");
                        break;
                    case 22:
                        MessageBox.Show("Dinner will cost £35.");
                        break;
                }
            }
            else
            {
                //Display a message to say that no more bookings can be made
                MessageBox.Show("The restaurant is full for this time");
            }
        }

        private void btnBookSpa_Click(object sender, EventArgs e)
        {
            int bookingTime = int.Parse(txtSpaTime.Text);
            //Check booking
            spa.CheckBookTime(bookingTime);
            if (spa.IsFree() == true)
            {
                //Make booking
                spa.MakeSpaBooking(bookingTime);
            }
            else
            {
                //Display a message to say that no more bookings can be made
                MessageBox.Show("The spa is full at this time.");
            }
        }






        private void btnCreateRooms_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
