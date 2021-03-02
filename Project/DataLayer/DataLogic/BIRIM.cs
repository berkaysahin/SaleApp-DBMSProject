using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataLogic
{
    public class BIRIM
    {
        public DataTable getirBirimler()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from BIRIM order by BirimAdi";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public int silBirim(int birimID)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Settings.connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from BIRIM where BirimID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.Int);

            cmd.Parameters["@ID"].Value = birimID;

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            int a = cmd.ExecuteNonQuery();

            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return a;

        }

        public int kaydetBirim(Entities.BIRIM degisken)
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = Settings.connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "INSERT INTO BIRIM (BirimAdi) values (@BirimAdi)";
                cmd.Parameters.Add("@BirimAdi", SqlDbType.VarChar, 50);

                cmd.Parameters["@BirimAdi"].Value = degisken.BirimAdi;

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
