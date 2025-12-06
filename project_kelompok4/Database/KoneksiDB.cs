using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Project_GARAP.Database
{
    class KoneksiDB
    {
        public static NpgsqlConnection GetConnection()
        {
            string connString =
                "Host=ep-odd-star-a1vozzq0.ap-southeast-1.aws.neon.tech;" +
                "Database=neondb;" +
                "Username=neondb_owner;" +
                "Password=npg_yDdOp0U3LWYH;" +
                "Ssl Mode=Require;" +
                "Trust Server Certificate=true;";

            NpgsqlConnection conn = new NpgsqlConnection(connString);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Konek ke Neon: " + ex.Message);
            }

            return conn;
        }
    }
}