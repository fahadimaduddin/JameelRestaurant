
namespace JameelStoreApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.JamilStoreDataGridView = new System.Windows.Forms.DataGridView();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemsComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountPaidTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinalCostTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalCostTextBox = new System.Windows.Forms.TextBox();
            this.DiscountPerItemTextBox = new System.Windows.Forms.TextBox();
            this.InvoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTopPanel = new System.Windows.Forms.Panel();
            this.TopPanelLabelName = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrintPreviewButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditItemsManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsandSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JamilStoreDataGridView)).BeginInit();
            this.LabelTopPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // JamilStoreDataGridView
            // 
            this.JamilStoreDataGridView.AllowUserToAddRows = false;
            this.JamilStoreDataGridView.AllowUserToDeleteRows = false;
            this.JamilStoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JamilStoreDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.JamilStoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JamilStoreDataGridView.Location = new System.Drawing.Point(0, 295);
            this.JamilStoreDataGridView.Name = "JamilStoreDataGridView";
            this.JamilStoreDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JamilStoreDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.JamilStoreDataGridView.Size = new System.Drawing.Size(1366, 444);
            this.JamilStoreDataGridView.TabIndex = 0;
            this.JamilStoreDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.JamilStoreDataGridView_MouseDoubleClick);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ResetButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(876, 239);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(87, 44);
            this.ResetButton.TabIndex = 40;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Blue;
            this.AddButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(404, 239);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 44);
            this.AddButton.TabIndex = 39;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemsComboBox
            // 
            this.ItemsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemsComboBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsComboBox.FormattingEnabled = true;
            this.ItemsComboBox.Location = new System.Drawing.Point(246, 180);
            this.ItemsComboBox.Name = "ItemsComboBox";
            this.ItemsComboBox.Size = new System.Drawing.Size(228, 23);
            this.ItemsComboBox.TabIndex = 20;
            this.ItemsComboBox.Text = "Select Item";
            this.ItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemsComboBox_SelectedIndexChanged);
            this.ItemsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsComboBox_KeyPress);
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTextBox.Location = new System.Drawing.Point(979, 204);
            this.ChangeTextBox.Multiline = true;
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.ReadOnly = true;
            this.ChangeTextBox.Size = new System.Drawing.Size(228, 21);
            this.ChangeTextBox.TabIndex = 38;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTextBox.Location = new System.Drawing.Point(632, 204);
            this.TaxTextBox.Multiline = true;
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(228, 21);
            this.TaxTextBox.TabIndex = 34;
            this.TaxTextBox.TextChanged += new System.EventHandler(this.TaxTextBox_TextChanged);
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceTextBox.Location = new System.Drawing.Point(246, 205);
            this.UnitPriceTextBox.Multiline = true;
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.ReadOnly = true;
            this.UnitPriceTextBox.Size = new System.Drawing.Size(228, 21);
            this.UnitPriceTextBox.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(878, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "Change";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(494, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Unit Price";
            // 
            // AmountPaidTextBox
            // 
            this.AmountPaidTextBox.Enabled = false;
            this.AmountPaidTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidTextBox.Location = new System.Drawing.Point(979, 180);
            this.AmountPaidTextBox.Multiline = true;
            this.AmountPaidTextBox.Name = "AmountPaidTextBox";
            this.AmountPaidTextBox.Size = new System.Drawing.Size(228, 21);
            this.AmountPaidTextBox.TabIndex = 37;
            this.AmountPaidTextBox.TextChanged += new System.EventHandler(this.AmountPaidTextBox_TextChanged);
            this.AmountPaidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountPaidTextBox_KeyPress);
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTextBox.Location = new System.Drawing.Point(632, 180);
            this.SubTotalTextBox.Multiline = true;
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(228, 21);
            this.SubTotalTextBox.TabIndex = 30;
            this.SubTotalTextBox.TextChanged += new System.EventHandler(this.SubTotalTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(878, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Amount Paid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sub Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select Item";
            // 
            // FinalCostTextBox
            // 
            this.FinalCostTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCostTextBox.Location = new System.Drawing.Point(979, 156);
            this.FinalCostTextBox.Multiline = true;
            this.FinalCostTextBox.Name = "FinalCostTextBox";
            this.FinalCostTextBox.ReadOnly = true;
            this.FinalCostTextBox.Size = new System.Drawing.Size(228, 21);
            this.FinalCostTextBox.TabIndex = 36;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Enabled = false;
            this.QuantityTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(632, 156);
            this.QuantityTextBox.MaxLength = 2;
            this.QuantityTextBox.Multiline = true;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(228, 21);
            this.QuantityTextBox.TabIndex = 26;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            this.QuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(246, 157);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(228, 21);
            this.NameTextBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(878, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Final Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // TotalCostTextBox
            // 
            this.TotalCostTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostTextBox.Location = new System.Drawing.Point(979, 132);
            this.TotalCostTextBox.Multiline = true;
            this.TotalCostTextBox.Name = "TotalCostTextBox";
            this.TotalCostTextBox.ReadOnly = true;
            this.TotalCostTextBox.Size = new System.Drawing.Size(228, 21);
            this.TotalCostTextBox.TabIndex = 35;
            // 
            // DiscountPerItemTextBox
            // 
            this.DiscountPerItemTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountPerItemTextBox.Location = new System.Drawing.Point(632, 132);
            this.DiscountPerItemTextBox.Multiline = true;
            this.DiscountPerItemTextBox.Name = "DiscountPerItemTextBox";
            this.DiscountPerItemTextBox.ReadOnly = true;
            this.DiscountPerItemTextBox.Size = new System.Drawing.Size(228, 21);
            this.DiscountPerItemTextBox.TabIndex = 25;
            // 
            // InvoiceNoTextBox
            // 
            this.InvoiceNoTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNoTextBox.Location = new System.Drawing.Point(246, 134);
            this.InvoiceNoTextBox.Multiline = true;
            this.InvoiceNoTextBox.Name = "InvoiceNoTextBox";
            this.InvoiceNoTextBox.ReadOnly = true;
            this.InvoiceNoTextBox.Size = new System.Drawing.Size(228, 21);
            this.InvoiceNoTextBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(878, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Discount Per Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Invoice No";
            // 
            // LabelTopPanel
            // 
            this.LabelTopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LabelTopPanel.Controls.Add(this.TopPanelLabelName);
            this.LabelTopPanel.Location = new System.Drawing.Point(-4, 57);
            this.LabelTopPanel.Name = "LabelTopPanel";
            this.LabelTopPanel.Size = new System.Drawing.Size(1371, 54);
            this.LabelTopPanel.TabIndex = 58;
            // 
            // TopPanelLabelName
            // 
            this.TopPanelLabelName.AutoSize = true;
            this.TopPanelLabelName.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanelLabelName.ForeColor = System.Drawing.Color.White;
            this.TopPanelLabelName.Location = new System.Drawing.Point(557, 8);
            this.TopPanelLabelName.Name = "TopPanelLabelName";
            this.TopPanelLabelName.Size = new System.Drawing.Size(256, 38);
            this.TopPanelLabelName.TabIndex = 0;
            this.TopPanelLabelName.Text = "BBQ TONIGHT";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.Green;
            this.InsertButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.Color.White;
            this.InsertButton.Location = new System.Drawing.Point(504, 239);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(87, 44);
            this.InsertButton.TabIndex = 39;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PrintButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(783, 239);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(87, 44);
            this.PrintButton.TabIndex = 60;
            this.PrintButton.Text = "PRINT";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PrintPreviewButton
            // 
            this.PrintPreviewButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PrintPreviewButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewButton.ForeColor = System.Drawing.Color.White;
            this.PrintPreviewButton.Location = new System.Drawing.Point(690, 239);
            this.PrintPreviewButton.Name = "PrintPreviewButton";
            this.PrintPreviewButton.Size = new System.Drawing.Size(87, 44);
            this.PrintPreviewButton.TabIndex = 59;
            this.PrintPreviewButton.Text = "PRINT PREVIEW";
            this.PrintPreviewButton.UseVisualStyleBackColor = false;
            this.PrintPreviewButton.Click += new System.EventHandler(this.PrintPreviewButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem2,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem1,
            this.aboutToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(20, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1326, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // AddItemsToolStripMenuItem
            // 
            this.AddItemsToolStripMenuItem.Name = "AddItemsToolStripMenuItem";
            this.AddItemsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AddItemsToolStripMenuItem.Text = "Add Items";
            this.AddItemsToolStripMenuItem.Click += new System.EventHandler(this.AddItemsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditItemsManagerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.helpToolStripMenuItem.Text = "Edit";
            // 
            // EditItemsManagerToolStripMenuItem
            // 
            this.EditItemsManagerToolStripMenuItem.Name = "EditItemsManagerToolStripMenuItem";
            this.EditItemsManagerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.EditItemsManagerToolStripMenuItem.Text = "Edit Items";
            this.EditItemsManagerToolStripMenuItem.Click += new System.EventHandler(this.EditItemsManagerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewItemsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewItemsToolStripMenuItem
            // 
            this.viewItemsToolStripMenuItem.Name = "viewItemsToolStripMenuItem";
            this.viewItemsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.viewItemsToolStripMenuItem.Text = "View Items";
            this.viewItemsToolStripMenuItem.Click += new System.EventHandler(this.viewItemsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(22, 20);
            this.aboutToolStripMenuItem.Text = "|";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsandSearchToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem3.Text = "Details";
            // 
            // detailsandSearchToolStripMenuItem
            // 
            this.detailsandSearchToolStripMenuItem.Name = "detailsandSearchToolStripMenuItem";
            this.detailsandSearchToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.detailsandSearchToolStripMenuItem.Text = "Details &and Search";
            this.detailsandSearchToolStripMenuItem.Click += new System.EventHandler(this.detailsandSearchToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Enabled = false;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.aboutToolStripMenuItem1.Text = "|";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem2.Text = "About";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.OrangeRed;
            this.RemoveButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(597, 239);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(87, 44);
            this.RemoveButton.TabIndex = 62;
            this.RemoveButton.Text = "REMOVE";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 739);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.PrintPreviewButton);
            this.Controls.Add(this.LabelTopPanel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ItemsComboBox);
            this.Controls.Add(this.ChangeTextBox);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountPaidTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FinalCostTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalCostTextBox);
            this.Controls.Add(this.DiscountPerItemTextBox);
            this.Controls.Add(this.InvoiceNoTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JamilStoreDataGridView);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Dashboard Screen";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JamilStoreDataGridView)).EndInit();
            this.LabelTopPanel.ResumeLayout(false);
            this.LabelTopPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JamilStoreDataGridView;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox ItemsComboBox;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountPaidTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FinalCostTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalCostTextBox;
        private System.Windows.Forms.TextBox DiscountPerItemTextBox;
        private System.Windows.Forms.TextBox InvoiceNoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LabelTopPanel;
        private System.Windows.Forms.Label TopPanelLabelName;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button PrintPreviewButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditItemsManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem detailsandSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Button RemoveButton;
    }
}