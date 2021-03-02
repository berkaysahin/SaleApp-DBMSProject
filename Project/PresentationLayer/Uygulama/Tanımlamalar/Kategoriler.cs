using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uygulama.Tanımlamalar
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        public AnaEkran a;

        void getirKategoriler()
        {
            DataTable dt = new DataTable();
            DataLogic.KATEGORI kategoriler = new DataLogic.KATEGORI();
            dt = kategoriler.getirKategoriler();
            dataGridView1.DataSource = dt;
        }
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            getirKategoriler();
        }

        private void Kategoriler_FormClosed(object sender, FormClosedEventArgs e)
        {
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Kategori Adı Alanını Doldurunuz");
                return;
            }

            DataLogic.KATEGORI kategori = new DataLogic.KATEGORI();
            Entities.KATEGORI degisken = new Entities.KATEGORI();

            degisken.KategoriAdi = textBox1.Text.ToUpper();

            int a = kategori.kaydetKategori(degisken);

            if (a == 1)
            {
                MessageBox.Show("İşleminiz Gerçekleştirildi", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                getirKategoriler();
            }
            else if (a == -1)
                MessageBox.Show("İşleminiz Yapılamadı\n\nAynı Kategori Sistemde Kayıtlı", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            DialogResult sonuc = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz?",
                "Satış Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KategoriID"].Value.ToString());
                DataLogic.KATEGORI kategori = new DataLogic.KATEGORI();

                int a = kategori.silKategori(id);

                if (a == 1)
                {
                    MessageBox.Show("İşleminiz Gerçekleştirildi",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getirKategoriler();
                }
                else
                    MessageBox.Show("İşleminiz Yapılamadı",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
