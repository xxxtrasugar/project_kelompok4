using System;
using System.Drawing;
using System.Windows.Forms;

namespace project_kelompok4.View
{
    public partial class UC_RowTransaksi : UserControl
    {
        public UC_RowTransaksi()
        {
            InitializeComponent();
        }

        public event EventHandler OnRowDoubleClicked;
        public int IdTransaksi { get; private set; }

        public void SetData(string id, string nama, string status, string jasa, string alamat, string tanggal, string pembayaran, decimal harga, string satuan)
        {
            this.IdTransaksi = int.Parse(id);
            this.DoubleClick += (s, e) => OnRowDoubleClicked?.Invoke(this, e);
            lblNama.DoubleClick += (s, e) => OnRowDoubleClicked?.Invoke(this, e);
            lblStatus.DoubleClick += (s, e) => OnRowDoubleClicked?.Invoke(this, e);

            // Info Utama
            lblNama.Text = nama;
            lblStatus.Text = status;

            // Detail Jasa & Lokasi
            lblJasa.Text = jasa;       // Contoh: "Pengolahan Tanah"
            lblAlamat.Text = alamat;   // Contoh: "Desa Sukorambi, Jember"

            // Waktu & Pembayaran
            lblTanggal.Text = tanggal; // Contoh: "20/11/2025"
            lblPembayaran.Text = pembayaran; // Contoh: "Bank BCA" or "Cash"

            // Harga & Satuan (Kanan)
            lblHarga.Text = "Rp " + harga.ToString("N0");
            lblSatuan.Text = satuan;   // Contoh: "2 hektar"

            // Logika Warna Status
            AturWarnaStatus(status);
        }

        private void AturWarnaStatus(string status)
        {
            lblStatus.ForeColor = Color.White;

            if (status.ToLower() == "selesai")
            {
                lblStatus.BackColor = Color.FromArgb(0, 166, 81); // Hijau
                lblStatus.Text = " Selesai ";
            }
            else if (status.ToLower() == "proses" || status.ToLower() == "berlangsung")
            {
                lblStatus.BackColor = Color.DodgerBlue; // Biru
                lblStatus.Text = " Berlangsung ";
            }
            else // Pending
            {
                lblStatus.BackColor = Color.Orange;
                lblStatus.Text = " Menunggu ";
            }
        }
    }
}