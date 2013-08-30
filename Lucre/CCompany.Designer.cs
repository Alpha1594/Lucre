namespace Lucre
{
    partial class CCompany
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBABRName = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.TBURL = new System.Windows.Forms.TextBox();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.TBNotes = new System.Windows.Forms.TextBox();
            this.LBCompanies = new System.Windows.Forms.ListBox();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.BTNWrite = new System.Windows.Forms.Button();
            this.NUProTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUProTime)).BeginInit();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(146, 12);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 0;
            this.TBName.Text = "TBName";
            // 
            // TBABRName
            // 
            this.TBABRName.Location = new System.Drawing.Point(146, 38);
            this.TBABRName.Name = "TBABRName";
            this.TBABRName.Size = new System.Drawing.Size(100, 20);
            this.TBABRName.TabIndex = 1;
            this.TBABRName.Text = "TBABRName";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(146, 91);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 2;
            this.TBEmail.Text = "TBEmail";
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(146, 117);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(100, 20);
            this.TBPhone.TabIndex = 3;
            this.TBPhone.Text = "TBPhone";
            // 
            // TBURL
            // 
            this.TBURL.Location = new System.Drawing.Point(146, 143);
            this.TBURL.Name = "TBURL";
            this.TBURL.Size = new System.Drawing.Size(100, 20);
            this.TBURL.TabIndex = 4;
            this.TBURL.Text = "TBURL";
            // 
            // TBAddress
            // 
            this.TBAddress.Location = new System.Drawing.Point(146, 169);
            this.TBAddress.Multiline = true;
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(100, 50);
            this.TBAddress.TabIndex = 5;
            this.TBAddress.Text = "TBAddress";
            // 
            // TBNotes
            // 
            this.TBNotes.Location = new System.Drawing.Point(146, 225);
            this.TBNotes.Multiline = true;
            this.TBNotes.Name = "TBNotes";
            this.TBNotes.Size = new System.Drawing.Size(100, 50);
            this.TBNotes.TabIndex = 6;
            this.TBNotes.Text = "TBNotes";
            // 
            // LBCompanies
            // 
            this.LBCompanies.FormattingEnabled = true;
            this.LBCompanies.Location = new System.Drawing.Point(0, 0);
            this.LBCompanies.Name = "LBCompanies";
            this.LBCompanies.Size = new System.Drawing.Size(120, 368);
            this.LBCompanies.TabIndex = 7;
            this.LBCompanies.SelectedIndexChanged += new System.EventHandler(this.LBCompanies_SelectedIndexChanged);
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(146, 64);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(121, 21);
            this.CBCategory.TabIndex = 8;
            // 
            // BTNWrite
            // 
            this.BTNWrite.Location = new System.Drawing.Point(251, 345);
            this.BTNWrite.Name = "BTNWrite";
            this.BTNWrite.Size = new System.Drawing.Size(75, 23);
            this.BTNWrite.TabIndex = 9;
            this.BTNWrite.Text = "BTNWrite";
            this.BTNWrite.UseVisualStyleBackColor = true;
            this.BTNWrite.Click += new System.EventHandler(this.BTNWrite_Click);
            // 
            // NUProTime
            // 
            this.NUProTime.CausesValidation = false;
            this.NUProTime.Location = new System.Drawing.Point(146, 281);
            this.NUProTime.Name = "NUProTime";
            this.NUProTime.Size = new System.Drawing.Size(120, 20);
            this.NUProTime.TabIndex = 10;
            // 
            // CCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 375);
            this.Controls.Add(this.NUProTime);
            this.Controls.Add(this.BTNWrite);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.LBCompanies);
            this.Controls.Add(this.TBNotes);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.TBURL);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBABRName);
            this.Controls.Add(this.TBName);
            this.Name = "CCompany";
            this.Text = "Company";
            ((System.ComponentModel.ISupportInitialize)(this.NUProTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBABRName;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.TextBox TBURL;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.TextBox TBNotes;
        private System.Windows.Forms.ListBox LBCompanies;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.Button BTNWrite;
        private System.Windows.Forms.NumericUpDown NUProTime;
    }
}