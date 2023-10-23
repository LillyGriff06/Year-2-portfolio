using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiCompanyPricesFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateTaxiPrice_Click(object sender, EventArgs e)
        {
            double basePrice, extraCost, extraDistance, distance, additionalCost, totalCost; //Local variables

            //Assigning data to basePrice and extraCost
            basePrice = 4.00;
            extraCost = 0.25;

            //Inputting distance
            extraDistance = double.Parse(txtDistance.Text);

            //Calling the function to calculate the floor division
            distance = CalculateDistance(extraDistance);

            //Calling the function that calculates the additional costs
            additionalCost = CalculateAdditionalCosts(distance, extraCost);

            //Calling the function that calculates the taxi price
            totalCost = CalculateTaxiPrice(basePrice, additionalCost);

            //Calling the function to display the price
            DisplayPrice(totalCost);
        }

        //Declaring the function to calculate the floor division
        double CalculateDistance(double myExtraDistance)
        {
            double myDistance;
            myDistance = Math.Floor(myExtraDistance / 140);
            return myDistance;
        }

        //Declaring the function that calculates the additional costs
        double CalculateAdditionalCosts(double myDistance, double myExtraCost)
        {
            double myAdditionalCost;
            myAdditionalCost = myDistance * myExtraCost;
            return myAdditionalCost;
        }

        //Declaring the function that calculates the taxi price
        double CalculateTaxiPrice(double myBasePrice, double myAdditionalCost)
        {
            double myTotalPrice;
            myTotalPrice = myBasePrice + myAdditionalCost;
            return myTotalPrice;
        }

        //Declaring the function the display the price
        void DisplayPrice(double myTotalCost)
        {
            txtTotalCost.Text = myTotalCost.ToString();
        }
    }
}
