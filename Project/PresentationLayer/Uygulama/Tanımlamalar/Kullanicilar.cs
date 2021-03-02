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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }
        public AnaEkran a;
        DataTable dt;

        void temizle()
        {
            textBoxID.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = 1;
            textBox1.Focus();
        }

        void tabloyuDoldur()
        {
            DataLogic.KULLANICILAR kullanicilar = new DataLogic.KULLANICILAR();
            dt = new DataTable();

            dt = kullanicilar.getirKullanicilar();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            textBoxID.Text = dataGridView1.CurrentRow.Cells["KullanicilarID"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Sifre"].Value.ToString();

            if (dataGridView1.CurrentRow.Cells["KullaniciTuru"].Value.ToString() == "Yönetici")
                comboBox1.SelectedIndex = 0;
            else
                comboBox1.SelectedIndex = 1;
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            tabloyuDoldur();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataLogic.KULLANICILAR kullanicilar = new DataLogic.KULLANICILAR();
            Entities.KULLANICILAR d = new Entities.KULLANICILAR();

            d.AdSoyad = textBox1.Text;
            d.KullaniciAdi = textBox2.Text;
            d.Sifre = textBox3.Text;

            if (comboBox1.SelectedIndex == 0)
                d.KullaniciTuru = true;
            else
                d.KullaniciTuru = false;

            int a = -1;
            if (textBoxID.Text != "") //ID nin tutulduğu textBox
            {
                d.KullanicilarID = Convert.ToInt32(textBoxID.Text);
                a = kullanicilar.guncelleKullanicilar(d);
            }
            else
                a = kullanicilar.kaydetKullanicilar(d);

            if (a == 2 || a == 3)
            {
                MessageBox.Show("İşleminiz Gerçekleştirildi", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
                MessageBox.Show("İşleminiz Yapılamadı", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            tabloyuDoldur();
        }

        private void Kullanicilar_FormClosed(object sender, FormClosedEventArgs e)
        {
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            DialogResult sonuc = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz?",
                "Satış Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KullanicilarID"].Value.ToString());
                DataLogic.KULLANICILAR m = new DataLogic.KULLANICILAR();
                int a = m.silKullanicilar(id);
                if (a == 1)
                {
                    MessageBox.Show("İşleminiz Gerçekleştirildi",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                    tabloyuDoldur();
                }
                else
                    MessageBox.Show("İşleminiz Yapılamadı",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
