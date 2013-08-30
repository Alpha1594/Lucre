using System;
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
                FileStream FS = new FileStream("Finance.rc", FileMode.Open);
                XmlSerializer XSR = new XmlSerializer(typeof(SFinanceRC));
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
            public Nullable<CapTime> Real;
            //public CapTime? Real;
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

        public static List<Transaction> Transactions = new List<Transaction>();
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

        #endregion

        public Main()
        {
            InitializeComponent();
            this.Show();
            LoadData();

            //string[] stArry = { "Foo", "Bar", "Baz" };
            //ACS.AddRange(stArry);
            //List<string> lACS = new List<string>(stArry);
            //MessageBox.Show(lACS.Count.ToString());
            //sACS = lACS.ToArray();
        }

        private void LoadData()
        {
            if (File.Exists("Finance.rc"))
            {
                FileStream FS = new FileStream("Finance.rc", FileMode.Open);
                XmlSerializer XSR = new XmlSerializer(typeof(SFinanceRC));
                RC = (SFinanceRC)XSR.Deserialize(FS);
                FS.Dispose();
            }
            else
            {
                FinanceRC FRC = new FinanceRC(true);
                FRC.ShowDialog();
            }

            if (File.Exists("Transactions.xml"))
            {
                FileStream FS = new FileStream("Transactions.xml", FileMode.Open);
                XmlSerializer XSR = new XmlSerializer(typeof(List<Transaction>));
                Transactions = (List<Transaction>) XSR.Deserialize(FS);
                FS.Dispose();
                DisplayTransList();
            }

            if (File.Exists("Companies.xml"))
            {
                FileStream FS = new FileStream("Companies.xml", FileMode.Open);
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

        private void DisplayTransList()
        {
            LBTransactions.Items.Clear();
            foreach (Transaction T in Transactions)
            {
                string str = T.Name;
                if (T.Repeat.HasValue) str += "*";
                LBTransactions.Items.Add(str);
            }
        }

        public static void SaveRC()
        {
            try
            {
                FileStream FS = new FileStream("Finance.rc", FileMode.Create);
                XmlSerializer XSR = new XmlSerializer(typeof(SFinanceRC));
                XSR.Serialize(FS, RC);
                FS.Dispose();
            }
            catch
            {

            }
        }

        public static void SaveTransactions()
        {
            FileStream FS = new FileStream("Transactions.xml", FileMode.Create);
            XmlSerializer XSR = new XmlSerializer(typeof(List<Transaction>));
            XSR.Serialize(FS, Transactions);
            FS.Dispose();
        }

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
            return null;
        }

        private void financeRCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinanceRC FRC = new FinanceRC(false);
            FRC.Show();
        }

        private void Main_Enter(object sender, EventArgs e)
        {
            LoadData();
            //MessageBox.Show("Should be loading");
        }

        private void ReviewTrans(object sender, EventArgs e)
        {
            TransEdit TE = new TransEdit(LBTransactions.SelectedIndex);
            TE.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TransEdit TE = new TransEdit(null);
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
    }
}