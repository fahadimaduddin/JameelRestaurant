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
using System.Configuration;
using System.Data.SqlClient;


namespace JameelStoreApp
{
    public partial class DetailsAndSearchForm : MetroForm
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public DetailsAndSearchForm()
        {
            InitializeComponent();
        }
        private void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "spGetBothTablesData";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DetailsAndSearchForm_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Invoice is Required...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                SearchTextBox.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "spGetDataByInvoiceId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceId", SearchTextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[10].Visible = false;
                    FinalAmountTextBox.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
                }
                else
                {
                    MetroMessageBox.Show(this, "No Rows Found...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                    dataGridView1.DataSource = dt;
                    SearchTextBox.Clear();
                    FinalAmountTextBox.Clear();
                    SearchTextBox.Focus();
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BindGridView();
            SearchTextBox.Clear();
            FinalAmountTextBox.Clear();
            SearchTextBox.Focus();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void SearchDateTimeButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "spGetDataByDateTime";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstDateTime", dateTimePicker1.Value.ToString("dd-MM-yyyy hh:mm:ss:tt"));
            cmd.Parameters.AddWithValue("@SecondDateTime", dateTimePicker2.Value.ToString("dd-MM-yyyy hh:mm:ss:tt"));
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MetroMessageBox.Show(this, "No Rows Found...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                dataGridView1.DataSource = dt;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
            }
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
