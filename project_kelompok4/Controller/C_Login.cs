using System;
using System.Data;
using Npgsql;
using Project_GARAP_Kelompok4.Model;
using Project_GARAP.Database; 
using project_kelompok4.Model;

namespace Project_GARAP.Controller
{
    public class C_Login
    {
        // Method mengembalikan tipe 'Akun' (Parent Class)
        // Tapi isinya bisa 'Admin' atau 'Pelanggan' (Child Class) -> Polymorphism
        public Akun ValidasiLogin(string username, string password, string role)
        {
            Akun akunDitemukan = null;

            string query = "";
            if (role == "Admin")
            {
                query = "SELECT * FROM admin WHERE username = @user AND password = @pass";
            }
            else
            {
                query = "SELECT * FROM pelanggan WHERE username = @user AND password = @pass";
            }

            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (role == "Admin")
                            {
                                string nama = reader["nama_lengkap"].ToString();
                                akunDitemukan = new Admin(username, password, nama);
                            }
                            else
                            {
                                int idDB = Convert.ToInt32(reader["id"]);

                                string nama = reader["nama_lengkap"].ToString();
                                string alamat = reader["alamat"].ToString();

                                akunDitemukan = new Pelanggan(idDB, username, password, nama, alamat);
                            }
                        }
                    }
                }
            }

            return akunDitemukan;
        }
    }
}