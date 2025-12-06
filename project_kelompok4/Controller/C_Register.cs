using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using Project_GARAP.Database;

namespace Project_GARAP.Controller
{
    public class C_Register
    {
        // Method untuk mendaftarkan Pelanggan baru
        public bool RegistrasiPelanggan(string username, string password, string nama, string alamat)
        {
            bool berhasil = false;

            // Validasi
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan");
                return false;
            }

            string query = "INSERT INTO pelanggan (username, password, nama_lengkap, alamat) VALUES (@user, @pass, @nama, @alamat)";

            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@alamat", alamat);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            berhasil = true;
                            MessageBox.Show("Registrasi Berhasil! Silakan Login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (PostgresException ex)
                    {
                        if (ex.SqlState == "23505") // Kode error untuk data duplikat (Unique Constraint)
                        {
                            MessageBox.Show("Username sudah terdaftar, gunakan yang lain.", "Gagal");
                        }
                        else
                        {
                            MessageBox.Show("Gagal Register: " + ex.Message, "Error");
                        }
                    }
                }
            }
            return berhasil;
        }
    }
}