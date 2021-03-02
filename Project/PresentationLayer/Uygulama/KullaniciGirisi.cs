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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            DataLogic.KULLANICILAR kullanicilar = new DataLogic.KULLANICILAR();
            Entities.KULLANICILAR d = new Entities.KULLANICILAR();

            d.KullaniciAdi = textBox1.Text;
            d.Sifre = textBox2.Text;

            int a = -1;
            
            a = kullanicilar.getirKullanicilarID(d);

            if (a == 0)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AnaEkran f = new AnaEkran();
                f.kullaniciAdi = textBox1.Text;
                f.sorumluID = a;
                f.Show();
                this.Hide();
                //MessageBox.Show("Başarılı.", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }
    }
}
