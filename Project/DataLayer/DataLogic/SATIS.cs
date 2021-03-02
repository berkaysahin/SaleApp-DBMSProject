using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLogic
{
    public class SATIS
    {
        public int satisEkle(Entities.SATIS d, DataTable dt)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            SqlTransaction tr = cnn.BeginTransaction();
            cmd.Transaction = tr;

            cmd.CommandText = @"select ISNULL(MAX(SatisID), 0) from SATIS";

            int satisID = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            cmd.CommandText = "insert into SATIS(SatisID, Tarih, MusteriID, ToplamTutar, SorumluID) values " +
                "(@SatisID, @Tarih, @MusteriID, @ToplamTutar, @SorumluID)";

            cmd.Parameters.Add("@Tarih", SqlDbType.DateTime);
            cmd.Parameters.Add("@MusteriID", SqlDbType.Int);
            cmd.Parameters.Add("@ToplamTutar", SqlDbType.Decimal);
            cmd.Parameters.Add("@SatisID", SqlDbType.Int);
            cmd.Parameters.Add("@SorumluID", SqlDbType.Int);

            cmd.Parameters["@Tarih"].Value = d.Tarih;
            cmd.Parameters["@MusteriID"].Value = d.MusteriID;
            cmd.Parameters["@ToplamTutar"].Value = d.ToplamTutar;
            cmd.Parameters["@SatisID"].Value = satisID;
            cmd.Parameters["@SorumluID"].Value = d.SorumluID;

            int a = cmd.ExecuteNonQuery();

            if (a != 1)
            {
                tr.Rollback();
                return -1;
            }

            cmd.Parameters.Clear();

            cmd.CommandText = "insert into SATISDETAY (SatisID, UrunID, Miktar, BirimFiyat, Tutar) values" +
                "(@SatisID, @UrunID, @Miktar, @BirimFiyat, @Tutar)";


            cmd.Parameters.Add("@SatisID", SqlDbType.Int);
            cmd.Parameters.Add("@UrunID", SqlDbType.Int);
            cmd.Parameters.Add("@Miktar", SqlDbType.Decimal);
            cmd.Parameters.Add("@BirimFiyat", SqlDbType.Decimal);
            cmd.Parameters.Add("@Tutar", SqlDbType.Decimal);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmd.Parameters["@SatisID"].Value = satisID;
                cmd.Parameters["@UrunID"].Value = dt.Rows[i]["UrunID"];
                cmd.Parameters["@Miktar"].Value = dt.Rows[i]["Miktar"];
                cmd.Parameters["@BirimFiyat"].Value = dt.Rows[i]["BirimFiyat"];
                cmd.Parameters["@Tutar"].Value = dt.Rows[i]["Tutar"];

                a = cmd.ExecuteNonQuery();

                if (a != 1)
                {
                    tr.Rollback();
                    return -1;
                }
            }


            tr.Commit();
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            return 111;
        }

        public DataTable getirSatislar()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select S.*,M.AdiSoyadi, K.AdSoyad from SATIS as S inner join MUSTERI as M on S.MusteriID=M.MusteriID " +
                                "inner join SATISDANISMANI as D on S.SorumluID = D.KullanicilarID " +
                                "inner join KULLANICILAR as K on D.KullanicilarID = K.KullanicilarID " +
                                "order by S.Tarih";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
