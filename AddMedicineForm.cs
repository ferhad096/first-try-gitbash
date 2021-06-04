using MedicineApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineApp
{
    public partial class cmbTags : Form
    {
        MedicineDBK209Context db = new MedicineDBK209Context();
        public cmbTags()
        {
            InitializeComponent();
        }

        public int GetFirmId(string firm)
        {
            Firm selectedFirm = db.Firms.FirstOrDefault(x => x.Name == firm);
            if (selectedFirm == null)
            {
                Firm newFirm = new Firm()
                {
                    Name = firm
                };
                db.Firms.Add(newFirm);
                db.SaveChanges();

                return newFirm.Id;
            }
            return selectedFirm.Id;
        }

        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string medicineName = txtMedName.Text;
            string desc = rcDescription.Text;
            decimal price = nmPrice.Value;
            decimal quantity = nmQuantity.Value;
            string firmName = cmbFirms.Text;
            string tagName = cmbTag.Text;
            DateTime proDate = dtProduction.Value;
            DateTime exDate = dtExpire.Value;
            Medicine newMedicine = new Medicine()
            {
                Name = medicineName,
                Price = price,
                Count = (int)quantity,
                Description = desc,
                ProductionDate = proDate,
                ExpireDate = exDate,
                IsReceipt = ckReceipt.Checked,
                FirmId = GetFirmId(firmName)
            };
            db.Medicines.Add(newMedicine);
            db.SaveChanges();
            MessageBox.Show("Medicine added success!");
        }
    }
}
