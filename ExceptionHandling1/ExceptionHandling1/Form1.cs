using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateSales_Click(object sender, EventArgs e)
        {
            //Catching exceptions
            try
            {
                //Input the number of tickets sold
                int ticketsSold = int.Parse(txtTicketsSold.Text);
                double cost = 10.99;
                //Calculate the total cost
                double totalCost = ticketsSold * cost;
                //Checking if sales are high
                if (totalCost > 40000)
                {
                    MessageBox.Show("Ticket sales are high at £" + totalCost);
                }
                else
                {
                    MessageBox.Show("Ticket sales are low at £" + totalCost);
                }
            }
            catch(Exception ex) 
            { 
                //Output exception message
                MessageBox.Show("There was an exception: " + ex.Message);
            }
        }
    }
}
