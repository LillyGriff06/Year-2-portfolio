using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Create object
        ATM atm1 = new ATM();

        private void btnCheckPin_Click(object sender, EventArgs e)
        {
            //Checking the pin that was inputted
            int myPin = int.Parse(txtPin.Text);
            string accepted = atm1.CheckPin(myPin);
            if (accepted == "yes")
            {
                //Message for correct pin
                MessageBox.Show("Correct pin");
            }
            else
            {
                //Message for incorrect pin
                MessageBox.Show("Incorrect pin");
            }
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            //Making sure that money is only withdrawn if the correct pin is inputted.
            int myPin = int.Parse(txtPin.Text);
            string accepted = atm1.CheckPin(myPin);
            if (accepted == "yes")
            {
                //Withdrawing money
                decimal myMoney = decimal.Parse(txtWithdraw.Text);
                atm1.MakeWithdrawal(myMoney);
            }
            else
            {
                //Message explaining why the money couldn't be withdrawn
                MessageBox.Show("Incorrect pin was inputted. Money cannot be withdrawn");
            }
        }
    }
}
