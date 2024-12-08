
namespace JameelStoreApp
{
    partial class AddItemsForm
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
            this.LabelTopPanel = new System.Windows.Forms.Panel();
            this.TopPanelLabelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DiscountPerItemTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.ItemIdTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelTopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTopPanel
            // 
            this.LabelTopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LabelTopPanel.Controls.Add(this.TopPanelLabelName);
            this.LabelTopPanel.Location = new System.Drawing.Point(0, 5);
            this.LabelTopPanel.Name = "LabelTopPanel";
            this.LabelTopPanel.Size = new System.Drawing.Size(800, 54);
            this.LabelTopPanel.TabIndex = 59;
            // 
            // TopPanelLabelName
            // 
            this.TopPanelLabelName.AutoSize = true;
            this.TopPanelLabelName.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanelLabelName.ForeColor = System.Drawing.Color.White;
            this.TopPanelLabelName.Location = new System.Drawing.Point(297, 8);
            this.TopPanelLabelName.Name = "TopPanelLabelName";
            this.TopPanelLabelName.Size = new System.Drawing.Size(206, 38);
            this.TopPanelLabelName.TabIndex = 0;
            this.TopPanelLabelName.Text = "ADD ITEMS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.DiscountPerItemTextBox);
            this.panel1.Controls.Add(this.UnitPriceTextBox);
            this.panel1.Controls.Add(this.ItemIdTextBox);
            this.panel1.Controls.Add(this.ItemNameTextBox);
            this.panel1.Controls.Add(this.InsertButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(162, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 281);
            this.panel1.TabIndex = 60;
            // 
            // DiscountPerItemTextBox
            // 
            this.DiscountPerItemTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountPerItemTextBox.Location = new System.Drawing.Point(193, 130);
            this.DiscountPerItemTextBox.Name = "DiscountPerItemTextBox";
            this.DiscountPerItemTextBox.Size = new System.Drawing.Size(228, 23);
            this.DiscountPerItemTextBox.TabIndex = 2;
            this.DiscountPerItemTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscountPerItemTextBox_KeyPress);
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceTextBox.Location = new System.Drawing.Point(193, 104);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(228, 23);
            this.UnitPriceTextBox.TabIndex = 1;
            this.UnitPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPriceTextBox_KeyPress);
            // 
            // ItemIdTextBox
            // 
            this.ItemIdTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIdTextBox.Location = new System.Drawing.Point(193, 51);
            this.ItemIdTextBox.Name = "ItemIdTextBox";
            this.ItemIdTextBox.Size = new System.Drawing.Size(228, 23);
            this.ItemIdTextBox.TabIndex = 0;
            this.ItemIdTextBox.Visible = false;
            this.ItemIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemNameTextBox_KeyPress);
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameTextBox.Location = new System.Drawing.Point(193, 78);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(228, 23);
            this.ItemNameTextBox.TabIndex = 0;
            this.ItemNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemNameTextBox_KeyPress);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.SeaGreen;
            this.InsertButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.Color.White;
            this.InsertButton.Location = new System.Drawing.Point(193, 158);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(228, 44);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Item Id";
            this.label1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Item Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Discount Per Item";
            // 
            // AddItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelTopPanel);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AddItemsForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "AddItemsForm";
            this.Load += new System.EventHandler(this.AddItemsForm_Load);
            this.LabelTopPanel.ResumeLayout(false);
            this.LabelTopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LabelTopPanel;
        private System.Windows.Forms.Label TopPanelLabelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox DiscountPerItemTextBox;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TextBox ItemIdTextBox;
        private System.Windows.Forms.Label label1;
    }
}