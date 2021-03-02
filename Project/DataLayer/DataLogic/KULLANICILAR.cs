using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataLogic
{
    public class KULLANICILAR
    {
        public DataTable getirKullanicilar()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select KullanicilarID, KullaniciAdi, Sifre, AdSoyad, IIF(KullaniciTuru = 1, 'Yönetici', 'Normal Kullanıcı') as KullaniciTuru from KULLANICILAR order by AdSoyad";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public int silKullanicilar(int kullanicilarID)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from KULLANICILAR where KullanicilarID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = kullanicilarID;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public int guncelleKullanicilar(Entities.KULLANICILAR kullanicilar)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "update KULLANICILAR set KullaniciAdi=@KullaniciAdi, Sifre=@Sifre, AdSoyad=@AdSoyad, KullaniciTuru=@KullaniciTuru where KullanicilarID=@ID";
            cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Sifre", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@AdSoyad", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters.Add("@KullaniciTuru", SqlDbType.Bit);

            cmd.Parameters["@KullaniciAdi"].Value = kullanicilar.KullaniciAdi;
            cmd.Parameters["@Sifre"].Value = kullanicilar.Sifre;
            cmd.Parameters["@AdSoyad"].Value = kullanicilar.AdSoyad;
            cmd.Parameters["@ID"].Value = kullanicilar.KullanicilarID;
            cmd.Parameters["@KullaniciTuru"].Value = kullanicilar.KullaniciTuru;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public int kaydetKullanicilar(Entities.KULLANICILAR kullanicilar)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            //cmd.CommandText = "INSERT INTO KULLANICILAR(KullaniciAdi,Sifre,AdSoyad, KullaniciTuru) values (@KullaniciAdi,@Sifre,@AdSoyad,@KullaniciTuru)";
            cmd.CommandText = "SP_KullaniciEkle";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Sifre", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@AdSoyad", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@KullaniciTuru", SqlDbType.Bit);

            cmd.Parameters["@KullaniciAdi"].Value = kullanicilar.KullaniciAdi;
            cmd.Parameters["@Sifre"].Value = kullanicilar.Sifre;
            cmd.Parameters["@AdSoyad"].Value = kullanicilar.AdSoyad;
            cmd.Parameters["@KullaniciTuru"].Value = kullanicilar.KullaniciTuru;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }
        public int getirKullanicilarID(Entities.KULLANICILAR kullanicilar)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select KullanicilarID from KULLANICILAR where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre";
            cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Sifre", SqlDbType.VarChar, 50);

            cmd.Parameters["@KullaniciAdi"].Value = kullanicilar.KullaniciAdi;
            cmd.Parameters["@Sifre"].Value = kullanicilar.Sifre;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = Convert.ToInt32(cmd.ExecuteScalar());//Sorgudan dönen değeri alır

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;
        }

        public string getirKullanicilarAdiSoyadi(string KullaniciAdi)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select AdSoyad from KULLANICILAR where KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar, 50);

            cmd.Parameters["@KullaniciAdi"].Value = KullaniciAdi;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            string a = cmd.ExecuteScalar().ToString(); //Sorgudan dönen değeri alır

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public string getirKullanicilarTuru(string KullaniciAdi)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select KullaniciTuru from KULLANICILAR where KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar, 50);

            cmd.Parameters["@KullaniciAdi"].Value = KullaniciAdi;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            string a = cmd.ExecuteScalar().ToString(); //Sorgudan dönen değeri alır

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }
    }
}
