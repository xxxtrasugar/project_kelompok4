using Npgsql;
using Project_GARAP.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace project_kelompok4.Controller
{
    public class C_Transaksi
    {
        // FUNGSI MEMBUAT PESANAN BARU (Untuk Tombol Pesan)
        public bool BuatPesananBaru(int idPelanggan, int idJasa, decimal harga, string metode)
        {
            bool sukses = false;
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Header Transaksi
                        string sqlHeader = "INSERT INTO transaksi (id_pelanggan, tanggal_transaksi, total_biaya, status, metode_pembayaran) " +
                                   "VALUES (@idCust, CURRENT_DATE, @total, 'Pending', @metode) RETURNING id_transaksi";

                        int idTransaksiBaru = 0;
                        using (NpgsqlCommand cmdHead = new NpgsqlCommand(sqlHeader, conn))
                        {
                            cmdHead.Parameters.AddWithValue("@idCust", idPelanggan);
                            cmdHead.Parameters.AddWithValue("@total", harga);
                            cmdHead.Parameters.AddWithValue("@metode", metode);
                            idTransaksiBaru = (int)cmdHead.ExecuteScalar();
                        }

                        // Detail Transaksi
                        string sqlDetail = "INSERT INTO transaksi_detail (id_transaksi, id_jasa, qty, subtotal) VALUES (@idTrans, @idJasa, 1, @subtotal)";
                        using (NpgsqlCommand cmdDetail = new NpgsqlCommand(sqlDetail, conn))
                        {
                            cmdDetail.Parameters.AddWithValue("@idTrans", idTransaksiBaru);
                            cmdDetail.Parameters.AddWithValue("@idJasa", idJasa);
                            cmdDetail.Parameters.AddWithValue("@subtotal", harga);
                            cmdDetail.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        sukses = true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Windows.Forms.MessageBox.Show("Gagal Transaksi: " + ex.Message);
                    }
                }
            }
            return sukses;
        }

        // FUNGSI MENGAMBIL RIWAYAT
        public DataTable GetRiwayatPelanggan(int idPelanggan)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = @"
                    SELECT t.id_transaksi, 
                           COALESCE(j.nama_jasa, 'Layanan Tidak Ditemukan') as nama_jasa, 
                           t.tanggal_transaksi, 
                           t.status, 
                           t.total_biaya, 
                           COALESCE(d.qty, 1) as qty, 
                           COALESCE(t.metode_pembayaran, '-') as metode_pembayaran 
                    FROM transaksi t
                    LEFT JOIN transaksi_detail d ON t.id_transaksi = d.id_transaksi
                    LEFT JOIN jasa_perawatan j ON d.id_jasa = j.id_jasa
                    WHERE t.id_pelanggan = @id
                    ORDER BY t.id_transaksi DESC";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPelanggan);
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public Dictionary<string, decimal> GetStatistikPelanggan(int idPelanggan)
        {
            var stats = new Dictionary<string, decimal>
            {
                { "total", 0 },
                { "proses", 0 },
                { "selesai", 0 },
                { "pengeluaran", 0 }
            };

            using (NpgsqlConnection conn = KoneksiDB.GetConnection())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = @"
                    SELECT 
                        COUNT(*) as total_semua,
                        COUNT(CASE WHEN status IN ('Pending', 'Proses', 'Berlangsung') THEN 1 END) as sedang_proses,
                        COUNT(CASE WHEN status = 'Selesai' THEN 1 END) as sudah_selesai,
                        COALESCE(SUM(total_biaya), 0) as total_uang
                    FROM transaksi 
                    WHERE id_pelanggan = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPelanggan);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            stats["total"] = Convert.ToDecimal(reader["total_semua"]);
                            stats["proses"] = Convert.ToDecimal(reader["sedang_proses"]);
                            stats["selesai"] = Convert.ToDecimal(reader["sudah_selesai"]);
                            stats["pengeluaran"] = Convert.ToDecimal(reader["total_uang"]);
                        }
                    }
                }
            }
            return stats;
        }
    }
}