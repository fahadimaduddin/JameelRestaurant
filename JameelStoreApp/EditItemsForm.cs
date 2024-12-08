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
using JameelStoreApp.Model;

namespace JameelStoreApp
{
    public partial class EditItemsForm : MetroForm
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public EditItemsForm()
        {
            InitializeComponent();
        }

        private void EditItemsForm_Load(object sender, EventArgs e)
        {
            BindGridView();
        }
        private void GenerateItemId()
        {
            DBSqlServer db = new DBSqlServer(AppSetting.ConnectionString());
            ItemIdTextBox.Text = db.getScalarValue("spItemsGenerateNewItemId").ToString();
        }
        private void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from ItemsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ItemIdTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ItemNameTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                UnitPriceTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                DiscountPerItemTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch
            {
                MetroMessageBox.Show(this, "Select One Row At a Time...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                UpdateItems();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                DeleteItems();
            }
        }
        private void UpdateItems()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update ItemsTbl set ItemName = @ItemName, ItemPrice = @ItemPrice, ItemDiscount = @ItemDiscount where ItemId = @ItemId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ItemId", ItemIdTextBox.Text);
            cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text);
            cmd.Parameters.AddWithValue("@ItemPrice", UnitPriceTextBox.Text);
            cmd.Parameters.AddWithValue("@ItemDiscount", DiscountPerItemTextBox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MetroMessageBox.Show(this, "Updated Item Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                GenerateItemId();
                BindGridView();
                Resets();
            }
            else
            {
                MetroMessageBox.Show(this, "Updation Failed...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
            con.Close();
        }
        private void DeleteItems()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from ItemsTbl where ItemId = @ItemId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ItemId", ItemIdTextBox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MetroMessageBox.Show(this, "Deleted Item Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                GenerateItemId();
                BindGridView();
                Resets();
            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Failed...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
            con.Close();
        }
        private void Resets()
        {
            ItemIdTextBox.Clear();
            ItemNameTextBox.Clear();
            UnitPriceTextBox.Clear();
            DiscountPerItemTextBox.Clear();
            ItemNameTextBox.Focus();
        }
        private bool IsValid()
        {
            if (ItemIdTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Item Id is Required", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                ItemIdTextBox.Focus();
                return false;
            }
            return true;
        }

        private void ItemNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8 || ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void UnitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DiscountPerItemTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
