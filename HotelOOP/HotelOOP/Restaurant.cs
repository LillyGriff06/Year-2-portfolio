using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelOOP
{
    internal class Restaurant
    {
        //Attributes
        private int numOfGuests7_9, numOfGuests8_10;
        private int numOfGuests11_13, numOfGuests12_14;
        private int numOfGuests15_17;
        private int numOfGuests18_20, numOfGuests19_21, numOfGuests20_22;
        private int maxGuests;
        private bool isFree;

        //Constructor
        public Restaurant()
        {
            numOfGuests7_9 = 0;
            numOfGuests8_10 = 0;
            numOfGuests11_13 = 0;
            numOfGuests12_14 = 0;
            numOfGuests15_17 = 0;
            numOfGuests18_20 = 0;
            numOfGuests19_21 = 0;
            numOfGuests20_22 = 0;
            maxGuests = 40;
            isFree = true;
        }

        //Methods
        public int GetMaxGuests()
        {
            return maxGuests;
        }

        public void CheckBookingTimes(int time)
        {
            int startTime = time;
            switch (startTime)
            {
                case 7:
                    if (maxGuests > numOfGuests7_9)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 8:
                    if (maxGuests > numOfGuests7_9 && maxGuests > numOfGuests8_10)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 9:
                    if (maxGuests > numOfGuests7_9 && maxGuests >numOfGuests8_10)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 10:
                    if (maxGuests > numOfGuests8_10)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 11:
                    if (maxGuests > numOfGuests11_13)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 12:
                    if (maxGuests > numOfGuests11_13 && maxGuests > numOfGuests12_14)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 13:
                    if (maxGuests > numOfGuests11_13 && maxGuests > numOfGuests12_14)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 14:
                    if (maxGuests > numOfGuests12_14)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 15:
                    if (maxGuests > numOfGuests15_17)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 16:
                    if (maxGuests > numOfGuests15_17)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 17:
                    if (maxGuests > numOfGuests15_17)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 18:
                    if (maxGuests > numOfGuests18_20)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 19:
                    if (maxGuests > numOfGuests18_20 && maxGuests > numOfGuests19_21)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 20:
                    if (maxGuests > numOfGuests18_20 && maxGuests > numOfGuests19_21 && maxGuests > numOfGuests20_22)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 21:
                    if (maxGuests > numOfGuests19_21 && maxGuests > numOfGuests20_22)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 22:
                    if (maxGuests > numOfGuests20_22)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }

            }
        }

        public bool IsFree()
        {
            //Displaying whether the restaurant is free to book for the time chosen
            return isFree;
        }

        public void MakeRestaurantBooking(int time)
        {
            int startTime = time;
            switch(startTime)
            {
                case 7:
                    numOfGuests7_9++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 8:
                    numOfGuests7_9++;
                    numOfGuests8_10++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 9:
                    numOfGuests7_9++;
                    numOfGuests8_10++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 10:
                    numOfGuests8_10++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 11:
                    numOfGuests11_13++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 12:
                    numOfGuests11_13++;
                    numOfGuests12_14++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 13:
                    numOfGuests11_13++;
                    numOfGuests12_14++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 14:
                    numOfGuests12_14++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 15:
                    numOfGuests15_17++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 16:
                    numOfGuests15_17++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 17:
                    numOfGuests15_17++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 18:
                    numOfGuests18_20++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 19:
                    numOfGuests18_20++;
                    numOfGuests19_21++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 20:
                    numOfGuests18_20++;
                    numOfGuests19_21++;
                    numOfGuests20_22++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 21:
                    numOfGuests19_21++;
                    numOfGuests20_22++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
                case 22:
                    numOfGuests20_22++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the restaurant.");
                    break;
            }
        }







        //Extra info: can be booked for a two hour slot, max guests = 40
        //Times: 7am-10am for breakfast, 11am-2pm for lunch, 3pm-5pm for afternoon tea, 6pm-10pm for dinner
        //Prices: £9.50 for breakfast, £17.50 for lunch, £22.50 for afternoon tea, £35 for dinner
    }
}
