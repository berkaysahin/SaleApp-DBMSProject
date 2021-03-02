using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLogic
{
    public class KATEGORI
    {
        public DataTable getirKategoriler()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from KATEGORI order by KategoriAdi";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public int silKategori(int kategoriID)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from KATEGORI where KategoriID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = kategoriID;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public int kaydetKategori(Entities.KATEGORI degisken)
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = Settings.connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "INSERT INTO KATEGORI (KategoriAdi) values (@KategoriAdi)";
                cmd.Parameters.Add("@KategoriAdi", SqlDbType.VarChar, 50);

                cmd.Parameters["@KategoriAdi"].Value = degisken.KategoriAdi;

                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                int a = cmd.ExecuteNonQuery();

                if (cnn.State == ConnectionState.Open)
                    cnn.Close();

                return a;
            }
            catch
            {
                return -1;
            }
        }
    }
}
