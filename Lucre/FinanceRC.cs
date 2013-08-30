using System;
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
    public partial class FinanceRC : Form
    {
        public FinanceRC(bool IsNew)
        {
            InitializeComponent();
            Main.LoadRC();
            NUYear.Value = Main.RC.CurrentYear;
            FillForm();
        }

        private void FillForm()
        {
            try
            {
                Main.LoadRC();
                int index = (int)NUYear.Value - 1;
                CBYearIndustry.Checked = Main.RC.Years[index].YearInIndustry;
                NUYear.Maximum = Main.RC.Years.Count;

                DTPTerm1Start.Value = Main.RC.Years[index].Terms[0].Duration.Start;
                DTPTerm1End.Value = Main.RC.Years[index].Terms[0].Duration.End;

                NUTerm1Loan.Value = Main.RC.Years[index].Terms[0].StudentFinanceLoan;
                NUTerm1Grant.Value = Main.RC.Years[index].Terms[0].StudentFinanceGrant;
                DTPSF1Payment.Value = Main.RC.Years[index].Terms[0].SFPayment;

                NU1Bursary.Value = Main.RC.Years[index].Terms[0].Bursary;
                DTP1Bursary.Value = Main.RC.Years[index].Terms[0].BPayment;


                DTPTerm2Start.Value = Main.RC.Years[index].Terms[1].Duration.Start;
                DTPTerm2End.Value = Main.RC.Years[index].Terms[1].Duration.End;

                NUTerm2Loan.Value = Main.RC.Years[index].Terms[1].StudentFinanceLoan;
                NUTerm2Grant.Value = Main.RC.Years[index].Terms[1].StudentFinanceGrant;
                DTPSF2Payment.Value = Main.RC.Years[index].Terms[1].SFPayment;

                NU2Bursary.Value = Main.RC.Years[index].Terms[1].Bursary;
                DTP2Bursary.Value = Main.RC.Years[index].Terms[1].BPayment;


                DTPTerm3Start.Value = Main.RC.Years[index].Terms[2].Duration.Start;
                DTPTerm3End.Value = Main.RC.Years[index].Terms[2].Duration.End;

                NUTerm3Loan.Value = Main.RC.Years[index].Terms[2].StudentFinanceLoan;
                NUTerm3Grant.Value = Main.RC.Years[index].Terms[2].StudentFinanceGrant;
                DTPSF3Payment.Value = Main.RC.Years[index].Terms[2].SFPayment;

                NU3Bursary.Value = Main.RC.Years[index].Terms[2].Bursary;
                DTP3Bursary.Value = Main.RC.Years[index].Terms[2].BPayment;
            }
            catch
            {

            }
        }

        private void BTNWriteRC_Click(object sender, EventArgs e)
        {
            List<Main.Term> T = new List<Main.Term>();
            T.Add(new Main.Term(new Main.Duration(DTPTerm1Start.Value, DTPTerm1End.Value),
                NUTerm1Loan.Value, NUTerm1Grant.Value, DTPSF1Payment.Value, NU1Bursary.Value,
                DTP1Bursary.Value));
            T.Add(new Main.Term(new Main.Duration(DTPTerm2Start.Value, DTPTerm2End.Value),
                NUTerm2Loan.Value, NUTerm2Grant.Value, DTPSF2Payment.Value, NU2Bursary.Value,
                DTP2Bursary.Value));
            T.Add(new Main.Term(new Main.Duration(DTPTerm3Start.Value, DTPTerm3End.Value),
                NUTerm3Loan.Value, NUTerm3Grant.Value, DTPSF3Payment.Value, NU3Bursary.Value,
                DTP3Bursary.Value));

            List<Main.Year> Y = new List<Main.Year>();
            Y.Insert( (int) (NUYear.Value-1), new Main.Year(T, CBYearIndustry.Checked));
            Main.RC = new Main.SFinanceRC(Y, (int) NUYear.Value, 10);

            Main.SaveRC();
            FillForm();
        }

        private void NUYear_ValueChanged(object sender, EventArgs e)
        {
            FillForm();
        }
    }
}
