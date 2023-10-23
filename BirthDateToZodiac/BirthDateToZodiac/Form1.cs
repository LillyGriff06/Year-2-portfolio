using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthDateToZodiac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertDate_Click(object sender, EventArgs e)
        {

            //Variables
            string month;
            int day;
            string zodiac;

            //Input month
            month = txtMonth.Text;

            //Input day
            day = int.Parse(txtDay.Text);

            //Switch statement - months
            switch(month)
            {
                case "December":
                    //if statement - days
                    if (day >= 22){
                        zodiac = "Capricorn";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Sagittarius";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "January":
                    //if statement - days
                    if (day >= 20)
                    {
                        zodiac = "Aquarius";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Capricorn";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "February":
                    //if statement - days
                    if (day >= 19)
                    {
                        zodiac = "Pisces";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Aquarius";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "March":
                    //if statement - days
                    if (day >= 21)
                    {
                        zodiac = "Aries";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Pisces";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "April":
                    //if statement - days
                    if (day >= 20)
                    {
                        zodiac = "Taurus";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Aries";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "May":
                    //if statement - days
                    if (day >= 21)
                    {
                        zodiac = "Gemini";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Taurus";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "June":
                    //if statement - days
                    if (day >= 21)
                    {
                        zodiac = "Cancer";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Gemini";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "July":
                    //if statement - days
                    if (day >= 23)
                    {
                        zodiac = "Leo";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Cancer";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "August":
                    //if statement - days
                    if (day >= 23)
                    {
                        zodiac = "Virgo";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Leo";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "September":
                    //if statement - days
                    if (day >= 23)
                    {
                        zodiac = "Libra";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Virgo";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "October":
                    //if statement - days
                    if (day >= 23)
                    {
                        zodiac = "Scorpio";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Libra";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
                case "November":
                    //if statement - days
                    if (day >= 22)
                    {
                        zodiac = "Sagittarius";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    else
                    {
                        zodiac = "Scorpio";
                        //Output zodiac
                        txtZodiac.Text = zodiac;
                    }
                    break;
            }

        }
    }
}
