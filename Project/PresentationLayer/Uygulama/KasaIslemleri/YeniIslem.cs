using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uygulama.KasaIslemleri
{
    public partial class YeniIslem : Form
    {
        public AnaEkran a;

        public YeniIslem()
        {
            InitializeComponent();
        }

        DataTable dtSatis;
        double genelTutar = 0;

        public int musteriIDsi = -1, sorumluID = -1;
        public string musteriAdı = "";

        void tabloOlustur()
        {
            dtSatis = new DataTable("Satis");
            dtSatis.Columns.Add("Barkodu", Type.GetType("System.String"));
            dtSatis.Columns.Add("UrunAdi", Type.GetType("System.String"));
            dtSatis.Columns.Add("KategoriAdi", Type.GetType("System.String"));
            dtSatis.Columns.Add("BirimAdi", Type.GetType("System.String"));
            dtSatis.Columns.Add("Miktar", Type.GetType("System.Single"));
            dtSatis.Columns.Add("BirimFiyat", Type.GetType("System.Single"));
            dtSatis.Columns.Add("Tutar", Type.GetType("System.Single"));
            dtSatis.Columns.Add("UrunTutari", Type.GetType("System.Single"));
            dtSatis.Columns.Add("UrunID", Type.GetType("System.Int32"));
        }

        void tutarBul()
        {
            //if (dtSatis.Rows.Count == 0)
            //    return;

            genelTutar = 0;

            for (int i = 0; i < dtSatis.Rows.Count; i++)
            {
                genelTutar += Convert.ToDouble(dtSatis.Rows[i]["UrunTutari"]);
            }

            label11.Text = genelTutar.ToString("N2");
        }

        int urunBul(string barkod)
        {
            for (int i = 0; i < dtSatis.Rows.Count; i++)
            {
                if (barkod == dtSatis.Rows[i]["Barkodu"].ToString())
                    return i;
            }
            return -1;
        }

        private void YeniIslem_Load(object sender, EventArgs e)
        {
            tabloOlustur();
            dataGridView1.DataSource = dtSatis;
        }

        private void btnMusteriListesi_Click(object sender, EventArgs e)
        {
            MusteriListesi liste = new MusteriListesi();
            liste.y = this;
            liste.ShowDialog();
            labelMusteriID.Text = musteriAdı;
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tus = (int)e.KeyChar;
            if (tus == 13)
                urunEkle();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            dtSatis.Rows[dataGridView1.CurrentRow.Index].Delete();
            dtSatis.AcceptChanges();
            tutarBul();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            urunEkle();
        }

        private void YeniIslem_FormClosing(object sender, FormClosingEventArgs e)
        {
            a.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (musteriIDsi == -1 || dtSatis.Rows.Count == 0) // hiçbir ürün yoksa sondaki
            {
                MessageBox.Show("Gerekli bilgileri doldurunuz!");
                return;
            }

            Entities.SATIS d = new Entities.SATIS();
            DataLogic.SATIS satis = new DataLogic.SATIS();

            d.MusteriID = musteriIDsi;
            d.Tarih = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            tutarBul();
            d.ToplamTutar = genelTutar;
            d.SorumluID = sorumluID;

            if (satis.satisEkle(d, dtSatis) == 111) 
            { 
                MessageBox.Show("Başarıyla kaydedildi.");

                a.Show();
                this.Close();
            }
        }

        void urunEkle()
        {
            string barkod = txtBarkod.Text;
            double miktar = Convert.ToDouble(textBox3.Text);

            int index = urunBul(barkod);
            if (index == -1)
            {
                DataLogic.URUN urun = new DataLogic.URUN();
                DataTable dt = new DataTable();
                dt = urun.getirUrunler(barkod);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ürün Bulunamadı");
                    return;
                }

                double fiyat = Convert.ToDouble(dt.Rows[0]["SatisFiyati"].ToString());
                double tutar = miktar * fiyat;
                tutar = Math.Round(tutar, 2);

                DataRow dr = dtSatis.NewRow();
                dr["Barkodu"] = barkod;
                dr["UrunAdi"] = dt.Rows[0]["Adi"].ToString();
                dr["KategoriAdi"] = dt.Rows[0]["KategoriAdi"].ToString();
                dr["BirimAdi"] = dt.Rows[0]["BirimAdi"].ToString();
                dr["Miktar"] = miktar;
                dr["BirimFiyat"] = fiyat;
                dr["Tutar"] = tutar;
                dr["UrunTutari"] = tutar;
                dr["UrunID"] = Convert.ToInt32(dt.Rows[0]["UrunID"]);
                dtSatis.Rows.Add(dr);
            }
            else
            {
                double m = Convert.ToDouble(dtSatis.Rows[index]["Miktar"]);
                miktar += m;
                dtSatis.Rows[index]["Miktar"] = miktar;

                double fiyat = Convert.ToDouble(dtSatis.Rows[index]["BirimFiyat"].ToString());
                double tutar = miktar * fiyat;
                tutar = Math.Round(tutar, 2);

                dtSatis.Rows[index]["Tutar"] = tutar;
                dtSatis.Rows[index]["UrunTutari"] = tutar;
            }
            tutarBul();
            txtBarkod.Text = "";
            txtBarkod.Focus();

        }
    }
}
