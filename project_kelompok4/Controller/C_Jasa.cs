using Npgsql;
using Project_GARAP.Database;
using System;
using System.Data;
using System.Windows.Forms;
using project_kelompok4.Model;

namespace project_kelompok4.Controller
{
    public class C_Jasa
    {
        // Fungsi untuk mengambil smeua data jasa dari database
        public DataTable GetSemuaJasa()
        {
            DataTable dt = new DataTable();

            // Query SQL standar
            string query = "SELECT * FROM jasa_perawatan ORDER BY id_jasa ASC";

            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                // Cek status koneksi
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        try
                        {
                            adapter.Fill(dt);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal ambil data: " + ex.Message);
                        }
                    }
                }
            }
            return dt;
        }

        public bool TambahJasa(M_JasaPerawatan jasa)
        {
            bool status = false;
            string query = "INSERT INTO jasa_perawatan (nama_jasa, deskripsi, harga, jam_operasional, slot_ketersediaan) " +
                           "VALUES (@nama, @deskripsi, @harga, @jam, @slot)";

            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Isi parameter dari objek model
                    cmd.Parameters.AddWithValue("@nama", jasa.NamaJasa);
                    cmd.Parameters.AddWithValue("@deskripsi", jasa.Deskripsi);
                    cmd.Parameters.AddWithValue("@harga", jasa.Harga);
                    cmd.Parameters.AddWithValue("@jam", jasa.JamOperasional);
                    cmd.Parameters.AddWithValue("@slot", jasa.Slot);

                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) status = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal simpan data: " + ex.Message);
                    }
                }
            }
            return status;
        }

        public bool UpdateJasa(M_JasaPerawatan jasa)
        {
            bool status = false;
            string query = "UPDATE jasa_perawatan SET nama_jasa=@nama, deskripsi=@deskripsi, " +
                           "harga=@harga, jam_operasional=@jam, slot_ketersediaan=@slot " +
                           "WHERE id_jasa=@id";

            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", jasa.IdJasa);
                    cmd.Parameters.AddWithValue("@nama", jasa.NamaJasa);
                    cmd.Parameters.AddWithValue("@deskripsi", jasa.Deskripsi);
                    cmd.Parameters.AddWithValue("@harga", jasa.Harga);
                    cmd.Parameters.AddWithValue("@jam", jasa.JamOperasional);
                    cmd.Parameters.AddWithValue("@slot", jasa.Slot);

                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) status = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal update data: " + ex.Message);
                    }
                }
            }
            return status;
        }

        // FUNGSI DELETE
        public bool HapusJasa(int idJasa)
        {
            bool status = false;
            string query = "DELETE FROM jasa_perawatan WHERE id_jasa=@id";

            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idJasa);
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) status = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal hapus data: " + ex.Message);
                    }
                }
            }
            return status;
        }

        // --- FUNGSI STATISTIK DASHBOARD ---

        // Total Layanan Aktif
        public int GetTotalLayanan()
        {
            int hasil = 0;
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT COUNT(*) FROM jasa_perawatan WHERE slot_ketersediaan > 0";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        hasil = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch { hasil = 0; }
                }
            }
            return hasil;
        }

        public int GetTotalTransaksi()
        {
            int hasil = 0;
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                // Menghitung semua transaksi yang masuk
                string query = "SELECT COUNT(*) FROM transaksi";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    var res = cmd.ExecuteScalar();
                    if (res != DBNull.Value) hasil = Convert.ToInt32(res);
                }
            }
            return hasil;
        }

        // Total Pendapatan (Hanya yang berstatus selesai)
        public decimal GetTotalPendapatan()
        {
            decimal hasil = 0;
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Hanya hitung uang dari transaksi 'Selesai'
                string query = "SELECT COALESCE(SUM(total_biaya), 0) FROM transaksi WHERE status = 'Selesai'";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    var res = cmd.ExecuteScalar();
                    hasil = Convert.ToDecimal(res);
                }
            }
            return hasil;
        }

        // Menghitung Pesanan Selesai
        public int GetTotalSelesai()
        {
            int hasil = 0;
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = "SELECT COUNT(*) FROM transaksi WHERE status = 'Selesai'";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    var res = cmd.ExecuteScalar();
                    if (res != DBNull.Value) hasil = Convert.ToInt32(res);
                }
            }
            return hasil;
        }

        // Mengambil Daftar Transaksi Terbaru (Limit 10)
        public DataTable GetTransaksiTerbaru()
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Query JOIN Lengkap: Transaksi + Pelanggan + Detail + Jasa
                string query = @"
                    SELECT t.id_transaksi, 
                           p.nama_lengkap AS nama_pelanggan,
                           p.alamat,
                           t.status,
                           COALESCE(j.nama_jasa, 'Layanan Dihapus') AS nama_jasa,
                           t.tanggal_transaksi,
                           t.total_biaya,
                           t.metode_pembayaran
                    FROM transaksi t
                    JOIN pelanggan p ON t.id_pelanggan = p.id
                    LEFT JOIN transaksi_detail d ON t.id_transaksi = d.id_transaksi
                    LEFT JOIN jasa_perawatan j ON d.id_jasa = j.id_jasa
                    ORDER BY t.id_transaksi DESC
                    LIMIT 10"; // batasi 10 biar tidak kepanjangan

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetAllRiwayatTransaksi()
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = @"
                    SELECT t.id_transaksi, 
                           p.nama_lengkap AS nama_pelanggan,
                           p.alamat,
                           t.status,
                           COALESCE(j.nama_jasa, 'Layanan Dihapus') AS nama_jasa,
                           t.tanggal_transaksi,
                           t.total_biaya,
                           COALESCE(t.metode_pembayaran, '-') AS metode_pembayaran
                    FROM transaksi t
                    JOIN pelanggan p ON t.id_pelanggan = p.id
                    LEFT JOIN transaksi_detail d ON t.id_transaksi = d.id_transaksi
                    LEFT JOIN jasa_perawatan j ON d.id_jasa = j.id_jasa
                    ORDER BY t.id_transaksi DESC"; // Urutkan dari yang terbaru

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool UpdateStatusTransaksi(int idTransaksi, string statusBaru)
        {
            bool sukses = false;
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "UPDATE transaksi SET status = @status WHERE id_transaksi = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", statusBaru);
                    cmd.Parameters.AddWithValue("@id", idTransaksi);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        sukses = true;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Gagal update status: " + ex.Message);
                    }
                }
            }
            return sukses;
        }
    }
}