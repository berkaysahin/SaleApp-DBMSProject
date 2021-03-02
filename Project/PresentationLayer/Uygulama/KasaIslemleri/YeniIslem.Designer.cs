
namespace Uygulama.KasaIslemleri
{
    partial class YeniIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniIslem));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMusteriListesi = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Barkodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.labelMusteriID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKaydet.Location = new System.Drawing.Point(720, 344);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 42);
            this.btnKaydet.TabIndex = 46;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Chocolate;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(109, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 22);
            this.label11.TabIndex = 45;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Toplam Tutar :";
            // 
            // btnMusteriListesi
            // 
            this.btnMusteriListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriListesi.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriListesi.Image")));
            this.btnMusteriListesi.Location = new System.Drawing.Point(215, 26);
            this.btnMusteriListesi.Name = "btnMusteriListesi";
            this.btnMusteriListesi.Size = new System.Drawing.Size(25, 24);
            this.btnMusteriListesi.TabIndex = 32;
            this.btnMusteriListesi.UseVisualStyleBackColor = true;
            this.btnMusteriListesi.Click += new System.EventHandler(this.btnMusteriListesi_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(708, 87);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(96, 28);
            this.btnUrunSil.TabIndex = 38;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkodu,
            this.UrunAdi,
            this.KategoriAdi,
            this.BirimAdi,
            this.Miktar,
            this.BirimFiyat,
            this.UrunTutari,
            this.UrunID});
            this.dataGridView1.Location = new System.Drawing.Point(15, 119);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 211);
            this.dataGridView1.TabIndex = 37;
            // 
            // Barkodu
            // 
            this.Barkodu.DataPropertyName = "Barkodu";
            this.Barkodu.HeaderText = "Barkodu";
            this.Barkodu.MinimumWidth = 6;
            this.Barkodu.Name = "Barkodu";
            this.Barkodu.ReadOnly = true;
            this.Barkodu.Width = 125;
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Ürün";
            this.UrunAdi.MinimumWidth = 6;
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            this.UrunAdi.Width = 140;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.DataPropertyName = "KategoriAdi";
            this.KategoriAdi.HeaderText = "Kategori";
            this.KategoriAdi.MinimumWidth = 6;
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.ReadOnly = true;
            this.KategoriAdi.Width = 125;
            // 
            // BirimAdi
            // 
            this.BirimAdi.DataPropertyName = "BirimAdi";
            this.BirimAdi.HeaderText = "Birim";
            this.BirimAdi.MinimumWidth = 6;
            this.BirimAdi.Name = "BirimAdi";
            this.BirimAdi.ReadOnly = true;
            this.BirimAdi.Width = 70;
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.MinimumWidth = 6;
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            this.Miktar.Width = 70;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            this.BirimFiyat.HeaderText = "Fiyat";
            this.BirimFiyat.MinimumWidth = 6;
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.ReadOnly = true;
            this.BirimFiyat.Width = 125;
            // 
            // UrunTutari
            // 
            this.UrunTutari.DataPropertyName = "UrunTutari";
            this.UrunTutari.HeaderText = "UrunTutari";
            this.UrunTutari.MinimumWidth = 6;
            this.UrunTutari.Name = "UrunTutari";
            this.UrunTutari.ReadOnly = true;
            this.UrunTutari.Visible = false;
            this.UrunTutari.Width = 125;
            // 
            // UrunID
            // 
            this.UrunID.DataPropertyName = "UrunID";
            this.UrunID.HeaderText = "UrunID";
            this.UrunID.MinimumWidth = 6;
            this.UrunID.Name = "UrunID";
            this.UrunID.ReadOnly = true;
            this.UrunID.Visible = false;
            this.UrunID.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Miktar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 22);
            this.textBox3.TabIndex = 35;
            this.textBox3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Barkod";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(15, 92);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(159, 22);
            this.txtBarkod.TabIndex = 33;
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // labelMusteriID
            // 
            this.labelMusteriID.BackColor = System.Drawing.Color.Chocolate;
            this.labelMusteriID.Location = new System.Drawing.Point(12, 26);
            this.labelMusteriID.Name = "labelMusteriID";
            this.labelMusteriID.Size = new System.Drawing.Size(219, 24);
            this.labelMusteriID.TabIndex = 31;
            this.labelMusteriID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Satış Yapılan Müşteri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fatura Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(247, 91);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 47;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // YeniIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 419);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMusteriListesi);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.labelMusteriID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "YeniIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni İşlem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YeniIslem_FormClosing);
            this.Load += new System.EventHandler(this.YeniIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMusteriListesi;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarkod;
        public System.Windows.Forms.Label labelMusteriID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunID;
    }
}