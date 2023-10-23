using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeHire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {

            //Variables

            int springCost;
            int summerCost;
            int autumnCost;
            int winterCost;

            int days;
            string season;
            decimal cost;

            //Season costs

            springCost = 24;
            summerCost = 29;
            autumnCost = 22;
            winterCost = 17;

            //Input days
            
            days = int.Parse(txtDays.Text);

            //Input season

            season = txtSeason.Text;

            //Switch statement

            switch(season)
            {
                case "spring":
                    cost = days * springCost;
                    //Output cost
                    txtCost.Text = cost.ToString();
                    break;
                case "summer":
                    cost = days * summerCost;
                    //Output cost
                    txtCost.Text = cost.ToString();
                    break;
                case "autumn":
                    cost = days * autumnCost;
                    //Output cost
                    txtCost.Text = cost.ToString();
                    break;
                case "winter":
                    cost = days * winterCost;
                    //Output cost
                    txtCost.Text = cost.ToString();
                    break;
            } 
        }
    }
}
