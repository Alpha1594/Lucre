namespace Lucre
{
    partial class FinanceRC
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
            this.NUYear = new System.Windows.Forms.NumericUpDown();
            this.BTNAddYear = new System.Windows.Forms.Button();
            this.BTNWriteRC = new System.Windows.Forms.Button();
            this.LBLTerm1 = new System.Windows.Forms.Label();
            this.LBLTerm1Start = new System.Windows.Forms.Label();
            this.DTPTerm1Start = new System.Windows.Forms.DateTimePicker();
            this.LBLTerm1End = new System.Windows.Forms.Label();
            this.DTPTerm1End = new System.Windows.Forms.DateTimePicker();
            this.NUTerm1Loan = new System.Windows.Forms.NumericUpDown();
            this.LBLTerm1Loan = new System.Windows.Forms.Label();
            this.NUTerm1Grant = new System.Windows.Forms.NumericUpDown();
            this.LBLTerm1Grant = new System.Windows.Forms.Label();
            this.DTPSF1Payment = new System.Windows.Forms.DateTimePicker();
            this.LBLSF1Payment = new System.Windows.Forms.Label();
            this.LBL1Bursary = new System.Windows.Forms.Label();
            this.NU1Bursary = new System.Windows.Forms.NumericUpDown();
            this.DTP1Bursary = new System.Windows.Forms.DateTimePicker();
            this.DTP2Bursary = new System.Windows.Forms.DateTimePicker();
            this.NU2Bursary = new System.Windows.Forms.NumericUpDown();
            this.LBL2Bursary = new System.Windows.Forms.Label();
            this.LBLSF2Payment = new System.Windows.Forms.Label();
            this.DTPSF2Payment = new System.Windows.Forms.DateTimePicker();
            this.LBLTerm2Grant = new System.Windows.Forms.Label();
            this.NUTerm2Grant = new System.Windows.Forms.NumericUpDown();
            this.LBLTerm2Loan = new System.Windows.Forms.Label();
            this.NUTerm2Loan = new System.Windows.Forms.NumericUpDown();
            this.DTPTerm2End = new System.Windows.Forms.DateTimePicker();
            this.LBLTerm2End = new System.Windows.Forms.Label();
            this.DTPTerm2Start = new System.Windows.Forms.DateTimePicker();
            this.LBLTerm2Start = new System.Windows.Forms.Label();
            this.LBLTerm2 = new System.Windows.Forms.Label();
            this.DTP3Bursary = new System.Windows.Forms.DateTimePicker();
            this.NU3Bursary = new System.Windows.Forms.NumericUpDown();
            this.LBL3Bursary = new System.Windows.Forms.Label();
            this.LBLSF3Payment = new System.Windows.Forms.Label();
            this.DTPSF3Payment = new System.Windows.Forms.DateTimePicker();
            this.LBLTerm3Grant = new System.Windows.Forms.Label();
            this.NUTerm3Grant = new System.Windows.Forms.NumericUpDown();
            this.LBLTerm3Loan = new System.Windows.Forms.Label();
            this.NUTerm3Loan = new System.Windows.Forms.NumericUpDown();
            this.DTPTerm3End = new System.Windows.Forms.DateTimePicker();
            this.LBLTerm3End = new System.Windows.Forms.Label();
            this.DTPTerm3Start = new System.Windows.Forms.DateTimePicker();
            this.LBLTerm3Start = new System.Windows.Forms.Label();
            this.LBLTerm3 = new System.Windows.Forms.Label();
            this.CBYearIndustry = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm1Loan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm1Grant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU1Bursary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU2Bursary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm2Grant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm2Loan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU3Bursary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm3Grant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm3Loan)).BeginInit();
            this.SuspendLayout();
            // 
            // NUYear
            // 
            this.NUYear.Location = new System.Drawing.Point(12, 363);
            this.NUYear.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUYear.Name = "NUYear";
            this.NUYear.Size = new System.Drawing.Size(120, 20);
            this.NUYear.TabIndex = 0;
            this.NUYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUYear.ValueChanged += new System.EventHandler(this.NUYear_ValueChanged);
            // 
            // BTNAddYear
            // 
            this.BTNAddYear.Location = new System.Drawing.Point(138, 360);
            this.BTNAddYear.Name = "BTNAddYear";
            this.BTNAddYear.Size = new System.Drawing.Size(75, 23);
            this.BTNAddYear.TabIndex = 1;
            this.BTNAddYear.Text = "BTNAddYear";
            this.BTNAddYear.UseVisualStyleBackColor = true;
            // 
            // BTNWriteRC
            // 
            this.BTNWriteRC.Location = new System.Drawing.Point(219, 360);
            this.BTNWriteRC.Name = "BTNWriteRC";
            this.BTNWriteRC.Size = new System.Drawing.Size(75, 23);
            this.BTNWriteRC.TabIndex = 2;
            this.BTNWriteRC.Text = "BTNWriteRC";
            this.BTNWriteRC.UseVisualStyleBackColor = true;
            this.BTNWriteRC.Click += new System.EventHandler(this.BTNWriteRC_Click);
            // 
            // LBLTerm1
            // 
            this.LBLTerm1.AutoSize = true;
            this.LBLTerm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTerm1.Location = new System.Drawing.Point(9, 9);
            this.LBLTerm1.Name = "LBLTerm1";
            this.LBLTerm1.Size = new System.Drawing.Size(42, 13);
            this.LBLTerm1.TabIndex = 3;
            this.LBLTerm1.Text = "Term1";
            // 
            // LBLTerm1Start
            // 
            this.LBLTerm1Start.AutoSize = true;
            this.LBLTerm1Start.Location = new System.Drawing.Point(52, 9);
            this.LBLTerm1Start.Name = "LBLTerm1Start";
            this.LBLTerm1Start.Size = new System.Drawing.Size(29, 13);
            this.LBLTerm1Start.TabIndex = 4;
            this.LBLTerm1Start.Text = "Start";
            // 
            // DTPTerm1Start
            // 
            this.DTPTerm1Start.Location = new System.Drawing.Point(87, 3);
            this.DTPTerm1Start.Name = "DTPTerm1Start";
            this.DTPTerm1Start.Size = new System.Drawing.Size(118, 20);
            this.DTPTerm1Start.TabIndex = 5;
            // 
            // LBLTerm1End
            // 
            this.LBLTerm1End.AutoSize = true;
            this.LBLTerm1End.Location = new System.Drawing.Point(216, 9);
            this.LBLTerm1End.Name = "LBLTerm1End";
            this.LBLTerm1End.Size = new System.Drawing.Size(26, 13);
            this.LBLTerm1End.TabIndex = 6;
            this.LBLTerm1End.Text = "End";
            // 
            // DTPTerm1End
            // 
            this.DTPTerm1End.Location = new System.Drawing.Point(242, 3);
            this.DTPTerm1End.Name = "DTPTerm1End";
            this.DTPTerm1End.Size = new System.Drawing.Size(118, 20);
            this.DTPTerm1End.TabIndex = 7;
            // 
            // NUTerm1Loan
            // 
            this.NUTerm1Loan.DecimalPlaces = 2;
            this.NUTerm1Loan.Location = new System.Drawing.Point(87, 29);
            this.NUTerm1Loan.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUTerm1Loan.Name = "NUTerm1Loan";
            this.NUTerm1Loan.Size = new System.Drawing.Size(120, 20);
            this.NUTerm1Loan.TabIndex = 8;
            // 
            // LBLTerm1Loan
            // 
            this.LBLTerm1Loan.AutoSize = true;
            this.LBLTerm1Loan.Location = new System.Drawing.Point(52, 31);
            this.LBLTerm1Loan.Name = "LBLTerm1Loan";
            this.LBLTerm1Loan.Size = new System.Drawing.Size(31, 13);
            this.LBLTerm1Loan.TabIndex = 9;
            this.LBLTerm1Loan.Text = "Loan";
            // 
            // NUTerm1Grant
            // 
            this.NUTerm1Grant.DecimalPlaces = 2;
            this.NUTerm1Grant.Location = new System.Drawing.Point(242, 29);
            this.NUTerm1Grant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUTerm1Grant.Name = "NUTerm1Grant";
            this.NUTerm1Grant.Size = new System.Drawing.Size(118, 20);
            this.NUTerm1Grant.TabIndex = 10;
            // 
            // LBLTerm1Grant
            // 
            this.LBLTerm1Grant.AutoSize = true;
            this.LBLTerm1Grant.Location = new System.Drawing.Point(209, 31);
            this.LBLTerm1Grant.Name = "LBLTerm1Grant";
            this.LBLTerm1Grant.Size = new System.Drawing.Size(33, 13);
            this.LBLTerm1Grant.TabIndex = 11;
            this.LBLTerm1Grant.Text = "Grant";
            // 
            // DTPSF1Payment
            // 
            this.DTPSF1Payment.Location = new System.Drawing.Point(242, 54);
            this.DTPSF1Payment.Name = "DTPSF1Payment";
            this.DTPSF1Payment.Size = new System.Drawing.Size(118, 20);
            this.DTPSF1Payment.TabIndex = 12;
            // 
            // LBLSF1Payment
            // 
            this.LBLSF1Payment.AutoSize = true;
            this.LBLSF1Payment.Location = new System.Drawing.Point(52, 60);
            this.LBLSF1Payment.Name = "LBLSF1Payment";
            this.LBLSF1Payment.Size = new System.Drawing.Size(155, 13);
            this.LBLSF1Payment.TabIndex = 13;
            this.LBLSF1Payment.Text = "Student Finance Payment Date";
            // 
            // LBL1Bursary
            // 
            this.LBL1Bursary.AutoSize = true;
            this.LBL1Bursary.Location = new System.Drawing.Point(52, 84);
            this.LBL1Bursary.Name = "LBL1Bursary";
            this.LBL1Bursary.Size = new System.Drawing.Size(42, 13);
            this.LBL1Bursary.TabIndex = 14;
            this.LBL1Bursary.Text = "Bursary";
            // 
            // NU1Bursary
            // 
            this.NU1Bursary.DecimalPlaces = 2;
            this.NU1Bursary.Location = new System.Drawing.Point(100, 82);
            this.NU1Bursary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NU1Bursary.Name = "NU1Bursary";
            this.NU1Bursary.Size = new System.Drawing.Size(120, 20);
            this.NU1Bursary.TabIndex = 15;
            // 
            // DTP1Bursary
            // 
            this.DTP1Bursary.Location = new System.Drawing.Point(242, 82);
            this.DTP1Bursary.Name = "DTP1Bursary";
            this.DTP1Bursary.Size = new System.Drawing.Size(118, 20);
            this.DTP1Bursary.TabIndex = 16;
            // 
            // DTP2Bursary
            // 
            this.DTP2Bursary.Location = new System.Drawing.Point(242, 192);
            this.DTP2Bursary.Name = "DTP2Bursary";
            this.DTP2Bursary.Size = new System.Drawing.Size(118, 20);
            this.DTP2Bursary.TabIndex = 30;
            // 
            // NU2Bursary
            // 
            this.NU2Bursary.DecimalPlaces = 2;
            this.NU2Bursary.Location = new System.Drawing.Point(100, 192);
            this.NU2Bursary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NU2Bursary.Name = "NU2Bursary";
            this.NU2Bursary.Size = new System.Drawing.Size(120, 20);
            this.NU2Bursary.TabIndex = 29;
            // 
            // LBL2Bursary
            // 
            this.LBL2Bursary.AutoSize = true;
            this.LBL2Bursary.Location = new System.Drawing.Point(52, 194);
            this.LBL2Bursary.Name = "LBL2Bursary";
            this.LBL2Bursary.Size = new System.Drawing.Size(42, 13);
            this.LBL2Bursary.TabIndex = 28;
            this.LBL2Bursary.Text = "Bursary";
            // 
            // LBLSF2Payment
            // 
            this.LBLSF2Payment.AutoSize = true;
            this.LBLSF2Payment.Location = new System.Drawing.Point(52, 170);
            this.LBLSF2Payment.Name = "LBLSF2Payment";
            this.LBLSF2Payment.Size = new System.Drawing.Size(155, 13);
            this.LBLSF2Payment.TabIndex = 27;
            this.LBLSF2Payment.Text = "Student Finance Payment Date";
            // 
            // DTPSF2Payment
            // 
            this.DTPSF2Payment.Location = new System.Drawing.Point(242, 164);
            this.DTPSF2Payment.Name = "DTPSF2Payment";
            this.DTPSF2Payment.Size = new System.Drawing.Size(118, 20);
            this.DTPSF2Payment.TabIndex = 26;
            // 
            // LBLTerm2Grant
            // 
            this.LBLTerm2Grant.AutoSize = true;
            this.LBLTerm2Grant.Location = new System.Drawing.Point(209, 141);
            this.LBLTerm2Grant.Name = "LBLTerm2Grant";
            this.LBLTerm2Grant.Size = new System.Drawing.Size(33, 13);
            this.LBLTerm2Grant.TabIndex = 25;
            this.LBLTerm2Grant.Text = "Grant";
            // 
            // NUTerm2Grant
            // 
            this.NUTerm2Grant.DecimalPlaces = 2;
            this.NUTerm2Grant.Location = new System.Drawing.Point(242, 139);
            this.NUTerm2Grant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUTerm2Grant.Name = "NUTerm2Grant";
            this.NUTerm2Grant.Size = new System.Drawing.Size(118, 20);
            this.NUTerm2Grant.TabIndex = 24;
            // 
            // LBLTerm2Loan
            // 
            this.LBLTerm2Loan.AutoSize = true;
            this.LBLTerm2Loan.Location = new System.Drawing.Point(52, 141);
            this.LBLTerm2Loan.Name = "LBLTerm2Loan";
            this.LBLTerm2Loan.Size = new System.Drawing.Size(31, 13);
            this.LBLTerm2Loan.TabIndex = 23;
            this.LBLTerm2Loan.Text = "Loan";
            // 
            // NUTerm2Loan
            // 
            this.NUTerm2Loan.DecimalPlaces = 2;
            this.NUTerm2Loan.Location = new System.Drawing.Point(87, 139);
            this.NUTerm2Loan.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUTerm2Loan.Name = "NUTerm2Loan";
            this.NUTerm2Loan.Size = new System.Drawing.Size(120, 20);
            this.NUTerm2Loan.TabIndex = 22;
            // 
            // DTPTerm2End
            // 
            this.DTPTerm2End.Location = new System.Drawing.Point(242, 113);
            this.DTPTerm2End.Name = "DTPTerm2End";
            this.DTPTerm2End.Size = new System.Drawing.Size(118, 20);
            this.DTPTerm2End.TabIndex = 21;
            // 
            // LBLTerm2End
            // 
            this.LBLTerm2End.AutoSize = true;
            this.LBLTerm2End.Location = new System.Drawing.Point(216, 119);
            this.LBLTerm2End.Name = "LBLTerm2End";
            this.LBLTerm2End.Size = new System.Drawing.Size(26, 13);
            this.LBLTerm2End.TabIndex = 20;
            this.LBLTerm2End.Text = "End";
            // 
            // DTPTerm2Start
            // 
            this.DTPTerm2Start.Location = new System.Drawing.Point(87, 113);
            this.DTPTerm2Start.Name = "DTPTerm2Start";
            this.DTPTerm2Start.Size = new System.Drawing.Size(118, 20);
            this.DTPTerm2Start.TabIndex = 19;
            // 
            // LBLTerm2Start
            // 
            this.LBLTerm2Start.AutoSize = true;
            this.LBLTerm2Start.Location = new System.Drawing.Point(52, 119);
            this.LBLTerm2Start.Name = "LBLTerm2Start";
            this.LBLTerm2Start.Size = new System.Drawing.Size(29, 13);
            this.LBLTerm2Start.TabIndex = 18;
            this.LBLTerm2Start.Text = "Start";
            // 
            // LBLTerm2
            // 
            this.LBLTerm2.AutoSize = true;
            this.LBLTerm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTerm2.Location = new System.Drawing.Point(9, 119);
            this.LBLTerm2.Name = "LBLTerm2";
            this.LBLTerm2.Size = new System.Drawing.Size(42, 13);
            this.LBLTerm2.TabIndex = 17;
            this.LBLTerm2.Text = "Term2";
            // 
            // DTP3Bursary
            // 
            this.DTP3Bursary.Location = new System.Drawing.Point(242, 306);
            this.DTP3Bursary.Name = "DTP3Bursary";
            this.DTP3Bursary.Size = new System.Drawing.Size(118, 20);
            this.DTP3Bursary.TabIndex = 44;
            // 
            // NU3Bursary
            // 
            this.NU3Bursary.DecimalPlaces = 2;
            this.NU3Bursary.Location = new System.Drawing.Point(100, 306);
            this.NU3Bursary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NU3Bursary.Name = "NU3Bursary";
            this.NU3Bursary.Size = new System.Drawing.Size(120, 20);
            this.NU3Bursary.TabIndex = 43;
            // 
            // LBL3Bursary
            // 
            this.LBL3Bursary.AutoSize = true;
            this.LBL3Bursary.Location = new System.Drawing.Point(52, 308);
            this.LBL3Bursary.Name = "LBL3Bursary";
            this.LBL3Bursary.Size = new System.Drawing.Size(42, 13);
            this.LBL3Bursary.TabIndex = 42;
            this.LBL3Bursary.Text = "Bursary";
            // 
            // LBLSF3Payment
            // 
            this.LBLSF3Payment.AutoSize = true;
            this.LBLSF3Payment.Location = new System.Drawing.Point(52, 284);
            this.LBLSF3Payment.Name = "LBLSF3Payment";
            this.LBLSF3Payment.Size = new System.Drawing.Size(155, 13);
            this.LBLSF3Payment.TabIndex = 41;
            this.LBLSF3Payment.Text = "Student Finance Payment Date";
            // 
            // DTPSF3Payment
            // 
            this.DTPSF3Payment.Location = new System.Drawing.Point(242, 278);
            this.DTPSF3Payment.Name = "DTPSF3Payment";
            this.DTPSF3Payment.Size = new System.Drawing.Size(118, 20);
            this.DTPSF3Payment.TabIndex = 40;
            // 
            // LBLTerm3Grant
            // 
            this.LBLTerm3Grant.AutoSize = true;
            this.LBLTerm3Grant.Location = new System.Drawing.Point(209, 255);
            this.LBLTerm3Grant.Name = "LBLTerm3Grant";
            this.LBLTerm3Grant.Size = new System.Drawing.Size(33, 13);
            this.LBLTerm3Grant.TabIndex = 39;
            this.LBLTerm3Grant.Text = "Grant";
            // 
            // NUTerm3Grant
            // 
            this.NUTerm3Grant.DecimalPlaces = 2;
            this.NUTerm3Grant.Location = new System.Drawing.Point(242, 253);
            this.NUTerm3Grant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUTerm3Grant.Name = "NUTerm3Grant";
            this.NUTerm3Grant.Size = new System.Drawing.Size(118, 20);
            this.NUTerm3Grant.TabIndex = 38;
            // 
            // LBLTerm3Loan
            // 
            this.LBLTerm3Loan.AutoSize = true;
            this.LBLTerm3Loan.Location = new System.Drawing.Point(52, 255);
            this.LBLTerm3Loan.Name = "LBLTerm3Loan";
            this.LBLTerm3Loan.Size = new System.Drawing.Size(31, 13);
            this.LBLTerm3Loan.TabIndex = 37;
            this.LBLTerm3Loan.Text = "Loan";
            // 
            // NUTerm3Loan
            // 
            this.NUTerm3Loan.DecimalPlaces = 2;
            this.NUTerm3Loan.Location = new System.Drawing.Point(87, 253);
            this.NUTerm3Loan.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUTerm3Loan.Name = "NUTerm3Loan";
            this.NUTerm3Loan.Size = new System.Drawing.Size(120, 20);
            this.NUTerm3Loan.TabIndex = 36;
            // 
            // DTPTerm3End
            // 
            this.DTPTerm3End.Location = new System.Drawing.Point(242, 227);
            this.DTPTerm3End.Name = "DTPTerm3End";
            this.DTPTerm3End.Size = new System.Drawing.Size(118, 20);
            this.DTPTerm3End.TabIndex = 35;
            // 
            // LBLTerm3End
            // 
            this.LBLTerm3End.AutoSize = true;
            this.LBLTerm3End.Location = new System.Drawing.Point(216, 233);
            this.LBLTerm3End.Name = "LBLTerm3End";
            this.LBLTerm3End.Size = new System.Drawing.Size(26, 13);
            this.LBLTerm3End.TabIndex = 34;
            this.LBLTerm3End.Text = "End";
            // 
            // DTPTerm3Start
            // 
            this.DTPTerm3Start.Location = new System.Drawing.Point(87, 227);
            this.DTPTerm3Start.Name = "DTPTerm3Start";
            this.DTPTerm3Start.Size = new System.Drawing.Size(118, 20);
            this.DTPTerm3Start.TabIndex = 33;
            // 
            // LBLTerm3Start
            // 
            this.LBLTerm3Start.AutoSize = true;
            this.LBLTerm3Start.Location = new System.Drawing.Point(52, 233);
            this.LBLTerm3Start.Name = "LBLTerm3Start";
            this.LBLTerm3Start.Size = new System.Drawing.Size(29, 13);
            this.LBLTerm3Start.TabIndex = 32;
            this.LBLTerm3Start.Text = "Start";
            // 
            // LBLTerm3
            // 
            this.LBLTerm3.AutoSize = true;
            this.LBLTerm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTerm3.Location = new System.Drawing.Point(9, 233);
            this.LBLTerm3.Name = "LBLTerm3";
            this.LBLTerm3.Size = new System.Drawing.Size(42, 13);
            this.LBLTerm3.TabIndex = 31;
            this.LBLTerm3.Text = "Term3";
            // 
            // CBYearIndustry
            // 
            this.CBYearIndustry.AutoSize = true;
            this.CBYearIndustry.Location = new System.Drawing.Point(12, 340);
            this.CBYearIndustry.Name = "CBYearIndustry";
            this.CBYearIndustry.Size = new System.Drawing.Size(100, 17);
            this.CBYearIndustry.TabIndex = 45;
            this.CBYearIndustry.Text = "Year In Industry";
            this.CBYearIndustry.UseVisualStyleBackColor = true;
            // 
            // FinanceRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 396);
            this.Controls.Add(this.CBYearIndustry);
            this.Controls.Add(this.DTP3Bursary);
            this.Controls.Add(this.NU3Bursary);
            this.Controls.Add(this.LBL3Bursary);
            this.Controls.Add(this.LBLSF3Payment);
            this.Controls.Add(this.DTPSF3Payment);
            this.Controls.Add(this.LBLTerm3Grant);
            this.Controls.Add(this.NUTerm3Grant);
            this.Controls.Add(this.LBLTerm3Loan);
            this.Controls.Add(this.NUTerm3Loan);
            this.Controls.Add(this.DTPTerm3End);
            this.Controls.Add(this.LBLTerm3End);
            this.Controls.Add(this.DTPTerm3Start);
            this.Controls.Add(this.LBLTerm3Start);
            this.Controls.Add(this.LBLTerm3);
            this.Controls.Add(this.DTP2Bursary);
            this.Controls.Add(this.NU2Bursary);
            this.Controls.Add(this.LBL2Bursary);
            this.Controls.Add(this.LBLSF2Payment);
            this.Controls.Add(this.DTPSF2Payment);
            this.Controls.Add(this.LBLTerm2Grant);
            this.Controls.Add(this.NUTerm2Grant);
            this.Controls.Add(this.LBLTerm2Loan);
            this.Controls.Add(this.NUTerm2Loan);
            this.Controls.Add(this.DTPTerm2End);
            this.Controls.Add(this.LBLTerm2End);
            this.Controls.Add(this.DTPTerm2Start);
            this.Controls.Add(this.LBLTerm2Start);
            this.Controls.Add(this.LBLTerm2);
            this.Controls.Add(this.DTP1Bursary);
            this.Controls.Add(this.NU1Bursary);
            this.Controls.Add(this.LBL1Bursary);
            this.Controls.Add(this.LBLSF1Payment);
            this.Controls.Add(this.DTPSF1Payment);
            this.Controls.Add(this.LBLTerm1Grant);
            this.Controls.Add(this.NUTerm1Grant);
            this.Controls.Add(this.LBLTerm1Loan);
            this.Controls.Add(this.NUTerm1Loan);
            this.Controls.Add(this.DTPTerm1End);
            this.Controls.Add(this.LBLTerm1End);
            this.Controls.Add(this.DTPTerm1Start);
            this.Controls.Add(this.LBLTerm1Start);
            this.Controls.Add(this.LBLTerm1);
            this.Controls.Add(this.BTNWriteRC);
            this.Controls.Add(this.BTNAddYear);
            this.Controls.Add(this.NUYear);
            this.Name = "FinanceRC";
            this.Text = "FinanceRC";
            ((System.ComponentModel.ISupportInitialize)(this.NUYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm1Loan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm1Grant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU1Bursary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU2Bursary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm2Grant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm2Loan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU3Bursary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm3Grant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUTerm3Loan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUYear;
        private System.Windows.Forms.Button BTNAddYear;
        private System.Windows.Forms.Button BTNWriteRC;
        private System.Windows.Forms.Label LBLTerm1;
        private System.Windows.Forms.Label LBLTerm1Start;
        private System.Windows.Forms.DateTimePicker DTPTerm1Start;
        private System.Windows.Forms.Label LBLTerm1End;
        private System.Windows.Forms.DateTimePicker DTPTerm1End;
        private System.Windows.Forms.NumericUpDown NUTerm1Loan;
        private System.Windows.Forms.Label LBLTerm1Loan;
        private System.Windows.Forms.NumericUpDown NUTerm1Grant;
        private System.Windows.Forms.Label LBLTerm1Grant;
        private System.Windows.Forms.DateTimePicker DTPSF1Payment;
        private System.Windows.Forms.Label LBLSF1Payment;
        private System.Windows.Forms.Label LBL1Bursary;
        private System.Windows.Forms.NumericUpDown NU1Bursary;
        private System.Windows.Forms.DateTimePicker DTP1Bursary;
        private System.Windows.Forms.DateTimePicker DTP2Bursary;
        private System.Windows.Forms.NumericUpDown NU2Bursary;
        private System.Windows.Forms.Label LBL2Bursary;
        private System.Windows.Forms.Label LBLSF2Payment;
        private System.Windows.Forms.DateTimePicker DTPSF2Payment;
        private System.Windows.Forms.Label LBLTerm2Grant;
        private System.Windows.Forms.NumericUpDown NUTerm2Grant;
        private System.Windows.Forms.Label LBLTerm2Loan;
        private System.Windows.Forms.NumericUpDown NUTerm2Loan;
        private System.Windows.Forms.DateTimePicker DTPTerm2End;
        private System.Windows.Forms.Label LBLTerm2End;
        private System.Windows.Forms.DateTimePicker DTPTerm2Start;
        private System.Windows.Forms.Label LBLTerm2Start;
        private System.Windows.Forms.Label LBLTerm2;
        private System.Windows.Forms.DateTimePicker DTP3Bursary;
        private System.Windows.Forms.NumericUpDown NU3Bursary;
        private System.Windows.Forms.Label LBL3Bursary;
        private System.Windows.Forms.Label LBLSF3Payment;
        private System.Windows.Forms.DateTimePicker DTPSF3Payment;
        private System.Windows.Forms.Label LBLTerm3Grant;
        private System.Windows.Forms.NumericUpDown NUTerm3Grant;
        private System.Windows.Forms.Label LBLTerm3Loan;
        private System.Windows.Forms.NumericUpDown NUTerm3Loan;
        private System.Windows.Forms.DateTimePicker DTPTerm3End;
        private System.Windows.Forms.Label LBLTerm3End;
        private System.Windows.Forms.DateTimePicker DTPTerm3Start;
        private System.Windows.Forms.Label LBLTerm3Start;
        private System.Windows.Forms.Label LBLTerm3;
        private System.Windows.Forms.CheckBox CBYearIndustry;
    }
}
