using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Object
        Calculator calculator1;

        private void btnCreateCalculator_Click(object sender, EventArgs e)
        {
            calculator1 = new Calculator();
        }


        private void btnAddition_Click(object sender, EventArgs e)
        {
            //Input numbers
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);

            calculator1.GetNumber1(num1);
            calculator1.GetNumber2(num2);

            //Add the numbers and get the result
            double result = calculator1.Addition();
            MessageBox.Show("The result is: " + result);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            //Input numbers
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);

            calculator1.GetNumber1(num1);
            calculator1.GetNumber2(num2);

            //Subtract the numbers and get the result
            double result = calculator1.Subtraction();
            MessageBox.Show("The result is: " + result);
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            //Input numbers
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);

            calculator1.GetNumber1(num1);
            calculator1.GetNumber2(num2);

            //Multiply the numbers and get the result
            double result = calculator1.Multiplication();
            MessageBox.Show("The result is: " + result);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //Input numbers
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);

            calculator1.GetNumber1(num1);
            calculator1.GetNumber2(num2);

            //Divide the numbers and get the results
            double result = calculator1.Division();
            MessageBox.Show("The result is: " + result);
        }
    }
}
