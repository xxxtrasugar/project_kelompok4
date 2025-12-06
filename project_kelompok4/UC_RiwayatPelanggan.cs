using System;
using System.Drawing;
using System.Windows.Forms;

namespace project_kelompok4.View
{
    public partial class UC_RiwayatPelanggan : UserControl
    {
        public UC_RiwayatPelanggan()
        {
            InitializeComponent();
        }

        public void SetData(string namaJasa, string status, string tgl, string bayar, decimal harga)
        {
            lblNamaJasa.Text = namaJasa;
            lblStatus.Text = status;
            lblTanggal.Text = tgl;
            lblPembayaran.Text = "Pembayaran: " + bayar;
            lblHarga.Text = "Rp " + harga.ToString("N0");

            // Lokasi
            lblLokasi.Text = "Lokasi: Lahan Anda";

            AturWarnaStatus(status);
        }

        private void AturWarnaStatus(string status)
        {
            // Reset
            lblStatus.ForeColor = Color.White;

            if (status == "Selesai")
            {
                lblStatus.BackColor = Color.FromArgb(200, 255, 200); // Hijau Muda
                lblStatus.ForeColor = Color.Green;
            }
            else if (status == "Berlangsung" || status == "Proses")
            {
                lblStatus.BackColor = Color.FromArgb(200, 230, 255); // Biru Muda
                lblStatus.ForeColor = Color.DodgerBlue;
            }
            else // Pending/Menunggu
            {
                lblStatus.BackColor = Color.FromArgb(255, 240, 200); // Kuning
                lblStatus.ForeColor = Color.Orange;
            }
        }
    }
}