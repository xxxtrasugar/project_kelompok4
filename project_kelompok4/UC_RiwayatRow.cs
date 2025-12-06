using System;
using System.Drawing;
using System.Windows.Forms;

namespace project_kelompok4.View
{
    public partial class UC_RiwayatRow : UserControl
    {
        public UC_RiwayatRow()
        {
            InitializeComponent();
        }

        public void SetData(string id, string pelanggan, string layanan, string tanggal, string status, string bayar, decimal total)
        {
            lblID.Text = "#" + id;
            lblPelanggan.Text = pelanggan;
            lblLayanan.Text = layanan;
            lblTanggal.Text = tanggal;
            lblPembayaran.Text = bayar;
            lblTotal.Text = "Rp " + total.ToString("N0");

            lblStatus.Text = status;
            AturWarnaStatus(status);
        }

        private void AturWarnaStatus(string status)
        {

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
            else // Pending
            {
                lblStatus.BackColor = Color.FromArgb(255, 240, 200); // Kuning/Oranye
                lblStatus.ForeColor = Color.Orange;
            }
        }
    }
}