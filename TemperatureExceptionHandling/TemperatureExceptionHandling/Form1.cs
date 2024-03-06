using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertCtoF_Click(object sender, EventArgs e)
        {
            //Catching exceptions
            try
            {
                //Input celcius
                double celsius = double.Parse(txtCelsius1.Text);
                //Checking for valid temperature
                if (celsius <= 100 && celsius >= -100 ) 
                {
                    //Fahrenheit = Celsius * 9 / 5 + 32
                    double fahrenheit = celsius * 9 / 5 + 32;
                    //Display answer
                    txtFahrenheit1.Text = fahrenheit.ToString();
                }
                else
                {
                    //Error message for invalid temperature
                    MessageBox.Show("Temperature out of range");
                }
            }
            catch(Exception ex)
            {
                //Output exception message
                txtFahrenheit1.Text = "";
                MessageBox.Show("There is an Exception: " + ex.Message);
            }
        }

        private void btnConvertFtoC_Click(object sender, EventArgs e)
        {
            //Catching exceptions
            try
            {
                //Input fahrenheit
                double fahrenheit = double.Parse (txtFahrenheit2.Text);
                if (fahrenheit <= 212 && fahrenheit >= -148 )
                {
                    //Celcius = (Fahrenheit - 32) * 5 / 9
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    //Display answer
                    txtCelsius2.Text = celsius.ToString();
                }
                else
                {
                    //Error message for invalid temperature
                    MessageBox.Show("Temperature out of range");
                }
            }
            catch (Exception ex)
            {
                //Output exception message
                txtCelsius2.Text = "";
                MessageBox.Show("There is an Exception: " + ex.Message );
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
