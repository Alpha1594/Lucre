namespace Lucre
{
    partial class Inventory
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
            this.components = new System.ComponentModel.Container();
            this.LBInventory = new System.Windows.Forms.ListBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.NUCost = new System.Windows.Forms.NumericUpDown();
            this.DTPPurchasedOn = new System.Windows.Forms.DateTimePicker();
            this.ChBToInsure = new System.Windows.Forms.CheckBox();
            this.CBCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChBWarranty = new System.Windows.Forms.CheckBox();
            this.DTPWarrantyStart = new System.Windows.Forms.DateTimePicker();
            this.DTPWarrantyEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.GBWarranty = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NUQuantity = new System.Windows.Forms.NumericUpDown();
            this.ChBCostPerUnit = new System.Windows.Forms.CheckBox();
            this.BTNWrite = new System.Windows.Forms.Button();
            this.LBLTotal = new System.Windows.Forms.Label();
            this.TTAltPrice = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUCost)).BeginInit();
            this.GBWarranty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // LBInventory
            // 
            this.LBInventory.FormattingEnabled = true;
            this.LBInventory.Location = new System.Drawing.Point(0, 0);
            this.LBInventory.Name = "LBInventory";
            this.LBInventory.Size = new System.Drawing.Size(120, 251);
            this.LBInventory.TabIndex = 0;
            this.LBInventory.SelectedIndexChanged += new System.EventHandler(this.LoadItem);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(182, 0);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 1;
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(182, 132);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(121, 21);
            this.CBCategory.TabIndex = 2;
            // 
            // NUCost
            // 
            this.NUCost.DecimalPlaces = 2;
            this.NUCost.Location = new System.Drawing.Point(182, 26);
            this.NUCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUCost.Name = "NUCost";
            this.NUCost.Size = new System.Drawing.Size(120, 20);
            this.NUCost.TabIndex = 3;
            this.NUCost.ThousandsSeparator = true;
            this.NUCost.ValueChanged += new System.EventHandler(this.ChBCostPerUnit_CheckedChanged);
            // 
            // DTPPurchasedOn
            // 
            this.DTPPurchasedOn.Location = new System.Drawing.Point(182, 79);
            this.DTPPurchasedOn.Name = "DTPPurchasedOn";
            this.DTPPurchasedOn.Size = new System.Drawing.Size(120, 20);
            this.DTPPurchasedOn.TabIndex = 4;
            // 
            // ChBToInsure
            // 
            this.ChBToInsure.AutoSize = true;
            this.ChBToInsure.Location = new System.Drawing.Point(240, 157);
            this.ChBToInsure.Name = "ChBToInsure";
            this.ChBToInsure.Size = new System.Drawing.Size(77, 17);
            this.ChBToInsure.TabIndex = 5;
            this.ChBToInsure.Text = "To Insure?";
            this.ChBToInsure.UseVisualStyleBackColor = true;
            // 
            // CBCompany
            // 
            this.CBCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBCompany.FormattingEnabled = true;
            this.CBCompany.Location = new System.Drawing.Point(181, 105);
            this.CBCompany.Name = "CBCompany";
            this.CBCompany.Size = new System.Drawing.Size(121, 21);
            this.CBCompany.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Purchased";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Company";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start";
            // 
            // ChBWarranty
            // 
            this.ChBWarranty.AutoSize = true;
            this.ChBWarranty.Location = new System.Drawing.Point(127, 157);
            this.ChBWarranty.Name = "ChBWarranty";
            this.ChBWarranty.Size = new System.Drawing.Size(97, 17);
            this.ChBWarranty.TabIndex = 13;
            this.ChBWarranty.Text = "Has Warranty?";
            this.ChBWarranty.UseVisualStyleBackColor = true;
            this.ChBWarranty.CheckedChanged += new System.EventHandler(this.ChBWarranty_CheckedChanged);
            // 
            // DTPWarrantyStart
            // 
            this.DTPWarrantyStart.Location = new System.Drawing.Point(56, 19);
            this.DTPWarrantyStart.Name = "DTPWarrantyStart";
            this.DTPWarrantyStart.Size = new System.Drawing.Size(120, 20);
            this.DTPWarrantyStart.TabIndex = 14;
            // 
            // DTPWarrantyEnd
            // 
            this.DTPWarrantyEnd.Location = new System.Drawing.Point(55, 45);
            this.DTPWarrantyEnd.Name = "DTPWarrantyEnd";
            this.DTPWarrantyEnd.Size = new System.Drawing.Size(121, 20);
            this.DTPWarrantyEnd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "End";
            // 
            // GBWarranty
            // 
            this.GBWarranty.Controls.Add(this.label7);
            this.GBWarranty.Controls.Add(this.label6);
            this.GBWarranty.Controls.Add(this.DTPWarrantyEnd);
            this.GBWarranty.Controls.Add(this.DTPWarrantyStart);
            this.GBWarranty.Enabled = false;
            this.GBWarranty.Location = new System.Drawing.Point(127, 180);
            this.GBWarranty.Name = "GBWarranty";
            this.GBWarranty.Size = new System.Drawing.Size(181, 71);
            this.GBWarranty.TabIndex = 17;
            this.GBWarranty.TabStop = false;
            this.GBWarranty.Text = "Warranty";
            this.GBWarranty.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantity";
            // 
            // NUQuantity
            // 
            this.NUQuantity.Location = new System.Drawing.Point(182, 48);
            this.NUQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUQuantity.Name = "NUQuantity";
            this.NUQuantity.Size = new System.Drawing.Size(120, 20);
            this.NUQuantity.TabIndex = 19;
            this.NUQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUQuantity.ValueChanged += new System.EventHandler(this.NUQuantity_ValueChanged);
            // 
            // ChBCostPerUnit
            // 
            this.ChBCostPerUnit.AutoSize = true;
            this.ChBCostPerUnit.Enabled = false;
            this.ChBCostPerUnit.Location = new System.Drawing.Point(222, 49);
            this.ChBCostPerUnit.Name = "ChBCostPerUnit";
            this.ChBCostPerUnit.Size = new System.Drawing.Size(86, 17);
            this.ChBCostPerUnit.TabIndex = 20;
            this.ChBCostPerUnit.Text = "CostPerUnt?";
            this.ChBCostPerUnit.UseVisualStyleBackColor = true;
            this.ChBCostPerUnit.Visible = false;
            this.ChBCostPerUnit.CheckedChanged += new System.EventHandler(this.ChBCostPerUnit_CheckedChanged);
            this.ChBCostPerUnit.Click += new System.EventHandler(this.ChBCostPerUnit_CheckedChanged);
            // 
            // BTNWrite
            // 
            this.BTNWrite.Location = new System.Drawing.Point(227, 257);
            this.BTNWrite.Name = "BTNWrite";
            this.BTNWrite.Size = new System.Drawing.Size(75, 23);
            this.BTNWrite.TabIndex = 21;
            this.BTNWrite.Text = "Save";
            this.BTNWrite.UseVisualStyleBackColor = true;
            this.BTNWrite.Click += new System.EventHandler(this.BTNWrite_Click);
            // 
            // LBLTotal
            // 
            this.LBLTotal.AutoSize = true;
            this.LBLTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTotal.Location = new System.Drawing.Point(12, 257);
            this.LBLTotal.Name = "LBLTotal";
            this.LBLTotal.Size = new System.Drawing.Size(56, 15);
            this.LBLTotal.TabIndex = 22;
            this.LBLTotal.Text = "LBLTotal";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 283);
            this.Controls.Add(this.LBLTotal);
            this.Controls.Add(this.BTNWrite);
            this.Controls.Add(this.ChBCostPerUnit);
            this.Controls.Add(this.NUQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChBWarranty);
            this.Controls.Add(this.GBWarranty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBCompany);
            this.Controls.Add(this.ChBToInsure);
            this.Controls.Add(this.DTPPurchasedOn);
            this.Controls.Add(this.NUCost);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LBInventory);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.NUCost)).EndInit();
            this.GBWarranty.ResumeLayout(false);
            this.GBWarranty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBInventory;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.NumericUpDown NUCost;
        private System.Windows.Forms.DateTimePicker DTPPurchasedOn;
        private System.Windows.Forms.CheckBox ChBToInsure;
        private System.Windows.Forms.ComboBox CBCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChBWarranty;
        private System.Windows.Forms.DateTimePicker DTPWarrantyStart;
        private System.Windows.Forms.DateTimePicker DTPWarrantyEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GBWarranty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUQuantity;
        private System.Windows.Forms.CheckBox ChBCostPerUnit;
        private System.Windows.Forms.Button BTNWrite;
        private System.Windows.Forms.Label LBLTotal;
        private System.Windows.Forms.ToolTip TTAltPrice;
    }
}