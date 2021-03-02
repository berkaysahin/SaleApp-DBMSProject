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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        public AnaEkran a;

        void temizle()
        {
            textBoxID.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void birimleriDoldur()
        {
            DataTable dt = new DataTable();
            DataLogic.BIRIM birim = new DataLogic.BIRIM();
            dt = birim.getirBirimler();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "BirimAdi";
            comboBox1.ValueMember = "BirimID";
        }

        void kategorileriDoldur()
        {
            DataTable dt = new DataTable();
            DataLogic.KATEGORI kategori = new DataLogic.KATEGORI();
            dt = kategori.getirKategoriler();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "KategoriAdi";
            comboBox2.ValueMember = "KategoriID";
        }

        void urunleriGetir()
        {
            DataLogic.URUN urun = new DataLogic.URUN();
            DataTable dt = new DataTable();

            dt = urun.getirUrunler();
            dataGridView1.DataSource = dt;
        }
        private void Urunler_Load(object sender, EventArgs e)
        {
            birimleriDoldur();
            kategorileriDoldur();
            urunleriGetir();
        }

        private void Urunler_FormClosed(object sender, FormClosedEventArgs e)
        {
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox4.Text.Trim() == "" || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Bütün Alanlar Doldurulmak Zorundadır", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataLogic.URUN urun = new DataLogic.URUN();
            Entities.URUN d = new Entities.URUN();

            d.Adi = textBox1.Text.ToUpper();
            d.Barkodu = textBox2.Text;
            d.SatisFiyati = Convert.ToDouble(textBox4.Text);
            d.BirimID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            d.KategoriID = Convert.ToInt32(comboBox2.SelectedValue.ToString());

            int a = -1;
            if (textBoxID.Text != "") //ID nin tutulduğu textBox
            {
                d.UrunID = Convert.ToInt32(textBoxID.Text);
                a = urun.guncelleUrun(d);
            }
            else
                a = urun.kaydetUrun(d);

            if (a == 1)
            {
                MessageBox.Show("İşleminiz Gerçekleştirildi", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                urunleriGetir();
            }
            else
                MessageBox.Show("İşleminiz Yapılamadı", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            DialogResult sonuc = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz?",
                "Satış Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value.ToString());
                DataLogic.URUN m = new DataLogic.URUN();
                int a = m.silUrunler(id);
                if (a == 1)
                {
                    MessageBox.Show("İşleminiz Gerçekleştirildi",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                    urunleriGetir();
                }
                else
                    MessageBox.Show("İşleminiz Yapılamadı",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            textBoxID.Text = dataGridView1.CurrentRow.Cells["UrunID"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Barkodu"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["SatisFiyati"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["BirimAdi"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["KategoriAdi"].Value.ToString();
        }
    }
}
