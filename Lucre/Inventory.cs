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
    public partial class Inventory : Form
    {
        public Inventory(int? Index)
        {
            InitializeComponent();
            LoadInventory();
            LoadList();

            try
            {
                CBCompany.AutoCompleteCustomSource = Main.ACS;
                CBCompany.Items.AddRange(Main.sACS);
            }
            catch {  }
        }

        public struct SInventory
        {
            public string Name;
            public decimal Cost;
            public int Quantity;
            public DateTime PurchasedOn;
            public string Category;
            public string Company;
            public bool ToInsure;
            public Main.Duration? Warranty;

            public SInventory(string Name, decimal Cost, int Quantity, DateTime PurchasedOn, string Category, string Company, bool ToInsure, Main.Duration? Warranty)
			{
				this.Name = Name;
				this.Cost = Cost;
				this.Quantity = Quantity;
				this.PurchasedOn = PurchasedOn;
				this.Category = Category;
				this.Company = Company;
                this.ToInsure = ToInsure;
				this.Warranty = Warranty;
			}
        }

        public List<SInventory> TheInventory = new List<SInventory>();

        private void LoadInventory()
        {
            if (File.Exists("Inventory.xml"))
            {
                FileStream FS = new FileStream("Inventory.xml", FileMode.Open);
                XmlSerializer XSR = new XmlSerializer(typeof(List<SInventory>));
                TheInventory = (List<SInventory>)XSR.Deserialize(FS);
                FS.Dispose();
            }
        }

        private void LoadList()
        {
            LBInventory.Items.Clear();
            foreach (SInventory I in TheInventory)
            {
                string Str = I.Name;
                if (I.ToInsure) Str += "*";
                LBInventory.Items.Add(Str);
            }
            GetTotal();
        }

        private void LoadItem(object sender, EventArgs e)
        {
            SInventory I = TheInventory[LBInventory.SelectedIndex];
            TBName.Text = I.Name;
            NUCost.Value = I.Cost;
            NUQuantity.Value = I.Quantity;
            DTPPurchasedOn.Value = I.PurchasedOn;
            CBCompany.Text = I.Company;
            CBCategory.Text = I.Category;
            ChBToInsure.Checked = I.ToInsure;

            if (I.Warranty.HasValue)
            {
                ChBWarranty.Checked = true;
                DTPWarrantyStart.Value = I.Warranty.Value.Start;
                DTPWarrantyEnd.Value = I.Warranty.Value.End;
            }
            BTNWrite.Text = "Update";
        }

        private void SaveInventory()
        {
            FileStream FS = new FileStream("Inventory.xml", FileMode.Create);
            XmlSerializer XSR = new XmlSerializer(typeof(List<SInventory>));
            XSR.Serialize(FS, TheInventory);
            FS.Dispose();
        }

        private Main.Duration? GetWarrantyDuration()
        {
            if (ChBWarranty.Checked)
                return new Main.Duration(DTPWarrantyStart.Value, DTPWarrantyEnd.Value);
            else return null;
        }

        private void GetTotal()
        {
            decimal Total = 0;
            foreach (SInventory I in TheInventory)
                Total += I.ToInsure ? I.Cost : 0;
            LBLTotal.Text = "£" + Total.ToString();
        }

        private string MultiCost()
        {
            if (ChBCostPerUnit.Checked)
                return "Total Cost: " + (NUQuantity.Value * NUCost.Value).ToString("C");
            else return "Cost per item: " + (NUCost.Value / NUQuantity.Value).ToString("C");
        }

        private void ChBWarranty_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBWarranty.Checked)
            {
                GBWarranty.Visible = true;
                GBWarranty.Enabled = true;
            }
            else
            {
                GBWarranty.Visible = false;
                GBWarranty.Enabled = false;
            }
        }

        private void NUQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (NUQuantity.Value > 1)
            {
                ChBCostPerUnit.Visible = true;
                ChBCostPerUnit.Enabled = true;
                NUQuantity.Size = new Size(40, NUQuantity.Size.Height);

                //TTAltPrice.SetToolTip(this.NUCost, MultiCost());
                TTAltPrice.Show(MultiCost(),this.NUCost);
            }
            else
            {
                ChBCostPerUnit.Visible = false;
                ChBCostPerUnit.Enabled = false;
                NUQuantity.Size = new Size(120, NUQuantity.Size.Height);                
            }
        }

        private void BTNWrite_Click(object sender, EventArgs e)
        {
            CBCompany.Text = Main.CheckCompanies(CBCompany.Text);

            SInventory I = new SInventory(TBName.Text, NUCost.Value,
                int.Parse(NUQuantity.Value.ToString()), DTPPurchasedOn.Value,
                CBCategory.Text, CBCompany.Text, ChBToInsure.Checked,
                GetWarrantyDuration());
            TheInventory.Add(I);
            if (BTNWrite.Text == "Update")
                TheInventory.RemoveAt(LBInventory.SelectedIndex);
            SaveInventory();
            LoadInventory();
            LoadList();
        }

        private void ChBCostPerUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (NUQuantity.Value > 1)       // Needed because used for Cost_Changed event
                TTAltPrice.Show(MultiCost(), this.NUCost);
        }

        private void CompanyChanged(object sender, EventArgs e)
        {
            if (CBCategory.Text == "")
                CBCategory.Text = Main.SetCategory(CBCompany.Text);
        }
    }
}
