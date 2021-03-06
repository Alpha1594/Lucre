﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Lucre
{
    public partial class Main : Form
    {
        #region Data
        public struct Duration
        {
            public DateTime Start;
            public DateTime End;
            public Duration(DateTime Start, DateTime End)
            {
                this.Start = Start;
                this.End = End;
            }
        }

        public struct DurationN
        {
            public DateTime? Start;
            public DateTime? End;
            public DurationN(DateTime? Start, DateTime? End)
            {
                this.Start = Start;
                this.End = End;
            }
        }

        #region RC
        public struct Term
        {
            public Duration Duration;

            public Decimal StudentFinanceLoan;
            public Decimal StudentFinanceGrant;

            public DateTime SFPayment;

            public Decimal Bursary;
            public DateTime BPayment;
            public Term(Duration Duration, Decimal StudentFinanceLoan, Decimal StudentFinanceGrant,
                DateTime SFPayment, Decimal Bursary, DateTime BPayment)
            {
                this.Duration = Duration;
                this.StudentFinanceLoan = StudentFinanceLoan;
                this.StudentFinanceGrant = StudentFinanceGrant;
                this.SFPayment = SFPayment;
                this.Bursary = Bursary;
                this.BPayment = BPayment;
            }
        }

        public struct Year
        {
            public List<Term> Terms;
            public bool YearInIndustry;
            public Year(List<Term> Terms, bool YearInIndustry)
            {
                this.Terms = Terms;
                this.YearInIndustry = YearInIndustry;
            }
        }

        public struct SFinanceRC
        {
            public List<Year> Years;
            public int CurrentYear;
            public int NumRecTransactionsToShow;
            public SFinanceRC(List<Year> Years, int CurrentYear, int NumRecTransactionsToShow)
            {
                this.Years = Years;
                this.CurrentYear = CurrentYear;
                this.NumRecTransactionsToShow = NumRecTransactionsToShow;
            }
        }

        public static SFinanceRC LoadRC()
        {
            try
            {
                FileStream FS = new FileStream("Data\\Finance.rc", FileMode.Open);
                XmlSerializer XSR = new XmlSerializer(typeof(SFinanceRC));
                FS.Dispose();
                return (SFinanceRC)XSR.Deserialize(FS);
            }
            catch
            {
                return (SFinanceRC) RC;
            }
        }

        public static SFinanceRC RC = new SFinanceRC();
        #endregion

        #region Transactions
        public struct CapTime
        {
            public decimal Capital;
            public DateTime Time;

            public CapTime(decimal Capital, DateTime Time)
            {
                this.Capital = Capital;
                this.Time = Time;
            }
        }

        public struct Repeat
        {
            public Duration? Duration;
            public string Increment;
            public bool Active;

            public Repeat(Duration? Duration, string Inc, bool Active)
            {
                this.Duration = Duration;
                this.Increment = Inc;
                this.Active = Active;
            }
        }

        public struct Transaction
        {
            public string Name;
            public string Category;
            public string Company;
            public CapTime Predicted;
            public CapTime? Real;
            public bool Resolved;
            public string[] Notes;
            public Nullable<Repeat> Repeat;

            public Transaction(string Name, string Category, string Company,
                CapTime Predicted, CapTime? Real, bool Resolved,
                string[] Notes, Repeat? Repeat)
            {
                this.Name = Name;
                this.Category = Category;
                this.Company = Company;
                this.Predicted = Predicted;
                this.Real = Real;
                this.Resolved = Resolved;
                this.Notes = Notes;
                this.Repeat = Repeat;
            }
        }

        public struct CashFlow
		{
	        public List<Transaction> In;
	        public List<Transaction> Out;
            public List<Transaction> WishList;

            public CashFlow(List<Transaction> In, List<Transaction> Out, List<Transaction> WishList)
            {
				 this.In = In;
				 this.Out = Out;
				 this.WishList = WishList;
            }
		}

		public static CashFlow Transactions = new CashFlow();

        #endregion

        #region Companies
        public struct Company
        {
			public string Name;
			public string AbbrName;
			public string Category;
			public string Email;
			public string Phone;
			public string url;
			public string[] Address;
			public string[] Notes;
			public int ProcessingTime;
			public Company(string Name, string AbbrName, string Category, string Email, string Phone, string url, string[] Address, string[] Notes, int ProcessingTime)
			{
				this.Name = Name;
				this.AbbrName = AbbrName;
				this.Category = Category;
				this.Email = Email;
				this.Phone = Phone;
				this.url = url;
				this.Address = Address;
				this.Notes = Notes;
				this.ProcessingTime = ProcessingTime;
	        }

        }

        public static List<Company> Companies = new List<Company>();
        public static System.Windows.Forms.AutoCompleteStringCollection ACS = new AutoCompleteStringCollection();
        public static string[] sACS;
        #endregion

        public enum SumMode { Weekly, Monthly, Semester, Quarterly, AAnualy, CAnualy, All };
        public static SumMode SummingMode = SumMode.All;
        public static bool IncPrevious = true;
        #endregion

        public Main()
        {
            InitializeComponent();
            this.Show();
            LoadData();
        }

        public static void CheckURI()
        {
            string URI = Environment.CurrentDirectory;
            string FullURI = Path.Combine(URI, "Data");
            if (!Directory.Exists(FullURI))
                Directory.CreateDirectory(FullURI);
        }

		#region LoadData
        private void LoadData()
        {
            CheckURI();
            if (File.Exists("Data\\Finance.rc"))
            {
                //try
                //{
                    FileStream FS = new FileStream("Data\\Finance.rc", FileMode.Open);
                    XmlSerializer XSR = new XmlSerializer(typeof(SFinanceRC));
                    RC = (SFinanceRC)XSR.Deserialize(FS);
                    FS.Dispose();
                //}
                //catch { MessageBox.Show("Filestream is being silly pleb"); }
            }
            else
            {
                FinanceRC FRC = new FinanceRC(true);
                FRC.ShowDialog();
            }

            if (File.Exists("Data\\Transactions.xml"))
            {
                FileStream FS = new FileStream("Data\\Transactions.xml", FileMode.Open);
                XmlSerializer XSR = new XmlSerializer(typeof(CashFlow));
                Transactions = (CashFlow) XSR.Deserialize(FS);
                FS.Dispose();
                DisplayTransIn();
                DisplayTransOut();
            }

            if (File.Exists("Data\\Companies.xml"))
            {
                FileStream FS = new FileStream("Data\\Companies.xml", FileMode.Open);
                XmlSerializer XSR = new XmlSerializer(typeof(List<Company>));
                Companies = (List<Company>)XSR.Deserialize(FS);

                List<string> lACS = new List<string>();
                foreach (Company C in Companies)
				{
					ACS.Add(C.Name);
                    lACS.Add(C.Name);
				}
                sACS = lACS.ToArray();

                FS.Dispose();
            }
        }

        private void DisplayTransIn()
        {
            LBIn.Items.Clear();
            foreach (Transaction T in Transactions.In)
            {
                string str = T.Name;
                if (T.Repeat.HasValue)
                {
                    str += "*";
                }
                LBIn.Items.Add(str);
            }
        }

        private void DisplayTransOut()
        {
            LBOut.Items.Clear();
            foreach (Transaction T in Transactions.Out)
            {
                string str = T.Name;
                if (T.Repeat.HasValue) str += "*";
                LBOut.Items.Add(str);
            }
        }
		#endregion

		#region WriteData
        public static void SaveRC()
        {
            try
            {
                CheckURI();
                FileStream FS = new FileStream("Data\\Finance.rc", FileMode.Create);
                XmlSerializer XSR = new XmlSerializer(typeof(SFinanceRC));
                XSR.Serialize(FS, RC);
                FS.Dispose();
            }
            catch
            {

            }
        }

        public static void UpdateTransactions(Transaction T, bool? IsIn)
        {
            if (IsIn.HasValue)
            {
                if (IsIn.Value)
                {
                    List<Transaction> L = Transactions.In;
                    L.Add(T);
                    Transactions.In = L;
                }
                else
                {
                    List<Transaction> L = Transactions.Out;
                    L.Add(T);
                    Transactions.Out = L;
                }
            }
            else
            {
                List<Transaction> L = Transactions.WishList;
                L.Add(T);
                Transactions.WishList = L;
            }
        }

        public static void RemoveTransaction(int Index, bool? IsIn)
        {
            if (IsIn.HasValue)
            {
                if (IsIn.Value)
                    Transactions.In.RemoveAt(Index);
                else
                    Transactions.Out.RemoveAt(Index);
            }
			else
                Transactions.WishList.RemoveAt(Index);
        }

        public static void SaveTransactions()
        {
            CheckURI();
            //string URI = Environment.CurrentDirectory;
            FileStream FS = new FileStream("Data\\Transactions.xml", FileMode.Create);
            XmlSerializer XSR = new XmlSerializer(typeof(Main.CashFlow));
            XSR.Serialize(FS, Transactions);
            FS.Dispose();
        }
		#endregion

        public static string CheckCompanies(string STRInput)
        {
            if (STRInput == "")
                return "";
            foreach (Main.Company C in Main.Companies)
            {
                if (C.Name == STRInput || C.AbbrName == STRInput)
                    return C.Name;
            }
            CCompany CC = new CCompany(STRInput);
            CC.ShowDialog();
            return CCompany.GetReturnValue();
        }

        public static string SetCategory(string STRInput)
        {
            foreach (Company C in Companies)
                if (C.Name == STRInput)
                    return C.Category;
            return null;
        }

        #region EventHandlers
		#region FormInvocation
        private void financeRCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinanceRC FRC = new FinanceRC(false);
            FRC.Show();
        }

        private void ReviewTransIn(object sender, EventArgs e)
        {
            TransEdit TE = new TransEdit(LBIn.SelectedIndex, true);
            TE.ShowDialog();
        }

        private void ReviewTransOut(object sender, EventArgs e)
        {
            TransEdit TE = new TransEdit(LBIn.SelectedIndex, false);
            TE.ShowDialog();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory I = new Inventory(null);
            I.ShowDialog();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CCompany C = new CCompany("");
            C.ShowDialog();
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransEdit TE = new TransEdit(null, true);
            TE.ShowDialog();
        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransEdit TE = new TransEdit(null, false);
            TE.ShowDialog();
        }
		#endregion

        private void Main_Enter(object sender, EventArgs e)
        {
            LoadData();
            LBLIn.Text = SumThings.Sum(true).ToString();
            LBLOut.Text = SumThings.Sum(false).ToString();
        }

		#region SetTimeRange
        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummingMode = SumMode.Weekly;
            LBLSumMode.Text = "Sum Mode: Week";
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummingMode = SumMode.Monthly;
            LBLSumMode.Text = "Sum Mode: Month";
        }

        private void termlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummingMode = SumMode.Semester;
            LBLSumMode.Text = "Sum Mode: Semester";
        }

        private void quarterlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummingMode = SumMode.Quarterly;
            LBLSumMode.Text = "Sum Mode: Quarter";
        }

        private void anualyCalendarYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummingMode = SumMode.CAnualy;
            LBLSumMode.Text = "Sum Mode: Year (Calendar)";
        }

        private void anualyAcademicYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummingMode = SumMode.AAnualy;
            LBLSumMode.Text = "Sum Mode: Year (Academic)";
        }

        private void everyTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummingMode = SumMode.All;
            LBLSumMode.Text = "Sum Mode: All";
        }
        #endregion
        #endregion
    }
}
