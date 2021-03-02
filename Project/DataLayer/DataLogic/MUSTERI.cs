using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLogic
{
    public class MUSTERI
    {
        public DataTable getirMusteriler()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from MUSTERI order by AdiSoyadi";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public int silMusteri(int musteriID)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from MUSTERI where MusteriID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int);

            cmd.Parameters["@ID"].Value = musteriID;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public int guncelleMusteri(Entities.MUSTERI musteri)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Update MUSTERI set AdiSoyadi=@AdiSoyadi,Telefonu=@Telefonu,Adresi=@Adresi where MusteriID=@ID";
            cmd.Parameters.Add("@AdiSoyadi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Telefonu", SqlDbType.VarChar, 16);
            cmd.Parameters.Add("@Adresi", SqlDbType.VarChar, 250);
            cmd.Parameters.Add("@ID", SqlDbType.Int);

            cmd.Parameters["@AdiSoyadi"].Value = musteri.AdiSoyadi;
            cmd.Parameters["@Telefonu"].Value = musteri.Telefonu;
            cmd.Parameters["@Adresi"].Value = musteri.Adresi;
            cmd.Parameters["@ID"].Value = musteri.MusteriID;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public int kaydetMusteri(Entities.MUSTERI musteri)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "INSERT INTO MUSTERI(AdiSoyadi,Telefonu,Adresi) values(@AdiSoyadi,@Telefonu,@Adresi)";
            cmd.Parameters.Add("@AdiSoyadi", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Telefonu", SqlDbType.VarChar, 16);
            cmd.Parameters.Add("@Adresi", SqlDbType.VarChar, 250);

            cmd.Parameters["@AdiSoyadi"].Value = musteri.AdiSoyadi;
            cmd.Parameters["@Telefonu"].Value = musteri.Telefonu;
            cmd.Parameters["@Adresi"].Value = musteri.Adresi;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }
    }
}
