﻿namespace Lucre
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeRCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quarterlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualyCalendarYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualyAcademicYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.everyTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBTransactions = new System.Windows.Forms.ListBox();
            this.LBLSumMode = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.showFormToolStripMenuItem,
            this.totalModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MainMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.toolStripMenuItem1.Text = "Add &Transaction";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // showFormToolStripMenuItem
            // 
            this.showFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financeRCToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.companyToolStripMenuItem});
            this.showFormToolStripMenuItem.Name = "showFormToolStripMenuItem";
            this.showFormToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.showFormToolStripMenuItem.Text = "ShowForm";
            // 
            // financeRCToolStripMenuItem
            // 
            this.financeRCToolStripMenuItem.Name = "financeRCToolStripMenuItem";
            this.financeRCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.financeRCToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.financeRCToolStripMenuItem.Text = "Finance&RC";
            this.financeRCToolStripMenuItem.ToolTipText = "Program Configuration File";
            this.financeRCToolStripMenuItem.Click += new System.EventHandler(this.financeRCToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.inventoryToolStripMenuItem.Text = "&Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.companyToolStripMenuItem.Text = "&Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // totalModeToolStripMenuItem
            // 
            this.totalModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weeklyToolStripMenuItem,
            this.monthlyToolStripMenuItem,
            this.termlyToolStripMenuItem,
            this.quarterlyToolStripMenuItem,
            this.anualyCalendarYearToolStripMenuItem,
            this.anualyAcademicYearToolStripMenuItem,
            this.everyTransactionToolStripMenuItem});
            this.totalModeToolStripMenuItem.Name = "totalModeToolStripMenuItem";
            this.totalModeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.totalModeToolStripMenuItem.Text = "&Total Mode";
            // 
            // weeklyToolStripMenuItem
            // 
            this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            this.weeklyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.weeklyToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.weeklyToolStripMenuItem.Text = "&Weekly";
            this.weeklyToolStripMenuItem.Click += new System.EventHandler(this.weeklyToolStripMenuItem_Click);
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.monthlyToolStripMenuItem.Text = "&Monthly";
            this.monthlyToolStripMenuItem.Click += new System.EventHandler(this.monthlyToolStripMenuItem_Click);
            // 
            // termlyToolStripMenuItem
            // 
            this.termlyToolStripMenuItem.Name = "termlyToolStripMenuItem";
            this.termlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.termlyToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.termlyToolStripMenuItem.Text = "&Semester";
            this.termlyToolStripMenuItem.Click += new System.EventHandler(this.termlyToolStripMenuItem_Click);
            // 
            // quarterlyToolStripMenuItem
            // 
            this.quarterlyToolStripMenuItem.Name = "quarterlyToolStripMenuItem";
            this.quarterlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quarterlyToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.quarterlyToolStripMenuItem.Text = "&Quarterly";
            this.quarterlyToolStripMenuItem.Click += new System.EventHandler(this.quarterlyToolStripMenuItem_Click);
            // 
            // anualyCalendarYearToolStripMenuItem
            // 
            this.anualyCalendarYearToolStripMenuItem.Name = "anualyCalendarYearToolStripMenuItem";
            this.anualyCalendarYearToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.anualyCalendarYearToolStripMenuItem.Text = "Anualy (&Calendar Year)";
            this.anualyCalendarYearToolStripMenuItem.Click += new System.EventHandler(this.anualyCalendarYearToolStripMenuItem_Click);
            // 
            // anualyAcademicYearToolStripMenuItem
            // 
            this.anualyAcademicYearToolStripMenuItem.Name = "anualyAcademicYearToolStripMenuItem";
            this.anualyAcademicYearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.anualyAcademicYearToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.anualyAcademicYearToolStripMenuItem.Text = "Anualy (&Academic Year)";
            this.anualyAcademicYearToolStripMenuItem.Click += new System.EventHandler(this.anualyAcademicYearToolStripMenuItem_Click);
            // 
            // everyTransactionToolStripMenuItem
            // 
            this.everyTransactionToolStripMenuItem.Name = "everyTransactionToolStripMenuItem";
            this.everyTransactionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.everyTransactionToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.everyTransactionToolStripMenuItem.Text = "&Every Transaction";
            this.everyTransactionToolStripMenuItem.Click += new System.EventHandler(this.everyTransactionToolStripMenuItem_Click);
            // 
            // LBTransactions
            // 
            this.LBTransactions.FormattingEnabled = true;
            this.LBTransactions.Location = new System.Drawing.Point(12, 27);
            this.LBTransactions.Name = "LBTransactions";
            this.LBTransactions.Size = new System.Drawing.Size(120, 186);
            this.LBTransactions.TabIndex = 1;
            this.LBTransactions.SelectedIndexChanged += new System.EventHandler(this.ReviewTrans);
            // 
            // LBLSumMode
            // 
            this.LBLSumMode.AutoSize = true;
            this.LBLSumMode.Location = new System.Drawing.Point(9, 239);
            this.LBLSumMode.Name = "LBLSumMode";
            this.LBLSumMode.Size = new System.Drawing.Size(75, 13);
            this.LBLSumMode.TabIndex = 2;
            this.LBLSumMode.Text = "Sum Mode: All";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LBLSumMode);
            this.Controls.Add(this.LBTransactions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Enter);
            this.Enter += new System.EventHandler(this.Main_Enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeRCToolStripMenuItem;
        private System.Windows.Forms.ListBox LBTransactions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quarterlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualyCalendarYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualyAcademicYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem everyTransactionToolStripMenuItem;
        private System.Windows.Forms.Label LBLSumMode;
    }
}

