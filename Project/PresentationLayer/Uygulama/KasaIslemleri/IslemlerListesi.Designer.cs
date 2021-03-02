
namespace Uygulama.KasaIslemleri
{
    partial class IslemlerListesi
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
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SorumluID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.SorumluID,
            this.MusteriID,
            this.AdiSoyadi,
            this.ToplamTutar,
            this.AdSoyad,
            this.SatisID});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(628, 349);
            this.dataGridView1.TabIndex = 10;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Width = 125;
            // 
            // SorumluID
            // 
            this.SorumluID.DataPropertyName = "SorumluID";
            this.SorumluID.HeaderText = "SorumluID";
            this.SorumluID.MinimumWidth = 6;
            this.SorumluID.Name = "SorumluID";
            this.SorumluID.ReadOnly = true;
            this.SorumluID.Visible = false;
            this.SorumluID.Width = 125;
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
            // AdiSoyadi
            // 
            this.AdiSoyadi.DataPropertyName = "AdiSoyadi";
            this.AdiSoyadi.HeaderText = "Müşteri Adı Soyadı";
            this.AdiSoyadi.MinimumWidth = 6;
            this.AdiSoyadi.Name = "AdiSoyadi";
            this.AdiSoyadi.ReadOnly = true;
            this.AdiSoyadi.Width = 160;
            // 
            // ToplamTutar
            // 
            this.ToplamTutar.DataPropertyName = "ToplamTutar";
            this.ToplamTutar.HeaderText = "Toplam Tutar";
            this.ToplamTutar.MinimumWidth = 6;
            this.ToplamTutar.Name = "ToplamTutar";
            this.ToplamTutar.ReadOnly = true;
            this.ToplamTutar.Width = 140;
            // 
            // AdSoyad
            // 
            this.AdSoyad.DataPropertyName = "AdSoyad";
            this.AdSoyad.HeaderText = "Sorumlu Kişi";
            this.AdSoyad.MinimumWidth = 6;
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.ReadOnly = true;
            this.AdSoyad.Width = 200;
            // 
            // SatisID
            // 
            this.SatisID.DataPropertyName = "SatisID";
            this.SatisID.HeaderText = "SatisID";
            this.SatisID.MinimumWidth = 6;
            this.SatisID.Name = "SatisID";
            this.SatisID.ReadOnly = true;
            this.SatisID.Visible = false;
            this.SatisID.Width = 125;
            // 
            // IslemlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 381);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IslemlerListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IslemlerListesi_FormClosing);
            this.Load += new System.EventHandler(this.IslemlerListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SorumluID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisID;
    }
}