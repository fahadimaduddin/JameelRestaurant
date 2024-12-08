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
    public partial class MainForm : MetroForm
    {
        int i;
        int FinalCost = 0;
        int Tax = 0;
        int SrNo = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            getInvoiceId();
            FillComboBox();
            LoadDataGridView();
            NameTextBox.Text = LoginForm.Username;
        }
        private void LoadDataGridView()
        {
            JamilStoreDataGridView.ColumnCount = 8;
            JamilStoreDataGridView.Columns[0].Name = "SR No";
            JamilStoreDataGridView.Columns[1].Name = "Item Name";
            JamilStoreDataGridView.Columns[2].Name = "Unit Price";
            JamilStoreDataGridView.Columns[3].Name = "Discount Per Item";
            JamilStoreDataGridView.Columns[4].Name = "Quantity";
            JamilStoreDataGridView.Columns[5].Name = "Sub Total";
            JamilStoreDataGridView.Columns[6].Name = "Tax";
            JamilStoreDataGridView.Columns[7].Name = "Total Cost";
        }
        private void FillComboBox()
        {
            ItemsComboBox.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from ItemsTbl";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string name = dr.GetString(1);
                ItemsComboBox.Items.Add(name);
            }
            ItemsComboBox.Sorted = true;
            con.Close();
        }
        private void getPrice()
        {
            int Price = 0;
            SqlConnection con = new SqlConnection(cs);
            string query = "select ItemPrice from ItemsTbl where ItemName = @Name";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@Name", ItemsComboBox.SelectedItem.ToString());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Price = Convert.ToInt32(dt.Rows[0]["ItemPrice"]);
            }
            UnitPriceTextBox.Text = Price.ToString();
        }
        private void getDiscount()
        {
            int Discount = 0;
            SqlConnection con = new SqlConnection(cs);
            string query = "select ItemDiscount from ItemsTbl where ItemName = @Name";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@Name", ItemsComboBox.SelectedItem.ToString());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Discount = Convert.ToInt32(dt.Rows[0]["ItemDiscount"]);
            }
            DiscountPerItemTextBox.Text = Discount.ToString();
        }

        private void ItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPrice();
            getDiscount();
            QuantityTextBox.Enabled = true;

        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QuantityTextBox.Text))
            {

            }
            else
            {
                int quantity = 0;
                int price = Convert.ToInt32(UnitPriceTextBox.Text);
                int discount = Convert.ToInt32(DiscountPerItemTextBox.Text);
                try
                {
                    quantity = Convert.ToInt32(QuantityTextBox.Text);
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Quantity Should not be Zero or Negative...", "Jameel Store", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                }

                int subTotal = price * quantity;
                subTotal = subTotal - discount * quantity;
                SubTotalTextBox.Text = subTotal.ToString();
            }
        }

        private void SubTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SubTotalTextBox.Text))
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(SubTotalTextBox.Text);
                if (subTotal >= 10000)
                {
                    Tax = (int)(subTotal * 0.15);
                    TaxTextBox.Text = Tax.ToString();
                }
                else if (subTotal >= 6000)
                {
                    Tax = (int)(subTotal * 0.10);
                    TaxTextBox.Text = Tax.ToString();
                }
                else if (subTotal >= 3000)
                {
                    Tax = (int)(subTotal * 0.07);
                    TaxTextBox.Text = Tax.ToString();
                }
                else if (subTotal >= 1000)
                {
                    Tax = (int)(subTotal * 0.05);
                    TaxTextBox.Text = Tax.ToString();
                }
                else
                {
                    Tax = (int)(subTotal * 0.03);
                    TaxTextBox.Text = Tax.ToString();
                }
            }
        }

        private void TaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TaxTextBox.Text))
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(SubTotalTextBox.Text);
                int tax = Convert.ToInt32(TaxTextBox.Text);
                int totalCost = subTotal + tax;
                TotalCostTextBox.Text = totalCost.ToString();
            }
        }

        private void AddDataToGridView(string SrNo, string ItemName, string UnitPrice, string DiscountPerItem, string Quantity, string SubTotal, string Tax, string TotalCost)
        {
            string[] row = { SrNo, ItemName, UnitPrice, DiscountPerItem, Quantity, SubTotal, Tax, TotalCost };
            JamilStoreDataGridView.Rows.Add(row);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                AddDataToGridView((++SrNo).ToString(), ItemsComboBox.SelectedItem.ToString(), UnitPriceTextBox.Text, DiscountPerItemTextBox.Text, QuantityTextBox.Text, SubTotalTextBox.Text, TaxTextBox.Text, TotalCostTextBox.Text);
                ResetControls();
                CalculateFinalCost();
                AmountPaidTextBox.Enabled = true;
            }
        }

        private bool IsValid()
        {
            if (ItemsComboBox.Text == "Select Item")
            {
                MetroMessageBox.Show(this, "Item is Required", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                ItemsComboBox.Focus();
                return false;
            }
            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Quantity is Required", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                QuantityTextBox.Focus();
                return false;
            }
            return true;
        }

        private void ResetControls()
        {
            ItemsComboBox.Text = "Select Item";
            UnitPriceTextBox.Clear();
            DiscountPerItemTextBox.Clear();
            QuantityTextBox.Clear();
            SubTotalTextBox.Clear();
            TaxTextBox.Clear();
            TotalCostTextBox.Clear();
            ItemsComboBox.Focus();
            ChangeTextBox.Clear();
            QuantityTextBox.Enabled = false;
        }
        private void CalculateFinalCost()
        {
            FinalCost = 0;
            for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
            {
                FinalCost = FinalCost + (Convert.ToInt32(JamilStoreDataGridView.Rows[i].Cells[7].Value));
            }
            FinalCostTextBox.Text = FinalCost.ToString();
        }

        private void AmountPaidTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AmountPaidTextBox.Text))
            {

            }
            else
            {
                int AmountPaid = Convert.ToInt32(AmountPaidTextBox.Text);
                int FinalCost = Convert.ToInt32(FinalCostTextBox.Text);
                int Change = AmountPaid - FinalCost;
                ChangeTextBox.Text = Change.ToString();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Resets();
        }

        private void Resets()
        {
            ItemsComboBox.Text = "Select Item";
            UnitPriceTextBox.Clear();
            DiscountPerItemTextBox.Clear();
            QuantityTextBox.Clear();
            SubTotalTextBox.Clear();
            TaxTextBox.Clear();
            TotalCostTextBox.Clear();
            FinalCostTextBox.Clear();
            AmountPaidTextBox.Clear();
            ChangeTextBox.Clear();
            ItemsComboBox.Focus();
            JamilStoreDataGridView.Rows.Clear();
            QuantityTextBox.Enabled = false;
            AmountPaidTextBox.Enabled = false;
            SrNo = 0;
        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void getInvoiceId()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select InvoiceId from OrderMasterTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
            {
                InvoiceNoTextBox.Text = "1";
            }
            else
            {
                string q = "select max(InvoiceId) from OrderMasterTbl";
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                InvoiceNoTextBox.Text = a.ToString();
                con.Close();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Name is Required", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                NameTextBox.Focus();
            }
            else if (FinalCostTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Final Cost is Required", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                FinalCostTextBox.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into OrderMasterTbl values(@InvoiceId,@Name,@DateTime,@FinalCost)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@InvoiceId", InvoiceNoTextBox.Text);
                cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@DateTime", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss:tt"));
                cmd.Parameters.AddWithValue("@FinalCost", FinalCostTextBox.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MetroMessageBox.Show(this, "Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                    getInvoiceId();
                    //Resets();
                }
                else
                {
                    MetroMessageBox.Show(this, "Insertion Failed...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                }
                con.Close();
                InsertIntoOrderDetails();
            }
        }

        private int getLastInsertedVoiceId()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select max(InvoiceId) from OrderMasterTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int MaxInvoiceId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return MaxInvoiceId;

        }

        private void InsertIntoOrderDetails()
        {
            int a = 0;
            SqlConnection con = new SqlConnection(cs);
            for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
            {
                string query = "insert into OrderDetailsTbl values(@InvoiceId,@ItemName,@UnitPrice,@Discount,@Quantity,@SubTotal,@Tax,@TotalCost)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@InvoiceId", getLastInsertedVoiceId());
                cmd.Parameters.AddWithValue("@ItemName", JamilStoreDataGridView.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@UnitPrice", JamilStoreDataGridView.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@Discount", JamilStoreDataGridView.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@Quantity", JamilStoreDataGridView.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@SubTotal", JamilStoreDataGridView.Rows[i].Cells[5].Value);
                cmd.Parameters.AddWithValue("@Tax", JamilStoreDataGridView.Rows[i].Cells[6].Value);
                cmd.Parameters.AddWithValue("@TotalCost", JamilStoreDataGridView.Rows[i].Cells[7].Value);
                con.Open();
                a = a + cmd.ExecuteNonQuery();
                con.Close();
            }
            if (a > 0)
            {
                MetroMessageBox.Show(this, "Data Added in Order Details Table Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                Resets();
            }
            else
            {
                MetroMessageBox.Show(this, "Data Not Added in Order Details Table...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }

        }

        private void AmountPaidTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PrintPreviewButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.JamilStoreLogo;
            Image img = bmp;
            e.Graphics.DrawImage(img, 30, 20, 800, 250);
            e.Graphics.DrawString("Invoice No: " + InvoiceNoTextBox.Text, new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("Customer Name: " + NameTextBox.Text, new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Time: " + DateTime.Now.ToLongTimeString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 420));
            e.Graphics.DrawString("Items ", new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("Quantity ", new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(260, 450));
            e.Graphics.DrawString("Unit Price ", new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(450, 450));
            e.Graphics.DrawString("Discount ", new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(680, 450));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 480));

            // Items
            int gap = 510;
            if (JamilStoreDataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(JamilStoreDataGridView.Rows[i].Cells[1].Value.ToString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }
            }

            // Quantity
            int gap1 = 510;
            if (JamilStoreDataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(JamilStoreDataGridView.Rows[i].Cells[4].Value.ToString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(300, gap1));
                        gap1 = gap1 + 30;
                    }
                    catch
                    {

                    }
                }
            }

            // Unitprice
            int gap2 = 510;
            if (JamilStoreDataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(JamilStoreDataGridView.Rows[i].Cells[2].Value.ToString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(480, gap2));
                        gap2 = gap2 + 30;
                    }
                    catch
                    {

                    }
                }
            }

            // Discount
            int gap3 = 510;
            if (JamilStoreDataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(JamilStoreDataGridView.Rows[i].Cells[3].Value.ToString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(720, gap3));
                        gap3 = gap3 + 30;
                    }
                    catch
                    {

                    }
                }
            }
            int SubTotalPrint = 0;
            for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
            {
                SubTotalPrint = SubTotalPrint + (Convert.ToInt32(JamilStoreDataGridView.Rows[i].Cells[5].Value));
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 800));
            e.Graphics.DrawString("Sub Total: " + SubTotalPrint.ToString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 830));
            int TaxPrint = 0;
            for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
            {
                TaxPrint = TaxPrint + (Convert.ToInt32(JamilStoreDataGridView.Rows[i].Cells[6].Value));
            }
            e.Graphics.DrawString("GST: " + TaxPrint.ToString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 860));
            int FinalCostPrint = 0;
            for (int i = 0; i < JamilStoreDataGridView.Rows.Count; i++)
            {
                FinalCostPrint = FinalCostPrint + (Convert.ToInt32(JamilStoreDataGridView.Rows[i].Cells[7].Value));
            }
            e.Graphics.DrawString("Final Amount: " + FinalCostPrint.ToString(), new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 890));
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 920));
            e.Graphics.DrawString("Amount Paid: " + AmountPaidTextBox.Text, new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 950));
            e.Graphics.DrawString("Change: " + ChangeTextBox.Text, new Font("Lucida Fax", 15, FontStyle.Bold), Brushes.Black, new Point(30, 980));

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemsForm aif = new AddItemsForm();
            aif.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void AddItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemsForm aif = new AddItemsForm();
            aif.Show();
        }

        private void EditItemsManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItemsForm eif = new EditItemsForm();
            eif.Show();
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewItemsForm vif = new ViewItemsForm();
            vif.Show();
        }

        private void detailsandSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsAndSearchForm das = new DetailsAndSearchForm();
            das.Show();
        }

        private void ItemsComboBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void JamilStoreDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                i = Convert.ToInt32(JamilStoreDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                ItemsComboBox.Text = JamilStoreDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                UnitPriceTextBox.Text = JamilStoreDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                DiscountPerItemTextBox.Text = JamilStoreDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                QuantityTextBox.Text = JamilStoreDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                SubTotalTextBox.Text = JamilStoreDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                TaxTextBox.Text = JamilStoreDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                TotalCostTextBox.Text = JamilStoreDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                QuantityTextBox.Enabled = true;
            }
            catch
            {
                MetroMessageBox.Show(this, "Select One Row At a Time...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (checkfield())
            {
                RemoveItems();
            }
        }
        private bool checkfield()
        {
            if (TotalCostTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Total cost is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                TotalCostTextBox.Focus();
                return false;
            }
            if (FinalCostTextBox.Text.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "Final cost is Required...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                FinalCostTextBox.Focus();
                return false;
            }
            return true;
        }
        private void RemoveItems()
        {
            int rowIndex = JamilStoreDataGridView.CurrentCell.RowIndex;
            JamilStoreDataGridView.Rows.RemoveAt(rowIndex);
            int TotalAmount = Convert.ToInt32(TotalCostTextBox.Text);
            FinalCost = FinalCost - TotalAmount;
            FinalCostTextBox.Text = FinalCost.ToString();
            TotalCostTextBox.Clear();
            ItemsComboBox.Text = "Select Item";
            UnitPriceTextBox.Clear();
            DiscountPerItemTextBox.Clear();
            QuantityTextBox.Clear();
            SubTotalTextBox.Clear();
            TaxTextBox.Clear();
            AmountPaidTextBox.Clear();
            ChangeTextBox.Clear();
            QuantityTextBox.Enabled = false;
        }
    }
}
