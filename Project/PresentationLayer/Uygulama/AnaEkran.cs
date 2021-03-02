using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        public string kullaniciAdi;
        public int sorumluID = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            Tanımlamalar.Kullanicilar f = new Tanımlamalar.Kullanicilar();
            f.a = this;
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tanımlamalar.Birimler f = new Tanımlamalar.Birimler();
            f.a = this;
            f.Show();
            this.Hide();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            DataLogic.KULLANICILAR k = new DataLogic.KULLANICILAR();
            label1.Text = "Hoş Geldiniz: " + k.getirKullanicilarAdiSoyadi(kullaniciAdi);

            if (k.getirKullanicilarTuru(kullaniciAdi) == "True")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tanımlamalar.Kategoriler f = new Tanımlamalar.Kategoriler();
            f.a = this;
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tanımlamalar.Urunler f = new Tanımlamalar.Urunler();
            f.a = this;
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tanımlamalar.Musteriler f = new Tanımlamalar.Musteriler();
            f.a = this;
            f.Show();
            this.Hide();
        }

        private void AnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KasaIslemleri.YeniIslem f = new KasaIslemleri.YeniIslem();
            f.a = this;
            f.sorumluID = sorumluID;
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KasaIslemleri.IslemlerListesi f = new KasaIslemleri.IslemlerListesi();
            f.a = this;
            f.Show();
            this.Hide();
        }
    }
}
