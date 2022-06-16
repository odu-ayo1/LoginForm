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

namespace LoginForm
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string email = txtEmail.Text;
            string gender;
            if (radMale.Checked.Equals(true))
            {
                gender = "Male";
            }
            else {
                gender = "Female";
            }
            string maritalStatus = cmbMaritalStatus.SelectedItem.ToString();
            string username = txtUsername.Text;
            string passw = txtPassword.Text;
            if (passw.Equals(txtConfirmPassword).Equals(true))
            {
                Console.WriteLine("Password and Confirm Password match");
            }
            else {
                Console.WriteLine("Enter the same password for confirm password");
            }
            long phoneNo = Convert.ToInt64(txtPhone.Text);

            string address = txtAddress.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;
            // connection string
            string con = @"Data Source=DESKTOP-QL6Q26N;Initial Catalog=CRUDDB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(con);
            sc.Open();
            string sqlInsert = "insert into RegisterTable(FirstName,LastName,Email, Gender,MaritalStatus,username,password,PhoneNo,Address,City,Country) " +
                "values(@FirstName, @LastName ,@Email,@Gender,@MaritalStatus,@username,@password,@PhoneNo,@Address,@City,@Country)";
            SqlCommand sqc = new SqlCommand(sqlInsert,sc);
            sqc.Parameters.AddWithValue("@FirstName",fname);
            sqc.Parameters.AddWithValue("@LastName", lname);
            sqc.Parameters.AddWithValue("@Email", email);
            sqc.Parameters.AddWithValue("@Gender", gender);
            sqc.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
            sqc.Parameters.AddWithValue("@username", username);
            sqc.Parameters.AddWithValue("@password", passw);
            sqc.Parameters.AddWithValue("@PhoneNo", phoneNo);
            sqc.Parameters.AddWithValue("@Address", address);
            sqc.Parameters.AddWithValue("@City", city);
            sqc.Parameters.AddWithValue("@Country", country);
            sqc.ExecuteNonQuery();
            MessageBox.Show("Data inserted successfully");
            sc.Close();
            clear();
            //Login lg = new Login();
            //lg.Show();
           // this.Hide();
        }

        void clear() {
            txtFname.Text = "";
            txtLname.Text = "";
            txtEmail.Text = "";
            radMale.Checked = false;
            radFemale.Checked = false;
            cmbMaritalStatus.SelectedIndex = -1;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtConfirmPassword.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";


        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
