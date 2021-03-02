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
    public partial class IslemlerListesi : Form
    {
        public IslemlerListesi()
        {
            InitializeComponent();
        }

        public AnaEkran a;

        private void IslemlerListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataLogic.SATIS satislar = new DataLogic.SATIS();
            dt = satislar.getirSatislar();
            dataGridView1.DataSource = dt;
        }

        private void IslemlerListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            a.Show();
        }
    }
}
