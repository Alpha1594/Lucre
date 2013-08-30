namespace Lucre
{
    partial class TransEdit
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
            this.LBLName = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LBLCompany = new System.Windows.Forms.Label();
            this.CBCompany = new System.Windows.Forms.ComboBox();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.LBLCategory = new System.Windows.Forms.Label();
            this.LBLPaymentInfo = new System.Windows.Forms.Label();
            this.NUPredicted = new System.Windows.Forms.NumericUpDown();
            this.DTPPredicted = new System.Windows.Forms.DateTimePicker();
            this.LBLPredicted = new System.Windows.Forms.Label();
            this.LBLReal = new System.Windows.Forms.Label();
            this.DTPReal = new System.Windows.Forms.DateTimePicker();
            this.NUReal = new System.Windows.Forms.NumericUpDown();
            this.ChBTransactionCompleted = new System.Windows.Forms.CheckBox();
            this.GBRepeatTransaction = new System.Windows.Forms.GroupBox();
            this.CBRepeatFreq = new System.Windows.Forms.ComboBox();
            this.ChBRepeatActive = new System.Windows.Forms.CheckBox();
            this.DTPEnd = new System.Windows.Forms.DateTimePicker();
            this.LBLEnd = new System.Windows.Forms.Label();
            this.DTPStart = new System.Windows.Forms.DateTimePicker();
            this.LBLStart = new System.Windows.Forms.Label();
            this.ChBRepeatTransaction = new System.Windows.Forms.CheckBox();
            this.TBNotes = new System.Windows.Forms.TextBox();
            this.BTNWriteData = new System.Windows.Forms.Button();
            this.BTNReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUPredicted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUReal)).BeginInit();
            this.GBRepeatTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Location = new System.Drawing.Point(12, 9);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(35, 13);
            this.LBLName.TabIndex = 0;
            this.LBLName.Text = "Name";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(69, 4);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 1;
            // 
            // LBLCompany
            // 
            this.LBLCompany.AutoSize = true;
            this.LBLCompany.Location = new System.Drawing.Point(12, 33);
            this.LBLCompany.Name = "LBLCompany";
            this.LBLCompany.Size = new System.Drawing.Size(51, 13);
            this.LBLCompany.TabIndex = 2;
            this.LBLCompany.Text = "Company";
            // 
            // CBCompany
            // 
            this.CBCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBCompany.FormattingEnabled = true;
            this.CBCompany.Location = new System.Drawing.Point(69, 30);
            this.CBCompany.Name = "CBCompany";
            this.CBCompany.Size = new System.Drawing.Size(121, 21);
            this.CBCompany.TabIndex = 3;
            this.CBCompany.SelectedIndexChanged += new System.EventHandler(this.CompanyChanged);
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(253, 30);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(121, 21);
            this.CBCategory.TabIndex = 5;
            // 
            // LBLCategory
            // 
            this.LBLCategory.AutoSize = true;
            this.LBLCategory.Location = new System.Drawing.Point(196, 33);
            this.LBLCategory.Name = "LBLCategory";
            this.LBLCategory.Size = new System.Drawing.Size(49, 13);
            this.LBLCategory.TabIndex = 4;
            this.LBLCategory.Text = "Category";
            // 
            // LBLPaymentInfo
            // 
            this.LBLPaymentInfo.AutoSize = true;
            this.LBLPaymentInfo.Location = new System.Drawing.Point(12, 59);
            this.LBLPaymentInfo.Name = "LBLPaymentInfo";
            this.LBLPaymentInfo.Size = new System.Drawing.Size(69, 13);
            this.LBLPaymentInfo.TabIndex = 6;
            this.LBLPaymentInfo.Text = "Payment Info";
            // 
            // NUPredicted
            // 
            this.NUPredicted.DecimalPlaces = 2;
            this.NUPredicted.Location = new System.Drawing.Point(69, 75);
            this.NUPredicted.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUPredicted.Name = "NUPredicted";
            this.NUPredicted.Size = new System.Drawing.Size(120, 20);
            this.NUPredicted.TabIndex = 7;
            this.NUPredicted.ThousandsSeparator = true;
            // 
            // DTPPredicted
            // 
            this.DTPPredicted.Location = new System.Drawing.Point(253, 75);
            this.DTPPredicted.Name = "DTPPredicted";
            this.DTPPredicted.Size = new System.Drawing.Size(121, 20);
            this.DTPPredicted.TabIndex = 8;
            // 
            // LBLPredicted
            // 
            this.LBLPredicted.AutoSize = true;
            this.LBLPredicted.Location = new System.Drawing.Point(12, 77);
            this.LBLPredicted.Name = "LBLPredicted";
            this.LBLPredicted.Size = new System.Drawing.Size(52, 13);
            this.LBLPredicted.TabIndex = 9;
            this.LBLPredicted.Text = "Predicted";
            // 
            // LBLReal
            // 
            this.LBLReal.AutoSize = true;
            this.LBLReal.Location = new System.Drawing.Point(12, 103);
            this.LBLReal.Name = "LBLReal";
            this.LBLReal.Size = new System.Drawing.Size(29, 13);
            this.LBLReal.TabIndex = 12;
            this.LBLReal.Text = "Real";
            // 
            // DTPReal
            // 
            this.DTPReal.Enabled = false;
            this.DTPReal.Location = new System.Drawing.Point(253, 101);
            this.DTPReal.Name = "DTPReal";
            this.DTPReal.Size = new System.Drawing.Size(121, 20);
            this.DTPReal.TabIndex = 11;
            // 
            // NUReal
            // 
            this.NUReal.DecimalPlaces = 2;
            this.NUReal.Enabled = false;
            this.NUReal.Location = new System.Drawing.Point(69, 101);
            this.NUReal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUReal.Name = "NUReal";
            this.NUReal.Size = new System.Drawing.Size(120, 20);
            this.NUReal.TabIndex = 10;
            this.NUReal.ThousandsSeparator = true;
            this.NUReal.ValueChanged += new System.EventHandler(this.NURealValChanged);
            // 
            // ChBTransactionCompleted
            // 
            this.ChBTransactionCompleted.AutoSize = true;
            this.ChBTransactionCompleted.Location = new System.Drawing.Point(15, 127);
            this.ChBTransactionCompleted.Name = "ChBTransactionCompleted";
            this.ChBTransactionCompleted.Size = new System.Drawing.Size(141, 17);
            this.ChBTransactionCompleted.TabIndex = 13;
            this.ChBTransactionCompleted.Text = "Transaction Completed?";
            this.ChBTransactionCompleted.UseVisualStyleBackColor = true;
            this.ChBTransactionCompleted.CheckedChanged += new System.EventHandler(this.ChBTransactionCompleted_CheckedChanged);
            // 
            // GBRepeatTransaction
            // 
            this.GBRepeatTransaction.Controls.Add(this.CBRepeatFreq);
            this.GBRepeatTransaction.Controls.Add(this.ChBRepeatActive);
            this.GBRepeatTransaction.Controls.Add(this.DTPEnd);
            this.GBRepeatTransaction.Controls.Add(this.LBLEnd);
            this.GBRepeatTransaction.Controls.Add(this.DTPStart);
            this.GBRepeatTransaction.Controls.Add(this.LBLStart);
            this.GBRepeatTransaction.Location = new System.Drawing.Point(15, 150);
            this.GBRepeatTransaction.Name = "GBRepeatTransaction";
            this.GBRepeatTransaction.Size = new System.Drawing.Size(359, 67);
            this.GBRepeatTransaction.TabIndex = 14;
            this.GBRepeatTransaction.TabStop = false;
            this.GBRepeatTransaction.Text = "Repeat Transaction";
            // 
            // CBRepeatFreq
            // 
            this.CBRepeatFreq.FormattingEnabled = true;
            this.CBRepeatFreq.Location = new System.Drawing.Point(238, 41);
            this.CBRepeatFreq.Name = "CBRepeatFreq";
            this.CBRepeatFreq.Size = new System.Drawing.Size(121, 21);
            this.CBRepeatFreq.TabIndex = 5;
            // 
            // ChBRepeatActive
            // 
            this.ChBRepeatActive.AutoSize = true;
            this.ChBRepeatActive.Location = new System.Drawing.Point(238, 18);
            this.ChBRepeatActive.Name = "ChBRepeatActive";
            this.ChBRepeatActive.Size = new System.Drawing.Size(100, 17);
            this.ChBRepeatActive.TabIndex = 4;
            this.ChBRepeatActive.Text = "Repeat Active?";
            this.ChBRepeatActive.UseVisualStyleBackColor = true;
            // 
            // DTPEnd
            // 
            this.DTPEnd.Location = new System.Drawing.Point(54, 42);
            this.DTPEnd.Name = "DTPEnd";
            this.DTPEnd.Size = new System.Drawing.Size(121, 20);
            this.DTPEnd.TabIndex = 3;
            // 
            // LBLEnd
            // 
            this.LBLEnd.AutoSize = true;
            this.LBLEnd.Location = new System.Drawing.Point(6, 48);
            this.LBLEnd.Name = "LBLEnd";
            this.LBLEnd.Size = new System.Drawing.Size(26, 13);
            this.LBLEnd.TabIndex = 2;
            this.LBLEnd.Text = "End";
            // 
            // DTPStart
            // 
            this.DTPStart.Location = new System.Drawing.Point(54, 16);
            this.DTPStart.Name = "DTPStart";
            this.DTPStart.Size = new System.Drawing.Size(121, 20);
            this.DTPStart.TabIndex = 1;
            // 
            // LBLStart
            // 
            this.LBLStart.AutoSize = true;
            this.LBLStart.Location = new System.Drawing.Point(6, 22);
            this.LBLStart.Name = "LBLStart";
            this.LBLStart.Size = new System.Drawing.Size(29, 13);
            this.LBLStart.TabIndex = 0;
            this.LBLStart.Text = "Start";
            // 
            // ChBRepeatTransaction
            // 
            this.ChBRepeatTransaction.AutoSize = true;
            this.ChBRepeatTransaction.Location = new System.Drawing.Point(253, 127);
            this.ChBRepeatTransaction.Name = "ChBRepeatTransaction";
            this.ChBRepeatTransaction.Size = new System.Drawing.Size(126, 17);
            this.ChBRepeatTransaction.TabIndex = 15;
            this.ChBRepeatTransaction.Text = "Repeat Transaction?";
            this.ChBRepeatTransaction.UseVisualStyleBackColor = true;
            this.ChBRepeatTransaction.CheckedChanged += new System.EventHandler(this.CBRepeatTransaction_CheckedChanged);
            // 
            // TBNotes
            // 
            this.TBNotes.Location = new System.Drawing.Point(15, 223);
            this.TBNotes.Multiline = true;
            this.TBNotes.Name = "TBNotes";
            this.TBNotes.Size = new System.Drawing.Size(359, 81);
            this.TBNotes.TabIndex = 16;
            // 
            // BTNWriteData
            // 
            this.BTNWriteData.Location = new System.Drawing.Point(299, 310);
            this.BTNWriteData.Name = "BTNWriteData";
            this.BTNWriteData.Size = new System.Drawing.Size(75, 23);
            this.BTNWriteData.TabIndex = 17;
            this.BTNWriteData.Text = "Save";
            this.BTNWriteData.UseVisualStyleBackColor = true;
            this.BTNWriteData.Click += new System.EventHandler(this.BTNWriteData_Click);
            // 
            // BTNReset
            // 
            this.BTNReset.Location = new System.Drawing.Point(15, 310);
            this.BTNReset.Name = "BTNReset";
            this.BTNReset.Size = new System.Drawing.Size(75, 23);
            this.BTNReset.TabIndex = 18;
            this.BTNReset.Text = "Reset";
            this.BTNReset.UseVisualStyleBackColor = true;
            // 
            // TransEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 340);
            this.Controls.Add(this.BTNReset);
            this.Controls.Add(this.BTNWriteData);
            this.Controls.Add(this.TBNotes);
            this.Controls.Add(this.ChBRepeatTransaction);
            this.Controls.Add(this.GBRepeatTransaction);
            this.Controls.Add(this.ChBTransactionCompleted);
            this.Controls.Add(this.LBLReal);
            this.Controls.Add(this.DTPReal);
            this.Controls.Add(this.NUReal);
            this.Controls.Add(this.LBLPredicted);
            this.Controls.Add(this.DTPPredicted);
            this.Controls.Add(this.NUPredicted);
            this.Controls.Add(this.LBLPaymentInfo);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.LBLCategory);
            this.Controls.Add(this.CBCompany);
            this.Controls.Add(this.LBLCompany);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LBLName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TransEdit";
            this.Text = "Transaction Editor";
            ((System.ComponentModel.ISupportInitialize)(this.NUPredicted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUReal)).EndInit();
            this.GBRepeatTransaction.ResumeLayout(false);
            this.GBRepeatTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LBLCompany;
        private System.Windows.Forms.ComboBox CBCompany;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.Label LBLCategory;
        private System.Windows.Forms.Label LBLPaymentInfo;
        private System.Windows.Forms.NumericUpDown NUPredicted;
        private System.Windows.Forms.DateTimePicker DTPPredicted;
        private System.Windows.Forms.Label LBLPredicted;
        private System.Windows.Forms.Label LBLReal;
        private System.Windows.Forms.DateTimePicker DTPReal;
        private System.Windows.Forms.NumericUpDown NUReal;
        private System.Windows.Forms.CheckBox ChBTransactionCompleted;
        private System.Windows.Forms.GroupBox GBRepeatTransaction;
        private System.Windows.Forms.DateTimePicker DTPStart;
        private System.Windows.Forms.Label LBLStart;
        private System.Windows.Forms.CheckBox ChBRepeatTransaction;
        private System.Windows.Forms.DateTimePicker DTPEnd;
        private System.Windows.Forms.Label LBLEnd;
        private System.Windows.Forms.ComboBox CBRepeatFreq;
        private System.Windows.Forms.CheckBox ChBRepeatActive;
        private System.Windows.Forms.TextBox TBNotes;
        private System.Windows.Forms.Button BTNWriteData;
        private System.Windows.Forms.Button BTNReset;
    }
}