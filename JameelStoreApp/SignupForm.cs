using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace JameelStoreApp
{
    public partial class SignupForm : MetroForm
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            this.MyLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void MyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                UserSignup();
            }
        }
        private void UserSignup()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into SignupTbl values(@FullName,@Gender,@Age,@Address,@Email,@Username,@Password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FullName", FullNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Gender", GenderComboBox.SelectedItem);
            cmd.Parameters.AddWithValue("@Age", AgeNumericUpDown.Value);
            cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);
            cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
            cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MetroMessageBox.Show(this, "Sign Up Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                MetroMessageBox.Show(this, "Your Username is: " + UsernameTextBox.Text + "\n" + "Your Password is: " + PasswordTextBox.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                this.Hide();
                LoginForm li = new LoginForm();
                li.Show();
                ResetFields();
            }
            else
            {
                MetroMessageBox.Show(this, "Sign Up Failed...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
            con.Close();
        }
        private void ResetFields()
        {
            FullNameTextBox.Clear();
            GenderComboBox.Text = "Select Gender";
            AgeNumericUpDown.Value = 0;
            AddressTextBox.Clear();
            EmailTextBox.Clear();
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
            FullNameTextBox.Focus();
        }
        private bool IsValid()
        {
            if (FullNameTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Full Name is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                FullNameTextBox.Focus();
                return false;
            }
            if (GenderComboBox.Text == "Select Gender")
            {
                MetroMessageBox.Show(this, "Gender is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                GenderComboBox.Focus();
                return false;
            }
            if (AgeNumericUpDown.Value < 17)
            {
                MetroMessageBox.Show(this, "Age should be greater than 17 is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                AgeNumericUpDown.Focus();
                return false;
            }
            if (AddressTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Address is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                AddressTextBox.Focus();
                return false;
            }
            if (EmailTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Email is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                EmailTextBox.Focus();
                return false;
            }
            if (UsernameTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Username is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                UsernameTextBox.Focus();
                return false;
            }
            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Password is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                PasswordTextBox.Focus();
                return false;
            }
            if (ConfirmPasswordTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Confirm Password is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                ConfirmPasswordTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
