using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLogic
{
    public class URUN
    {
        public DataTable getirUrunler()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select U.*,K.KategoriAdi,B.BirimAdi from URUN as U inner join BIRIM as B on U.BirimID=B.BirimID " +
                                "inner join KATEGORI as K on U.KategoriID=K.KategoriID order by Barkodu";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable getirUrunler(string barkodu)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT dbo.BIRIM.BirimAdi, dbo.KATEGORI.KategoriAdi, dbo.URUN.Adi, dbo.URUN.Barkodu, " + 
                        "dbo.URUN.SatisFiyati, dbo.URUN.UrunID " +
                        " FROM         dbo.URUN INNER JOIN " +
                        " dbo.BIRIM ON dbo.BIRIM.BirimID = dbo.URUN.BirimID INNER JOIN " +
                        " dbo.KATEGORI ON dbo.URUN.KategoriID = dbo.KATEGORI.KategoriID where dbo.URUN.Barkodu=@Barkodu ";

            cmd.Parameters.AddWithValue("@Barkodu", barkodu);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public int silUrunler(int urunID)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from URUN where UrunID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = urunID;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public int guncelleUrun(Entities.URUN urun)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Update URUN set Adi=@Adi,Barkodu=@Barkodu,BirimID=@Birimi,KategoriID=@Kategorisi," + 
                                "SatisFiyati=@SatisFiyati where UrunID=@ID";

            cmd.Parameters.Add("@Adi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Barkodu", SqlDbType.VarChar, 16);
            cmd.Parameters.Add("@Birimi", SqlDbType.Int);
            cmd.Parameters.Add("@Kategorisi", SqlDbType.Int);
            cmd.Parameters.Add("@SatisFiyati", SqlDbType.Decimal);
            cmd.Parameters.Add("@ID", SqlDbType.Int);

            cmd.Parameters["@Adi"].Value = urun.Adi;
            cmd.Parameters["@Barkodu"].Value = urun.Barkodu;
            cmd.Parameters["@Birimi"].Value = urun.BirimID;
            cmd.Parameters["@Kategorisi"].Value = urun.KategoriID;
            cmd.Parameters["@SatisFiyati"].Value = urun.SatisFiyati;
            cmd.Parameters["@ID"].Value = urun.UrunID;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public int kaydetUrun(Entities.URUN urun)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "INSERT INTO URUN(Adi,Barkodu,BirimID,KategoriID,SatisFiyati) values" + 
                                "(@Adi,@Barkodu,@Birimi,@Kategorisi,@SatisFiyati)";

            cmd.Parameters.Add("@Adi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Barkodu", SqlDbType.VarChar, 16);
            cmd.Parameters.Add("@Birimi", SqlDbType.Int);
            cmd.Parameters.Add("@Kategorisi", SqlDbType.Int);
            cmd.Parameters.Add("@SatisFiyati", SqlDbType.Decimal);

            cmd.Parameters["@Adi"].Value = urun.Adi;
            cmd.Parameters["@Barkodu"].Value = urun.Barkodu;
            cmd.Parameters["@Birimi"].Value = urun.BirimID;
            cmd.Parameters["@Kategorisi"].Value = urun.KategoriID;
            cmd.Parameters["@SatisFiyati"].Value = urun.SatisFiyati;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }
    }
}
