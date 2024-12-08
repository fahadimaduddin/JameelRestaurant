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
    public partial class AddItemsForm : MetroForm
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public AddItemsForm()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                InsertItems();
            }
        }

        private bool IsValid()
        {
            if (ItemNameTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Item Name is Required", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                ItemNameTextBox.Focus();
                return false;
            }
            if (UnitPriceTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Unit Price is Required", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                UnitPriceTextBox.Focus();
                return false;
            }
            if (DiscountPerItemTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Discount Per Item is Required", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                DiscountPerItemTextBox.Focus();
                return false;
            }
            return true;
        }
        private void InsertItems()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into ItemsTbl values(@ItemId,@Name,@UnitPrice,@Discount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ItemId", ItemIdTextBox.Text);
            cmd.Parameters.AddWithValue("@Name", ItemNameTextBox.Text);
            cmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTextBox.Text);
            cmd.Parameters.AddWithValue("@Discount", DiscountPerItemTextBox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MetroMessageBox.Show(this, "Inserted Item Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                GenerateItemId();
                Resets();
            }
            else
            {
                MetroMessageBox.Show(this, "Insertion Failed...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
            con.Close();
        }

        private void Resets()
        {
            ItemNameTextBox.Clear();
            UnitPriceTextBox.Clear();
            DiscountPerItemTextBox.Clear();
            ItemNameTextBox.Focus();
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

        private void AddItemsForm_Load(object sender, EventArgs e)
        {
            GenerateItemId();
        }
        private void GenerateItemId()
        {
            DBSqlServer db = new DBSqlServer(AppSetting.ConnectionString());
            ItemIdTextBox.Text = db.getScalarValue("spItemsGenerateNewItemId").ToString();
        }
    }
}
