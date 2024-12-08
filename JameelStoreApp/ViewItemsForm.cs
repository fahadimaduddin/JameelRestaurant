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
    public partial class ViewItemsForm : MetroForm
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public ViewItemsForm()
        {
            InitializeComponent();
        }

        private void ViewItemsForm_Load(object sender, EventArgs e)
        {
            BindGridView();
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

        private void InsertButton_Click(object sender, EventArgs e)
        {
            AddItemsForm aif = new AddItemsForm();
            aif.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            EditItemsForm eif = new EditItemsForm();
            eif.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EditItemsForm eif = new EditItemsForm();
            eif.Show();
        }

        private void ViewItemsForm_Activated(object sender, EventArgs e)
        {
            BindGridView();
        }
    }
}
