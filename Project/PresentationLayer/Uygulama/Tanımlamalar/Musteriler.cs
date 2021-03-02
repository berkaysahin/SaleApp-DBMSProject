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
    public partial class Musteriler : Form
    {
        public Musteriler()
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
            textBox1.Focus();
        }

        void musterileriGetir()
        {
            DataLogic.MUSTERI musteriler = new DataLogic.MUSTERI();
            dt = new DataTable();

            dt = musteriler.getirMusteriler();
            dataGridView1.DataSource = dt;
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            musterileriGetir();
        }

        private void Musteriler_FormClosed(object sender, FormClosedEventArgs e)
        {
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataLogic.MUSTERI musteri = new DataLogic.MUSTERI();
            Entities.MUSTERI d = new Entities.MUSTERI();

            d.AdiSoyadi = textBox1.Text;
            d.Telefonu = textBox2.Text;
            d.Adresi = textBox3.Text;
            int a = -1;
            if (textBoxID.Text != "") //ID nin tutulduğu textBox
            {
                d.MusteriID = Convert.ToInt32(textBoxID.Text);
                a = musteri.guncelleMusteri(d);
            }
            else
                a = musteri.kaydetMusteri(d);

            if (a == 1)
            {
                MessageBox.Show("İşleminiz Gerçekleştirildi", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                musterileriGetir();
            }
            else
                MessageBox.Show("İşleminiz Yapılamadı", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            textBoxID.Text = dataGridView1.CurrentRow.Cells["MusteriID"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["AdiSoyadi"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Telefonu"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Adresi"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            DialogResult sonuc = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz?",
                "Satış Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MusteriID"].Value.ToString());
                DataLogic.MUSTERI m = new DataLogic.MUSTERI();
                int a = m.silMusteri(id);
                if (a == 1)
                {
                    MessageBox.Show("İşleminiz Gerçekleştirildi",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                    musterileriGetir();
                }
                else
                    MessageBox.Show("İşleminiz Yapılamadı",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
