using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelOOP
{
    internal class Spa
    {
        //Attributes
        private int numOfGuests6_8, numOfGuests7_9, numOfGuests8_10, numOfGuests9_11, numOfGuests10_12, numOfGuests11_13;
        private int numOfGuests12_14, numOfGuests13_15, numOfGuests14_16, numOfGuests15_17, numOfGuests16_18, numOfGuests17_19;
        private int numOfGuests18_20, numOfGuests19_21, numOfGuests20_22;
        private int maxGuests;
        private bool isFree;

        //Constructor
        public Spa() 
        { 
            numOfGuests6_8 = 0;
            numOfGuests7_9 = 0;
            numOfGuests8_10 = 0;
            numOfGuests9_11 = 0;
            numOfGuests10_12 = 0;
            numOfGuests11_13 = 0;
            numOfGuests12_14 = 0;
            numOfGuests13_15 = 0;
            numOfGuests14_16 = 0;
            numOfGuests15_17 = 0;
            numOfGuests16_18 = 0;
            numOfGuests17_19 = 0;
            numOfGuests18_20 = 0;
            numOfGuests19_21 = 0;
            numOfGuests20_22 = 0;
            maxGuests = 18;
            isFree = true;
        }

        //Methods
        public int GetMaxGuests()
        {
            return maxGuests;
        }

        public void CheckBookTime(int time)
        {
            int startTime = time;
            switch (startTime)
            {
                case 6:
                    if(maxGuests > numOfGuests6_8)
                    {
                        isFree = true ; break;
                    }
                    else
                    {
                        isFree = false ; break;
                    }
                case 7:
                    if(maxGuests > numOfGuests6_8 && maxGuests > numOfGuests7_9)
                    {
                        isFree = true ; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 8:
                    if(maxGuests > numOfGuests6_8 && maxGuests > numOfGuests7_9 && maxGuests > numOfGuests8_10)
                    {
                        isFree = true ; break;
                    }
                    else   
                    { 
                        isFree = false; break; 
                    }
                case 9: 
                    if(maxGuests > numOfGuests7_9 && maxGuests > numOfGuests8_10 && maxGuests > numOfGuests9_11)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 10: 
                    if(maxGuests > numOfGuests8_10 && maxGuests > numOfGuests9_11 && maxGuests > numOfGuests10_12)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 11: 
                    if(maxGuests > numOfGuests9_11 && maxGuests > numOfGuests10_12 && maxGuests > numOfGuests11_13)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 12: 
                    if(maxGuests > numOfGuests10_12 && maxGuests > numOfGuests11_13 && maxGuests > numOfGuests12_14)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 13:
                    if(maxGuests > numOfGuests11_13 && maxGuests > numOfGuests12_14 && maxGuests > numOfGuests13_15)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 14:
                    if(maxGuests > numOfGuests12_14 && maxGuests > numOfGuests13_15 && maxGuests > numOfGuests14_16)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 15:
                    if(maxGuests > numOfGuests13_15 && maxGuests > numOfGuests14_16 && maxGuests > numOfGuests15_17)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 16:
                    if(maxGuests > numOfGuests14_16 && maxGuests > numOfGuests15_17 && maxGuests > numOfGuests16_18)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 17:
                    if(maxGuests > numOfGuests15_17 && maxGuests > numOfGuests16_18 && maxGuests > numOfGuests17_19)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 18:
                    if(maxGuests > numOfGuests16_18 && maxGuests > numOfGuests17_19 && maxGuests > numOfGuests18_20)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 19:
                    if(maxGuests > numOfGuests17_19 && maxGuests > numOfGuests18_20 && maxGuests > numOfGuests19_21)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 20:
                    if(maxGuests > numOfGuests18_20 && maxGuests > numOfGuests19_21 && maxGuests > numOfGuests20_22)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 21:
                    if(maxGuests > numOfGuests19_21 && maxGuests > numOfGuests20_22)
                    {
                        isFree = true; break;
                    }
                    else
                    {
                        isFree = false; break;
                    }
                case 22:
                    if(maxGuests > numOfGuests20_22)
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
            //Returning whether the spa is free to book for the time period chosen
            return isFree;
        }

        public void MakeSpaBooking(int time)
        {
            //Get startTime
            int startTime = time;
            switch(startTime)
            {
                case 6:
                    numOfGuests6_8++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 7:
                    numOfGuests6_8++;
                    numOfGuests7_9++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 8:
                    numOfGuests6_8++;
                    numOfGuests7_9++;
                    numOfGuests8_10++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 9:
                    numOfGuests7_9++;
                    numOfGuests8_10++;
                    numOfGuests9_11++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 10:
                    numOfGuests8_10++;
                    numOfGuests9_11++;
                    numOfGuests10_12++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 11:
                    numOfGuests9_11++;
                    numOfGuests10_12++;
                    numOfGuests11_13++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 12:
                    numOfGuests10_12++;
                    numOfGuests11_13++;
                    numOfGuests12_14++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 13:
                    numOfGuests11_13++;
                    numOfGuests12_14++;
                    numOfGuests13_15++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 14:
                    numOfGuests12_14++;
                    numOfGuests13_15++;
                    numOfGuests14_16++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 15:
                    numOfGuests13_15++;
                    numOfGuests14_16++;
                    numOfGuests15_17++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 16:
                    numOfGuests14_16++;
                    numOfGuests15_17++;
                    numOfGuests16_18++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 17:
                    numOfGuests15_17++;
                    numOfGuests16_18++;
                    numOfGuests17_19++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 18:
                    numOfGuests16_18++;
                    numOfGuests17_19++;
                    numOfGuests18_20++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 19:
                    numOfGuests17_19++;
                    numOfGuests18_20++;
                    numOfGuests19_21++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 20:
                    numOfGuests18_20++;
                    numOfGuests19_21++;
                    numOfGuests20_22++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 21:
                    numOfGuests19_21++;
                    numOfGuests20_22++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
                case 22:
                    numOfGuests20_22++;
                    //Display message for a successful booking
                    MessageBox.Show("You have successfully booked a place in the spa.");
                    break;
            }
        }




        //Extra info: can be booked for a two hours slot, max guests = 18
        //Open time: 6am-10pm
    }
}
