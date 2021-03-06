﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucre
{
    public partial class TransEdit : Form
    {
        public TransEdit(int? Index, bool? IsIncomeL)
        {
            InitializeComponent();
            IsIncome = IsIncomeL;
            if (Index.HasValue)
            {
                DisplayTransaction((int) Index);    //Cast !nullable
                GIndex = Index;
            }
            else SetRepeatRegionVisibility();

            try
            {
                CBCompany.AutoCompleteCustomSource = Main.ACS;
                CBCompany.Items.AddRange(Main.sACS);
            }
            catch { }
        }
        
        public int? GIndex = null;
        public bool? IsIncome;

        private Main.Repeat? SetRepeatData()
        {
            if (ChBRepeatTransaction.Checked)
                return new Main.Repeat(new Main.Duration(DTPStart.Value,
                    DTPEnd.Value), CBRepeatFreq.Text,
                    ChBRepeatActive.Checked);
            else return null;
        }

        private Main.CapTime? SetRealCapTime()
        {
            if (ChBTransactionCompleted.Checked)
                return new Main.CapTime(NUReal.Value,
                    DTPReal.Value);
            else return null;
        }

        private void BTNWriteData_Click(object sender, EventArgs e)
        {
            CBCompany.Text = Main.CheckCompanies(CBCompany.Text);

            Main.Transaction T = new Main.Transaction(
                TBName.Text, CBCategory.Text, CBCompany.Text,
                new Main.CapTime(NUPredicted.Value, DTPPredicted.Value),
                SetRealCapTime(), 
                ChBTransactionCompleted.Checked,
                TBNotes.Lines,
                SetRepeatData()
                );

            Main.UpdateTransactions(T, IsIncome);
            if (GIndex.HasValue)
                Main.RemoveTransaction(GIndex.Value, IsIncome);
            Main.SaveTransactions();
        }

        private string SetChBCompleteString()
        {
            decimal ans;
            if (NUPredicted.Value > NUReal.Value)
            {
                ans = NUPredicted.Value - NUReal.Value;
                return "Transaction Prediction is " + ans.ToString() + " >  real";
            }
            else if (NUPredicted.Value < NUReal.Value)
            {
                ans = NUReal.Value - NUPredicted.Value;
                return "Transaction Prediction is " + ans.ToString() + " <  real";
            }
            return "Prediction is on target";
        }

        private void ChBTransactionCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if ( ChBTransactionCompleted.Checked )
            {
                NUReal.Enabled = true;
                DTPReal.Enabled = true;

                if (NUReal.Value == 0)
                {
                    NUReal.Value = NUPredicted.Value;
                    DTPReal.Value = DTPPredicted.Value;
                }
                ChBTransactionCompleted.Text = SetChBCompleteString();
                
            }
            else
            {
                NUReal.Enabled = false;
                DTPReal.Enabled = false;
                ChBTransactionCompleted.Text = "Transaction Completed?";
            }
        }

        private void NURealValChanged(object sender, EventArgs e)
        {
            ChBTransactionCompleted.Text = SetChBCompleteString();
        }

        private void SetRepeatRegionVisibility()
        {
            bool IsRepeat = ChBRepeatTransaction.Checked;
            GBRepeatTransaction.Visible = IsRepeat;

            if (IsRepeat)
            {
                TBNotes.Location = new Point(15, 223);
                TBNotes.Size = new Size(359, 81);
            }
            else
            {
                TBNotes.Location = GBRepeatTransaction.Location;
                TBNotes.Size = new Size(359, 81 + GBRepeatTransaction.Size.Height +6);
            }
        }

        private void CBRepeatTransaction_CheckedChanged(object sender, EventArgs e)
        {
            SetRepeatRegionVisibility();
        }

        private Main.Transaction RetTransaction(int Index)
        {
            if (IsIncome.HasValue)
            {
                if (IsIncome.Value) // Income
                    return Main.Transactions.In[Index];
                else //Outcome
                {
                    return Main.Transactions.Out[Index];
                }
            }
            else //WishList
            {
				return Main.Transactions.WishList[Index];
            }
        }

        private void DisplayTransaction(int Index)
        {
            Main.Transaction T = RetTransaction(Index);

            TBName.Text = T.Name;
            CBCompany.Text = T.Company;
            CBCategory.Text = T.Category;
            NUPredicted.Value = T.Predicted.Capital;
            DTPStart.Value = T.Predicted.Time;
            TBNotes.Lines = T.Notes;

            if (T.Resolved)
            {
                NUReal.Value = T.Real.Value.Capital;
                DTPReal.Value = T.Real.Value.Time;
            }

            if (T.Repeat.HasValue)
            {
                DTPStart.Value = T.Repeat.Value.Duration.Value.Start;
                DTPEnd.Value = T.Repeat.Value.Duration.Value.End;

                CBRepeatFreq.Text = T.Repeat.Value.Increment;
                ChBRepeatActive.Checked = T.Repeat.Value.Active;
            }

            BTNWriteData.Text = "Update";
        }

        private void CompanyChanged(object sender, EventArgs e)
        {
            if (CBCategory.Text == "")
                CBCategory.Text = Main.SetCategory(CBCompany.Text);
            
        }
    }
}
