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
    public partial class Birimler : Form
    {
        public Birimler()
        {
            InitializeComponent();
        }

        public AnaEkran a;

        void getirBirimler()
        {
            DataTable dt = new DataTable();
            DataLogic.BIRIM birimler = new DataLogic.BIRIM();
            dt = birimler.getirBirimler();
            dataGridView1.DataSource = dt;
        }
        private void Birimler_Load(object sender, EventArgs e)
        {
            getirBirimler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Birim Adı Alanını Doldurunuz");
                return;
            }

            DataLogic.BIRIM birimler = new DataLogic.BIRIM();
            Entities.BIRIM degisken = new Entities.BIRIM();

            degisken.BirimAdi = textBox1.Text.ToUpper();

            int a = birimler.kaydetBirim(degisken);

            if (a == 1)
            {
                MessageBox.Show("İşleminiz Gerçekleştirildi", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                getirBirimler();
            }
            else if (a == -1)
                MessageBox.Show("İşleminiz Yapılamadı\n\nAynı Birim Sistemde Kayıtlı", "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            DialogResult sonuc = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz?",
                "Satış Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BirimID"].Value.ToString());
                DataLogic.BIRIM birimler = new DataLogic.BIRIM();

                int a = birimler.silBirim(id);

                if (a == 1)
                {
                    MessageBox.Show("İşleminiz Gerçekleştirildi",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getirBirimler();
                }
                else
                    MessageBox.Show("İşleminiz Yapılamadı",
                        "Satış Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Birimler_FormClosed(object sender, FormClosedEventArgs e)
        {
            a.Show();
        }
    }
}
