
namespace Uygulama.KasaIslemleri
{
    partial class MusteriListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdiSoyadi,
            this.Telefonu,
            this.Adresi,
            this.MusteriID});
            this.dataGridView1.Location = new System.Drawing.Point(11, 15);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(483, 324);
            this.dataGridView1.TabIndex = 10;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.DataPropertyName = "AdiSoyadi";
            this.AdiSoyadi.HeaderText = "Adı Soyadı";
            this.AdiSoyadi.MinimumWidth = 6;
            this.AdiSoyadi.Name = "AdiSoyadi";
            this.AdiSoyadi.ReadOnly = true;
            this.AdiSoyadi.Width = 140;
            // 
            // Telefonu
            // 
            this.Telefonu.DataPropertyName = "Telefonu";
            this.Telefonu.HeaderText = "Telefonu";
            this.Telefonu.MinimumWidth = 6;
            this.Telefonu.Name = "Telefonu";
            this.Telefonu.ReadOnly = true;
            this.Telefonu.Width = 140;
            // 
            // Adresi
            // 
            this.Adresi.DataPropertyName = "Adresi";
            this.Adresi.HeaderText = "Adresi";
            this.Adresi.MinimumWidth = 6;
            this.Adresi.Name = "Adresi";
            this.Adresi.ReadOnly = true;
            this.Adresi.Width = 200;
            // 
            // MusteriID
            // 
            this.MusteriID.DataPropertyName = "MusteriID";
            this.MusteriID.HeaderText = "MusteriID";
            this.MusteriID.MinimumWidth = 6;
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.ReadOnly = true;
            this.MusteriID.Visible = false;
            this.MusteriID.Width = 125;
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.ForeColor = System.Drawing.Color.Maroon;
            this.btnSec.Location = new System.Drawing.Point(416, 345);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(78, 48);
            this.btnSec.TabIndex = 9;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSec);
            this.Name = "MusteriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.MusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriID;
        private System.Windows.Forms.Button btnSec;
    }
}