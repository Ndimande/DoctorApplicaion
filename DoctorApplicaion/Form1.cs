using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorApplicaion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (first_name.Text == "" || last_name.Text == ""  )
            {

                MessageBox.Show("Make sure First Name , Last Name are filled");

            }

            if (age.Text == "" || doctor.Text == "")
            {

                MessageBox.Show("Make sure Age and doctor drop down and are filled");

            }

            else
            {

                // 1. Create SqlCommand - Which lets the program know what type of action it is
                SqlCommand cmd = new SqlCommand("Register", GlobalConfig.SQLCONN);

                // 2. Set the Command type - So that it knows that we going to be using a STORED PROCEDURE
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. Input the Parameters of the STORED PROCEDURE

                cmd.Parameters.AddWithValue("@FirstName", first_name.Text);
                cmd.Parameters.AddWithValue("@LastName", last_name.Text);
                cmd.Parameters.AddWithValue("@FileNumber", file_number.Text);
                cmd.Parameters.AddWithValue("@Age", age.Text);
                cmd.Parameters.AddWithValue("@IsCash", is_cash.Text);
                cmd.Parameters.AddWithValue("@IsMedical", is_medical);

                // 4. Open and Close the Connection to the Database
                GlobalConfig.SQLCONN.Open();
                cmd.ExecuteNonQuery();
                GlobalConfig.SQLCONN.Close();

                MessageBox.Show("New Patient Added!");


                // Clears all the textboxes 

                first_name.Clear();
                last_name.Clear();
                age.Clear();


                // This is how to call methods from another FORM!
                var pForm = Application.OpenForms.OfType<Form1>().Single();

        }
    }
    }
}
