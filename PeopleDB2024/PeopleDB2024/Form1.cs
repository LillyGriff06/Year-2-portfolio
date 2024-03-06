using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDB2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2201454\\OneDrive - Middlesbrough College\\Documents\\DPY2\\Programming - Trevor - C#\\C# code\\PeopleDB2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Use stored procedure

            SqlCommand command = new SqlCommand("CreateNewPersonRecord", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            //Input name and age from form

            string name = txtName.Text;

            int age = int.Parse(txtAge.Text);

            string address = txtAddress.Text;

            string telephone_number = txtTelephoneNumber.Text;

            //Call stored procedure passing name and age as parameters

            command.Parameters.AddWithValue("@Name", name);

            command.Parameters.AddWithValue("@Age", age);

            command.Parameters.AddWithValue("@Address", address);

            command.Parameters.AddWithValue("@Telephone_number", telephone_number);

            //Open connection to database, execute stored procedure and close the connection

            sqlConnection.Open();

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void btnReadPeople_Click(object sender, EventArgs e)
        {
            //Read a person record

            List<Person> peopleList = new List<Person>();

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2201454\\OneDrive - Middlesbrough College\\Documents\\DPY2\\Programming - Trevor - C#\\C# code\\PeopleDB2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";
 
 
 
 
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("GetPersonDetails", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sqlConnection.Open();
            sd.Fill(dt);
            sqlConnection.Close();

            foreach (DataRow dr in dt.Rows)
            {
                peopleList.Add(
                    new Person
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Age = Convert.ToInt32(dr["Age"]),
                        Address = Convert.ToString(dr["Address"]),
                        Telephone_number = Convert.ToString(dr["Telephone_number"])

                    });
            }

            //Iterate through the student list and put data in textbox
            foreach (Person person in peopleList)
            {
                txtPeople.AppendText(person.Id.ToString() + "\t" + person.Name + "\t" + "\t" + person.Age.ToString() + "\t" + person.Address + "\t" + person.Telephone_number + Environment.NewLine);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Use stored procedure to delete record(s) containing a given name
            
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2201454\\OneDrive - Middlesbrough College\\Documents\\DPY2\\Programming - Trevor - C#\\C# code\\PeopleDB2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";
 
            SqlConnection sqlConnection = new SqlConnection(connectionString);
 
 
            //USE STORED PROCEDURE
            SqlCommand command = new SqlCommand("DeletePerson", sqlConnection);
 
            command.CommandType = CommandType.StoredProcedure;
 
            string name = txtDeleteName.Text;
 
            command.Parameters.AddWithValue("@Name", name);

            int age = int.Parse(txtDeleteAge.Text);

            command.Parameters.AddWithValue("@Age", age);
 
            sqlConnection.Open();
 
 
            command.ExecuteNonQuery();
 
            sqlConnection.Close();

            txtDeleteAge.Text = "0";
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2201454\\OneDrive - Middlesbrough College\\Documents\\DPY2\\Programming - Trevor - C#\\C# code\\PeopleDB2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);


            //USE STORED PROCEDURE
            SqlCommand command = new SqlCommand("UpdatePerson", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            int currentID = int.Parse(txtEditID.Text);
            string name = txtEditName.Text;
            int age = int.Parse(txtEditAge.Text);
            string address = txtEditAddress.Text;
            string telephone_number = txtEditTelephoneNumber.Text;

            command.Parameters.AddWithValue("@StdID", currentID);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Telephone_number", telephone_number);

            sqlConnection.Open();


            command.ExecuteNonQuery();

            sqlConnection.Close();

        }
    }
}
