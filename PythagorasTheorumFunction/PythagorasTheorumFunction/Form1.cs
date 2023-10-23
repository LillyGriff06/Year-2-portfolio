using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythagorasTheorumFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHypotenuse_Click(object sender, EventArgs e)
        {
            double sideA, sideB, hypotenuse;    //Assigning local variables

            //Inputting side A and side B
            sideA = double.Parse(txtSideA.Text);
            sideB = double.Parse(txtSideB.Text);

            //Calling the function to calculate the hypotenuse
            hypotenuse = CalculateHypotenuse(sideA, sideB);

            //Calling the function to display the hypotenuse
            DisplayHypotenuse(hypotenuse);
        }

        //Declaring the function to calculate the hypotenuse
        double CalculateHypotenuse(double mySideA, double mySideB)
        {
            double myHypotenuse;
            myHypotenuse = Math.Sqrt(Math.Pow(mySideA, 2) + Math.Pow(mySideB, 2));
            return myHypotenuse;
        }

        //Declaring the function to display the hypotenuse
        void DisplayHypotenuse(double myHypotenuse)
        {
            txtHypotenuse.Text = myHypotenuse.ToString();
        }

    }
}
