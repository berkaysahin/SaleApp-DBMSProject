namespace Uygulama.Tanımlamalar
{
    partial class Kategoriler
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 43);
            this.button2.TabIndex = 22;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategoriAdi,
            this.KategoriID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(281, 225);
            this.dataGridView1.TabIndex = 21;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.DataPropertyName = "KategoriAdi";
            this.KategoriAdi.HeaderText = "Kategori";
            this.KategoriAdi.MinimumWidth = 6;
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.ReadOnly = true;
            this.KategoriAdi.Width = 200;
            // 
            // KategoriID
            // 
            this.KategoriID.DataPropertyName = "KategoriID";
            this.KategoriID.HeaderText = "KategoriID";
            this.KategoriID.MinimumWidth = 6;
            this.KategoriID.Name = "KategoriID";
            this.KategoriID.ReadOnly = true;
            this.KategoriID.Visible = false;
            this.KategoriID.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kategori Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 18;
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 347);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kategoriler_FormClosed);
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}