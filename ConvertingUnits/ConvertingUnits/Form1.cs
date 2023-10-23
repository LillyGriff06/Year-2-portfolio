using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertingUnits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertMetres_Click(object sender, EventArgs e)
        {

            //Variables
            double metres;
            double conversionRateMF;
            double feet;

            //Input metres
            metres = double.Parse(txtMetre.Text);

            //Conversion rate
            conversionRateMF = 3.28;

            //Calculate feet
            feet = metres * conversionRateMF;

            //Output feet
            txtFoot.Text = feet.ToString();
        }

        private void btnConvertKilogrames_Click(object sender, EventArgs e)
        {

            //Variables
            double kilogrammes;
            double conversionRateKP;
            double pounds;

            //Input kilogrammes
            kilogrammes = double.Parse(txtKilogram.Text);

            //Conversion rate
            conversionRateKP = 2.2;

            //Calculate pounds
            pounds = kilogrammes * conversionRateKP;

            //Output pounds
            txtPound.Text = pounds.ToString();
        }

        private void btnConvertLitres_Click(object sender, EventArgs e)
        {
            //Variables
            double litres;
            double conversionRateLG;
            double gallons;

            //Input litres
            litres = double.Parse(txtLitre.Text);

            //Conversion rate
            conversionRateLG = 0.264;

            //Calculate gallons
            gallons = litres * conversionRateLG;

            //Output gallons
            txtGallon.Text = gallons.ToString();
        }
    }
}
