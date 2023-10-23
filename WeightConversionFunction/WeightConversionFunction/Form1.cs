using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace WeightConversionFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertWeight_Click(object sender, EventArgs e)
        {
            //Local variables
            double ounces, conversionRateOP, pounds, conversionRateOG, grams, conversionRateOK, kilogrammes;

            //Inputting ounces
            ounces = double.Parse(txtOunces.Text);

            //Assigning conversion rates
            conversionRateOP = 16;
            conversionRateOG = 28.35;
            conversionRateOK = conversionRateOG * 1000;

            //Calling the function that converts ounces to pounds
            pounds = ConvertToPounds(ounces, conversionRateOP);
            //Calling the function that converts ounces to grams
            grams = ConvertToGrams(ounces, conversionRateOG);

            //Calling the function that converts ounces to kilogrammes
            kilogrammes = ConvertToKilogrammes(ounces, conversionRateOK);

            //Calling the function that displays the values
            DisplayValues(pounds, grams, kilogrammes);
        }

        //Declaring the function that converts ounces to pounds
        double ConvertToPounds(double myOunces, double myConversionRate)
        {
            double myPounds;
            myPounds = myOunces / myConversionRate;
            return myPounds;
        }

        //Declaring the function that converts ounces to grams
        double ConvertToGrams(double myOunces, double myConversionRate)
        {
            double myGrams;
            myGrams = myOunces * myConversionRate;
            return myGrams;
        }

        //Declaring the function that converts ounces to Kilogrammes
        double ConvertToKilogrammes(double myOunces, double myConversionRate)
        {
            double myKilogrammes;
            myKilogrammes = myOunces * myConversionRate;
            return myKilogrammes;
        }

        //Declaring the function that displays the values
        void DisplayValues(double myPounds, double myGrams, double myKilogrammes) 
        {
            txtPounds.Text = myPounds.ToString();
            txtGrams.Text = myGrams.ToString();
            txtKilogrammes.Text = myKilogrammes.ToString();
        }
    }
}
