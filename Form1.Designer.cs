
namespace MedicineApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tdsAddMedicine = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAddMedicine = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAddFirm = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbByMedicine = new System.Windows.Forms.ComboBox();
            this.cmbByTags = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tdsAddMedicine});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tdsAddMedicine
            // 
            this.tdsAddMedicine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAddMedicine,
            this.tlsAddFirm});
            this.tdsAddMedicine.Name = "tdsAddMedicine";
            this.tdsAddMedicine.Size = new System.Drawing.Size(68, 20);
            this.tdsAddMedicine.Text = "Medicine";
            // 
            // tlsAddMedicine
            // 
            this.tlsAddMedicine.Name = "tlsAddMedicine";
            this.tlsAddMedicine.Size = new System.Drawing.Size(128, 22);
            this.tlsAddMedicine.Text = "Add";
            this.tlsAddMedicine.Click += new System.EventHandler(this.tlsAddMedicine_Click);
            // 
            // tlsAddFirm
            // 
            this.tlsAddFirm.Name = "tlsAddFirm";
            this.tlsAddFirm.Size = new System.Drawing.Size(128, 22);
            this.tlsAddFirm.Text = "Add Firms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "by Medicine";
            // 
            // cmbByMedicine
            // 
            this.cmbByMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbByMedicine.FormattingEnabled = true;
            this.cmbByMedicine.Location = new System.Drawing.Point(13, 72);
            this.cmbByMedicine.Name = "cmbByMedicine";
            this.cmbByMedicine.Size = new System.Drawing.Size(158, 29);
            this.cmbByMedicine.TabIndex = 3;
            // 
            // cmbByTags
            // 
            this.cmbByTags.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbByTags.FormattingEnabled = true;
            this.cmbByTags.Location = new System.Drawing.Point(227, 72);
            this.cmbByTags.Name = "cmbByTags";
            this.cmbByTags.Size = new System.Drawing.Size(158, 29);
            this.cmbByTags.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(227, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "by Tags";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbByTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbByMedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tdsAddMedicine;
        private System.Windows.Forms.ToolStripMenuItem tlsAddMedicine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbByMedicine;
        private System.Windows.Forms.ComboBox cmbByTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tlsAddFirm;
    }
}

