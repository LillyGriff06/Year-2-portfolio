using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterGradeToGradePoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertLetterGrade_Click(object sender, EventArgs e)
        {
            //variables
            string letterGrade;
            double gradePoints;

            //Input letter grade
            letterGrade = txtLetterGrade.Text;

            //Switch - letter grade converted to grade point
            switch(letterGrade)
            {
                case "A+":
                    gradePoints = 4.0;
                    txtGradePoints.Text = gradePoints.ToString();  
                    break;
                case "A":
                    gradePoints = 4.0;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "A-":
                    gradePoints = 3.7;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "B+":
                    gradePoints = 3.3;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "B":
                    gradePoints = 3.0;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "B-":
                    gradePoints = 2.7;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "C+":
                    gradePoints = 2.3;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "C":
                    gradePoints = 2.0;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "C-":
                    gradePoints = 1.7;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "D+":
                    gradePoints = 1.3;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "D":
                    gradePoints = 1.0;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
                case "F":
                    gradePoints = 0;
                    txtGradePoints.Text = gradePoints.ToString();
                    break;
            }
        }

        private void btnConvertGradePoint_Click(object sender, EventArgs e)
        {

            //Variables
            double gradePoints;
            string letterGrade;

            //Input grade points
            gradePoints = double.Parse(txtGradePointIn.Text);

            if (gradePoints >= 4.0)
            {
                letterGrade = "A+";
                txtLetterGradeOut.Text = letterGrade;
            }
            else
            {
                if (gradePoints > 3.7)
                {
                    letterGrade = "A";
                    txtLetterGradeOut.Text = letterGrade;
                }
            }
        }
    }
}
