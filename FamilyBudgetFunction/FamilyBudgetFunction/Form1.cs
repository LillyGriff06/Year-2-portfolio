using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudgetFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            //Local variables
            int familyID, familyNo;
            double annualIncome, totalDebt, predictedExpenses, monthlyPayment, amountToSave, serviceFee;

            //Input data to variables
            familyID = int.Parse(txtFamilyID.Text);
            familyNo = int.Parse(txtFamilyNo.Text);
            annualIncome = double.Parse(txtAnnualIncome.Text);
            totalDebt = double.Parse(txtTotalDebt.Text);

            //Calling the function that will calculate the predicted family living expenses
            predictedExpenses = CalculatePredictedExpences(familyNo);

            //Calling the function that will calculate the monthly payment
            monthlyPayment = CalculateMonthlyPayment(totalDebt);

            //Calling the function that will calculate the amount the family should save
            amountToSave = CalculateAmountToSave(familyNo, annualIncome, totalDebt);

            //Calling the function that will calculate the service fee
            serviceFee = CalculateServiceFee(annualIncome);

            //Declaring the function that will display results
            DisplayResults(familyID, predictedExpenses, monthlyPayment, amountToSave, serviceFee);
        }

        //Declaring the function that will calculate the predicted family living expenses
        double CalculatePredictedExpences(int familyNo)
        {
            double predictedExpenses;
            predictedExpenses = familyNo * 3000;
            return predictedExpenses;
        }

        //Declaring the function that will calculate the monthly payment
        double CalculateMonthlyPayment(double totalDebt)
        {
            double monthlyPayment;
            monthlyPayment = totalDebt / 12;
            return monthlyPayment;
        }

        //Declaring the function that will calculate the amount the family should save
        double CalculateAmountToSave(int familyNo, double annualIncome, double totalDebt)
        {
            double amountToSave;
            amountToSave = (familyNo * ((annualIncome - totalDebt) * 0.02));
            return amountToSave;
        }

        //Declaring the function that will calculate the service fee
        double CalculateServiceFee(double annualIncome)
        {
            double serviceFee;
            serviceFee = annualIncome * 0.005;
            return serviceFee;
        }

        //Declaring the function that will display results
        void DisplayResults(int familyID, double predictedExpenses, double monthlyPayment, double amountToSave, double serviceFee)
        {
            txtFamilyID2.Text = familyID.ToString();
            txtPredictedExpenses.Text = predictedExpenses.ToString();
            txtMonthlyPayment.Text = monthlyPayment.ToString();
            txtSave.Text = amountToSave.ToString();
            txtServiceFee.Text = serviceFee.ToString();
        }
    }
}
