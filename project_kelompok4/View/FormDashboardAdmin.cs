using project_kelompok4.Controller;
using project_kelompok4.Model;
using project_kelompok4.View;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace project_kelompok4.View
{
    public partial class FormDashboardAdmin : Form
    {
        C_Jasa controllerJasa;
        public FormDashboardAdmin()
        {
            InitializeComponent();
            controllerJasa = new C_Jasa();
        }
        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            ShowPanel(panelHalamanDashboard);
            AturTombolAktif(btnNavDashboard);
            UpdateStatistik();
            LoadTransaksiTerbaru();
        }

        // Logika Ganti Halaman
        private void ShowPanel(Panel panelAktif)
        {
            panelHalamanDashboard.Visible = false;
            panelHalamanLayanan.Visible = false;
            panelHalamanTransaksi.Visible = false;

            panelAktif.Visible = true;

            panelAktif.BringToFront();
        }

        // Logika Tombol Menu
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(panelHalamanDashboard);
            AturTombolAktif(btnNavDashboard);
            UpdateStatistik();
        }

        private void btnNavLayanan_Click(object sender, EventArgs e)
        {
            ShowPanel(panelHalamanLayanan);
            AturTombolAktif(btnNavLayanan);
            LoadDataJasa();
        }

        private void AturTombolAktif(Button btn)
        {
            // Reset warna semua tombol jadi standar (misal Abu/Hitam)
            btnNavDashboard.ForeColor = Color.Gray;
            btnNavLayanan.ForeColor = Color.Gray;
            btnNavTransaksi.ForeColor = Color.Gray;

            // Set tombol aktif jadi Hijau & Bold
            btn.ForeColor = Color.FromArgb(0, 166, 81);
        }

        private void LoadDataJasa()
        {
            flowPanelJasa.Controls.Clear();

            flowPanelJasa.Padding = new Padding(20);

            DataTable dt = controllerJasa.GetSemuaJasa();

            foreach (DataRow row in dt.Rows)
            {
                // Buat Objek Model dari DataRow
                M_JasaPerawatan jasa = new M_JasaPerawatan();
                jasa.IdJasa = Convert.ToInt32(row["id_jasa"]);
                jasa.NamaJasa = row["nama_jasa"].ToString();
                jasa.Deskripsi = row["deskripsi"].ToString();
                jasa.Harga = Convert.ToDecimal(row["harga"]);
                jasa.JamOperasional = row["jam_operasional"].ToString();
                jasa.Slot = Convert.ToInt32(row["slot_ketersediaan"]);

                UC_KartuJasa kartu = new UC_KartuJasa();

                kartu.SetData(jasa);

                kartu.OnEditClicked += Kartu_OnEditClicked;
                kartu.OnDeleteClicked += Kartu_OnDeleteClicked;

                flowPanelJasa.Controls.Add(kartu);
            }
        }

        // Event saat tombol Edit di kartu ditekan
        private void Kartu_OnEditClicked(object sender, EventArgs e)
        {
            UC_KartuJasa kartu = (UC_KartuJasa)sender;

            FormTambahJasa formEdit = new FormTambahJasa();

            formEdit.SetDataEdit(kartu.DataAsli);

            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                LoadDataJasa();
            }
        }

        // Event saat tombol Hapus di kartu ditekan
        private void Kartu_OnDeleteClicked(object sender, EventArgs e)
        {
            UC_KartuJasa kartu = (UC_KartuJasa)sender;

            DialogResult jawab = MessageBox.Show(
                "Yakin ingin menghapus layanan ini secara permanen?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (jawab == DialogResult.Yes)
            {
                if (controllerJasa.HapusJasa(kartu.IdJasa))
                {
                    MessageBox.Show("Data berhasil dihapus.", "Info");

                    LoadDataJasa();
                }
            }
        }

        public void SetInfoAdmin(string nama, string username)
        {
            lblNamaAdmin.Text = nama;
            lblUsernameAdmin.Text = username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult jawab = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();

                this.Close();
            }
        }

        // FUNGSI UPDATE STATISTIK
        private void UpdateStatistik()
        {
            // Ambil Data Real
            int totalLayanan = controllerJasa.GetTotalLayanan();
            int totalTransaksi = controllerJasa.GetTotalTransaksi();
            decimal totalPendapatan = controllerJasa.GetTotalPendapatan();
            int totalSelesai = controllerJasa.GetTotalSelesai(); // Fungsi baru

            // Tempel ke Label
            if (this.Controls.Find("lblStatLayanan", true).Length > 0)
                this.Controls.Find("lblStatLayanan", true)[0].Text = totalLayanan + " Layanan";

            if (this.Controls.Find("lblStatTransaksi", true).Length > 0)
                this.Controls.Find("lblStatTransaksi", true)[0].Text = totalTransaksi + " Pesanan";

            if (this.Controls.Find("lblStatPendapatan", true).Length > 0)
                this.Controls.Find("lblStatPendapatan", true)[0].Text = "Rp " + totalPendapatan.ToString("N0");

            if (this.Controls.Find("lblStatSelesai", true).Length > 0)
                this.Controls.Find("lblStatSelesai", true)[0].Text = totalSelesai + " Pesanan";
        }

        // FUNGSI DAFTAR TRANSAKSI
        private void LoadTransaksiTerbaru()
        {
            if (flowPanelTransaksiTerbaru != null)
            {
                flowPanelTransaksiTerbaru.Controls.Clear();

                DataTable dt = controllerJasa.GetTransaksiTerbaru();

                foreach (DataRow row in dt.Rows)
                {
                    string id = row["id_transaksi"].ToString();
                    string nama = row["nama_pelanggan"].ToString();
                    string alamat = row["alamat"].ToString();
                    string status = row["status"].ToString();
                    string jasa = row["nama_jasa"].ToString();
                    string tgl = Convert.ToDateTime(row["tanggal_transaksi"]).ToString("dd MMM yyyy");
                    decimal harga = Convert.ToDecimal(row["total_biaya"]);

                    string bayar = row["metode_pembayaran"] == DBNull.Value ? "-" : row["metode_pembayaran"].ToString();

                    string satuan = "1 Paket";

                    TambahBarisReal(id, nama, status, jasa, alamat, tgl, bayar, harga, satuan);
                }
            }
        }

        private void TambahBarisReal(string id, string nama, string status, string jasa, string alamat, string tgl, string bayar, decimal harga, string satuan)
        {
            UC_RowTransaksi baris = new UC_RowTransaksi();

            // Set Data
            baris.SetData(id, nama, status, jasa, alamat, tgl, bayar, harga, satuan);

            // Layout
            baris.Width = flowPanelTransaksiTerbaru.Width - 40;
            baris.Margin = new Padding(0, 0, 0, 10);

            baris.OnRowDoubleClicked += BarisTransaksi_OnDoubleClicked;

            flowPanelTransaksiTerbaru.Controls.Add(baris);
        }

        private void btnTambahJasa_Click_1(object sender, EventArgs e)
        {
            FormTambahJasa formInput = new FormTambahJasa();

            DialogResult hasil = formInput.ShowDialog();

            if (hasil == DialogResult.OK)
            {
                LoadDataJasa();
            }
        }

        private void LoadRiwayatTransaksi()
        {
            if (flowPanelRiwayat != null)
                flowPanelRiwayat.Controls.Clear();

            DataTable dt = controllerJasa.GetAllRiwayatTransaksi();

            foreach (DataRow row in dt.Rows)
            {
                string id = row["id_transaksi"].ToString();

                string namaPelanggan = row["nama_pelanggan"].ToString();
                string alamat = row["alamat"].ToString();
                string infoPelanggan = $"{namaPelanggan}\n{alamat}";

                string namaJasa = row["nama_jasa"].ToString();

                string tgl = Convert.ToDateTime(row["tanggal_transaksi"]).ToString("dd/MM/yyyy");
                string status = row["status"].ToString();

                string bayar = row["metode_pembayaran"].ToString();
                decimal total = Convert.ToDecimal(row["total_biaya"]);

                TambahBarisRiwayat(id, infoPelanggan, namaJasa, tgl, status, bayar, total);
            }
        }

        private void TambahBarisRiwayat(string id, string nama, string jasa, string tgl, string status, string bayar, decimal total)
        {
            if (flowPanelRiwayat == null) return;

            UC_RiwayatRow baris = new UC_RiwayatRow();

            baris.SetData(id, nama, jasa, tgl, status, bayar, total);
            baris.Width = flowPanelRiwayat.Width - 30;
            baris.Margin = new Padding(0, 0, 0, 5); // Jarak antar baris tipis saja

            flowPanelRiwayat.Controls.Add(baris);
        }

        private void btnNavTransaksi_Click_1(object sender, EventArgs e)
        {
            ShowPanel(panelHalamanTransaksi);
            AturTombolAktif(btnNavTransaksi);
            LoadRiwayatTransaksi();
        }

        private void BarisTransaksi_OnDoubleClicked(object sender, EventArgs e)
        {
            UC_RowTransaksi baris = (UC_RowTransaksi)sender;

            // Menampilkan Pilihan Status
            DialogResult jawab = MessageBox.Show(
                $"Ubah status Transaksi #{baris.IdTransaksi} menjadi 'Selesai'?",
                "Update Status",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            string statusBaru = "";
            if (jawab == DialogResult.Yes) statusBaru = "Selesai";
            else if (jawab == DialogResult.No) statusBaru = "Proses";
            else return; 

            if (controllerJasa.UpdateStatusTransaksi(baris.IdTransaksi, statusBaru))
            {
                MessageBox.Show("Status berhasil diubah!", "Sukses");

                LoadTransaksiTerbaru();
                UpdateStatistik();
            }
        }
    }
}
