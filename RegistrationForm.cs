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
            int phoneNo = Convert.ToInt32(txtPhone.Text);

            string address = txtAddress.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;


            string con = @"Data Source=DESKTOP-QL6Q26N;Initial Catalog=CRUDDB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(con);
            sc.Open();
            string sqlInsert = "insert into RegisterTable(FirstName,LastName,Email, Gender,MaritalStatus,username,password,PhoneNo,Address,City,Country) values(?,?,?,?,?,?,?,?,?,?,?) ";
            SqlCommand sqc = new SqlCommand(sqlInsert,sc);
            sqc.ExecuteNonQuery();
            MessageBox.Show("Data inserted successfully");
            sc.Close();
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        void clear() {
            txtFname.Text = "";
            txtLname.Text = "";xt

        }
        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
