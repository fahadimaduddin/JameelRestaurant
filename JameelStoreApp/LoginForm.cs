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
    public partial class LoginForm : MetroForm
    {
        public static string Username = "";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MyLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else if (ShowPasswordCheckBox.Checked == false)
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Credentials();
            }
        }

        private bool IsValid()
        {
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
            return true;
        }
        private void Credentials()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from SignupTbl where Username = @Username and Password = @Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MetroMessageBox.Show(this, "Log In Successfull...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                Username = UsernameTextBox.Text;
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
                ClearFields();
            }
            else
            {
                MetroMessageBox.Show(this, "Your Username or Password is Incorrect...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
            con.Close();
        }
        private void ClearFields()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            ShowPasswordCheckBox.Checked = false;
        }

        private void MyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm su = new SignupForm();
            this.Hide();
            su.Show();
        }
    }
}
