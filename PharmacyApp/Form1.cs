using PharmacyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Form1 : Form
    {
         PharmasyDBT110Context pdb = new PharmasyDBT110Context();
         Medicine selectedmedicine;

        public Form1()
        {
            InitializeComponent();
        }



        private void FillMedicineCombo()
        {
            cmbBymedicine.Items.AddRange(pdb.Medicines.Select(x => x.Name).ToArray());
        }
        private void FillTagsCombo()
        {
            cmbbyTag.Items.AddRange(pdb.Tags.Select(x => x.Name).ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillMedicineCombo();
            FillTagsCombo();
            FillMedicineGrid();

        }
        private void FillMedicineGrid()
        {
            dataGridView1.DataSource = pdb.Tagtomedicines.
                Where(x=>x.Medicine.Name.Contains(cmbBymedicine.Text) && x.Tag.Name.Contains(cmbbyTag.Text)).Select(x => new
            {
                 x.MedicineId,
                 MedicineName= x.Medicine.Name,
                 x.Medicine.Price,
                 x.Medicine.Quantity,
                 Recept = x.Medicine.IsReceipt ? "Resepted" : "Without Recept",
                 x.Medicine.ProductionDate,
                 x.Medicine.ExpireDaTe
            }).Distinct().ToList();
            dataGridView1.Columns[0].Visible = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int quantity = (int)dataGridView1.Rows[i].Cells[3].Value;
                if (quantity==0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                }
            }
        }

        private void cmbBymedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMedicineGrid();
        }

        private void cmbBymedicine_KeyUp(object sender, KeyEventArgs e)
        {
            FillMedicineGrid();
        }

        private void cmbbyTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMedicineGrid();
        }

        private void cmbbyTag_KeyUp(object sender, KeyEventArgs e)
        {
            FillMedicineGrid();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int medicineId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
           selectedmedicine= pdb.Medicines.FirstOrDefault(x => x.MedicineId == medicineId);

            if (selectedmedicine.Quantity>0)
            {
                txtMedicinename.Text = selectedmedicine.Name;
                panel2.Visible = true;
                nmQuantity.Value = 1;
                nmQuantity.Maximum = selectedmedicine.Quantity;
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string medname = txtMedicinename.Text;
            int quantity = (int)nmQuantity.Value;
            bool isCorrect = false;
            if ( clbTag.Items.Count==0)
            {
                clbTag.Items.Add(medname + "~" + quantity, true);
            }
            for (int i = 0; i < clbTag.Items.Count; i++)
            {
                var item = clbTag.Items[i];
                var currentname = item.ToString().Split('~')[0];
                if (medname==currentname)
                {

                    clbTag.Items.Remove(item);
                    var quant = Convert.ToInt32(item.ToString().Split('~')[1]);
                    quant += quantity;
                    clbTag.Items.Add(medname + "~" + quant, true);
                    isCorrect = true;
                }            
            }
            if (!isCorrect)
            {
                clbTag.Items.Add(medname + "~" + quantity, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Message="";
            decimal TotalPrice=0;
            foreach (var item in clbTag.Items)
            {
                string medName = item.ToString().Split('~')[0];
                Medicine selecmed = pdb.Medicines.FirstOrDefault(x => x.Name == medName);
                int quantity= Convert.ToInt32(item.ToString().Split('~')[1]);
                Message += $"Derman adi:{medName}, sayi:{quantity}, qiymet:{selecmed.Price *quantity}\n";
                TotalPrice += selecmed.Price * quantity;
                selecmed.Quantity -= quantity;
                pdb.SaveChanges();
            }
            MessageBox.Show(Message + "\n" + "Umumi Qiymet:" + TotalPrice, "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillMedicineGrid();
        }

        private void medicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMedicine adm = new();
            adm.ShowDialog();
        }
    }
}
