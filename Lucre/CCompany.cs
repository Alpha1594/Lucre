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
    public partial class CCompany : Form
    {
        public CCompany(string Name)
        {
            InitializeComponent();
            LoadCompaniesList();
            if (Name != "")
                TBName.Text = Name;
        }

        private void BTNWrite_Click(object sender, EventArgs e)
        {
            Main.Company C = new Main.Company(TBName.Text,
                TBABRName.Text, CBCategory.Text, 
                TBEmail.Text, TBPhone.Text, TBURL.Text,
                TBAddress.Lines, TBNotes.Lines,
                (int) NUProTime.Value);
            Main.Companies.Add(C);
            if (BTNWrite.Text == "Update")
                Main.Companies.RemoveAt(LBCompanies.SelectedIndex);
            WriteCompanies();
        }

        private void LBCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Main.Company C = Main.Companies[LBCompanies.SelectedIndex];

            TBName.Text = C.Name;
            TBABRName.Text = C.AbbrName;
            CBCategory.Text = C.Category;
            TBEmail.Text = C.Email;
            TBPhone.Text = C.Phone;
            TBURL.Text = C.url;
            TBAddress.Lines = C.Address;
            TBNotes.Lines = C.Notes;
            NUProTime.Value = C.ProcessingTime;

            BTNWrite.Text = "Update";
        }

        private void WriteCompanies()
        {
            FileStream FS = new FileStream("Companies.xml", FileMode.Create);
            XmlSerializer XSR = new XmlSerializer(typeof(List<Main.Company>));
            XSR.Serialize(FS, Main.Companies);
            FS.Dispose();
            LoadCompaniesList();
        }

        private void LoadCompaniesList()
        {
            LBCompanies.Items.Clear();
            foreach (Main.Company C in Main.Companies)
                LBCompanies.Items.Add(C.Name + " (" + C.AbbrName + ")");
        }
    }
}
