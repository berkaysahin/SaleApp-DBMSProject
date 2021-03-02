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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }

        DataTable dt;
        public YeniIslem y;

        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            DataLogic.MUSTERI musteriler = new DataLogic.MUSTERI();
            dt = new DataTable();

            dt = musteriler.getirMusteriler();
            dataGridView1.DataSource = dt;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            y.musteriIDsi = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MusteriID"].Value.ToString());
            y.musteriAdı = dataGridView1.CurrentRow.Cells["AdiSoyadi"].Value.ToString();

            this.Close();
        }
    }
}
