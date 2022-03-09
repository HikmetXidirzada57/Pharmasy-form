
namespace PharmacyApp
{
    partial class AddMedicine
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMediName = new System.Windows.Forms.TextBox();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rcDescrption = new System.Windows.Forms.RichTextBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.cbRecept = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.CmbTags = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtProduction = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtExpire = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbTag = new System.Windows.Forms.CheckedListBox();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = " Medicine Name";
            // 
            // txtMediName
            // 
            this.txtMediName.Location = new System.Drawing.Point(22, 71);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.Size = new System.Drawing.Size(202, 27);
            this.txtMediName.TabIndex = 6;
            // 
            // nmPrice
            // 
            this.nmPrice.Location = new System.Drawing.Point(22, 184);
            this.nmPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(150, 27);
            this.nmPrice.TabIndex = 7;
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(22, 305);
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(150, 27);
            this.nmQuantity.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrition";
            // 
            // rcDescrption
            // 
            this.rcDescrption.Location = new System.Drawing.Point(12, 486);
            this.rcDescrption.Name = "rcDescrption";
            this.rcDescrption.Size = new System.Drawing.Size(202, 120);
            this.rcDescrption.TabIndex = 11;
            this.rcDescrption.Text = "";
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMedicine.ForeColor = System.Drawing.Color.Green;
            this.btnAddMedicine.Location = new System.Drawing.Point(22, 624);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(150, 49);
            this.btnAddMedicine.TabIndex = 12;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // cbRecept
            // 
            this.cbRecept.AutoSize = true;
            this.cbRecept.Location = new System.Drawing.Point(189, 305);
            this.cbRecept.Name = "cbRecept";
            this.cbRecept.Size = new System.Drawing.Size(102, 24);
            this.cbRecept.TabIndex = 13;
            this.cbRecept.Text = "Is Receipt?";
            this.cbRecept.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Firms";
            // 
            // cmbFirms
            // 
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(23, 45);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(170, 28);
            this.cmbFirms.TabIndex = 15;
            // 
            // CmbTags
            // 
            this.CmbTags.FormattingEnabled = true;
            this.CmbTags.Location = new System.Drawing.Point(377, 55);
            this.CmbTags.Name = "CmbTags";
            this.CmbTags.Size = new System.Drawing.Size(170, 28);
            this.CmbTags.TabIndex = 17;
            this.CmbTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbTags_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(377, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tags";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "ProductionDate";
            // 
            // dtProduction
            // 
            this.dtProduction.Location = new System.Drawing.Point(23, 147);
            this.dtProduction.Name = "dtProduction";
            this.dtProduction.Size = new System.Drawing.Size(182, 27);
            this.dtProduction.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Expire Date";
            // 
            // dtExpire
            // 
            this.dtExpire.Location = new System.Drawing.Point(23, 220);
            this.dtExpire.Name = "dtExpire";
            this.dtExpire.Size = new System.Drawing.Size(182, 27);
            this.dtExpire.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.clbTag);
            this.panel1.Controls.Add(this.dtProduction);
            this.panel1.Controls.Add(this.dtExpire);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbFirms);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CmbTags);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(332, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 685);
            this.panel1.TabIndex = 22;
            // 
            // clbTag
            // 
            this.clbTag.FormattingEnabled = true;
            this.clbTag.Location = new System.Drawing.Point(377, 111);
            this.clbTag.Name = "clbTag";
            this.clbTag.Size = new System.Drawing.Size(170, 136);
            this.clbTag.TabIndex = 22;
            this.clbTag.SelectedIndexChanged += new System.EventHandler(this.clbTag_SelectedIndexChanged);
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicine.Location = new System.Drawing.Point(332, 407);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.RowHeadersWidth = 51;
            this.dtgMedicine.RowTemplate.Height = 29;
            this.dtgMedicine.Size = new System.Drawing.Size(618, 276);
            this.dtgMedicine.TabIndex = 23;
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(12, 389);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(175, 27);
            this.barcode.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Barcode";
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 685);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.dtgMedicine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.cbRecept);
            this.Controls.Add(this.rcDescrption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMedicine";
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMediName;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rcDescrption;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.CheckBox cbRecept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.ComboBox CmbTags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtProduction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtExpire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clbTag;
        private System.Windows.Forms.DataGridView dtgMedicine;
        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.Label label9;
    }
}