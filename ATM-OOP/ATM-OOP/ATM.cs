using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_OOP
{
    internal class ATM
    {
        //Attributes
        private int pin;
        private decimal balance;
        private decimal money;
        private string accepted;

        //Methods
        public string CheckPin(int myPin)
        {
            switch (myPin)
            {
                case 1234:
                    accepted = "yes";
                    return accepted;
                case 5678:
                    accepted = "yes";
                    return accepted;
                case 9101:
                    accepted = "yes";
                    return accepted;
                default: return "no";
            }
        }

        public void MakeWithdrawal(decimal money)
        {
            if (money <= 200)
            {
                if (balance > money)
                {
                    balance = balance - money;
                    MessageBox.Show("Money withdrawn");
                }
                else
                {
                    MessageBox.Show("Withdrawal failed. Overdrawn.");
                }
            }
            else
            {
                MessageBox.Show("Cannot withdraw money. You have tried to withdraw over £200.");
            }
        }

        //Constructor
        public ATM()
        {
            balance = 200000;
        }
    }
}
