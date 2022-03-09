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
    public partial class AddMedicine : Form
    {
       private  PharmasyDBT110Context pdb = new PharmasyDBT110Context();
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string medname = txtMediName.Text;
            decimal price = nmPrice.Value;
            decimal quantity = nmQuantity.Value;
            string desc = rcDescrption.Text;
            string tagname = CmbTags.Text;
            string firmName = cmbFirms.Text;
            DateTime prodate = dtProduction.Value;
            DateTime expdate = dtExpire.Value;
            bool isReceipt = cbRecept.Checked;

            string[] medString = new string[] { medname, desc, tagname, firmName };
            if (Utilities.IsEmpty(medString))
            {
                if (prodate<expdate)
                {
                    int FirmId = FindFirmId(firmName);

                    Medicine med = new()
                    {
                        Name = medname,
                        Price = price,
                        Quantity = (int)quantity,
                        Descrption = desc,
                        ProductionDate = prodate,
                        ExpireDaTe = expdate,
                        FirmId = FirmId,
                        IsReceipt = cbRecept.Checked ? true : false
                        
                    };
                    pdb.Medicines.Add(med);
                    pdb.SaveChanges();
                    AddTagMedicine(med.MedicineId);
                    MessageBox.Show("Derman elave edildi");
                    FillMedicineGrid();
                 }
                else
                {
                    MessageBox.Show("Date isn't correct");

                }
            }
            else
            {
                MessageBox.Show("Please all the fields","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            FillFirmCombo();
            FillTagCombo();
            FillMedicineGrid(); 
        }
        private void FillFirmCombo()
        {
            cmbFirms.Items.AddRange(pdb.Firms.Select(x => x.Name).ToArray());
        }

        private void FillTagCombo()
        {
            CmbTags.Items.AddRange(pdb.Tags.Select(x => x.Name).ToArray());
        }
        private void FillMedicineGrid()
        {
            dtgMedicine.DataSource = pdb.Medicines.Select(x => new
            {
                txtMediName=x.Name,
                nmPrice=x.Price,
                nmQuantity=x.Quantity,
                cbRecept=x.IsReceipt ? "Recepted":"Without Recept",
                x.ProductionDate,
                x.ExpireDaTe
            }).ToList();

        }

    
        private int HasTag(string tagname)
        {
            Tag selectedTag = pdb.Tags.FirstOrDefault(x => x.Name == tagname);
            if (selectedTag == null)
            {
                Tag newTag = new()
                {
                    Name = tagname
                };
               
                pdb.Tags.Add(newTag);
                pdb.SaveChanges();
                return newTag.TagId;
            }
            return selectedTag.TagId;
        }

        private void AddTagMedicine(int medicineId)
        {
                foreach (var item in clbTag.Items)
                {
                    int tagId = HasTag(item.ToString());
                    Tagtomedicine newtag = new()
                    {
                        MedicineId = medicineId,
                        TagId=tagId
                   
                    };
                pdb.Tagtomedicines.Add(newtag);
                pdb.SaveChanges();
            }
        }

        public int FindFirmId(string firmName)
        {
           Firm currentFirm= pdb.Firms.FirstOrDefault(x => x.Name == firmName);

            if (currentFirm==null)
            {
                Firm newFirm = new()
                {
                    Name = firmName
                };
                pdb.Firms.Add(newFirm);
                pdb.SaveChanges();

                return newFirm.FirmId;
            }

            return currentFirm.FirmId;
        }

        private void CmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            string tagname = CmbTags.Text;
            if (e.KeyCode==Keys.Enter)
            {
                if (!clbTag.Items.Contains(tagname))
                {
                    clbTag.Items.Add(tagname, true);
                    CmbTags.Text = "";
                }
            }
        }

        private void clbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedtag = clbTag.SelectedIndex; 
            if (selectedtag!=-1)
            {
                clbTag.Items.RemoveAt(selectedtag);
            }
        }
        private void ClearItem()
        {
            foreach (var item in panel1.Controls)
            {
                if (item is TextBox  || item is ComboBox || item is RichTextBox)
                {
                    var d = (Control)item;
                    d.Text = "";
                }
             
                else if (item is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)item;
                    nud.Value = 1;
                }
                else if (item is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)item;
                    clb.Items.Clear();
                }
            }
        }
    }
}
