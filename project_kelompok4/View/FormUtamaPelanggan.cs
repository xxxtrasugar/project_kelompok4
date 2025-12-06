using Project_GARAP_Kelompok4.Model;
using project_kelompok4.Controller;
using project_kelompok4.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_kelompok4.View
{
    public partial class FormUtamaPelanggan : Form
    {
        C_Jasa controllerJasa;
        C_Transaksi controllerTransaksi;

        // Simpan Info Login
        private int idPelangganLogin;
        private string namaPelanggan;

        public FormUtamaPelanggan(int idPelanggan, string nama, string username)
        {
            InitializeComponent();
            controllerJasa = new C_Jasa();
            controllerTransaksi = new C_Transaksi();

            this.idPelangganLogin = idPelanggan;
            this.namaPelanggan = nama;

            lblNamaPelanggan.Text = nama;
            lblEmailPelanggan.Text = username;
        }

        // Method Menerima Info Login
        public void SetInfoPelanggan(int id, string nama, string username)
        {
            this.idPelangganLogin = id;
            this.namaPelanggan = nama;

            if (lblNamaPelanggan != null) lblNamaPelanggan.Text = nama;
            if (lblEmailPelanggan != null) lblEmailPelanggan.Text = username;
        }

        private void FormUtamaPelanggan_Load(object sender, EventArgs e)
        {
            BukaTabKatalog();
            UpdateStatistik();
        }

        // NAVIGASI TAB

        private void btnNavKatalog_Click(object sender, EventArgs e)
        {
            BukaTabKatalog();
        }

        private void btnNavRiwayat_Click(object sender, EventArgs e)
        {
            BukaTabRiwayat();
        }

        private void BukaTabKatalog()
        {
            flowPanelKatalog.Visible = true;
            flowPanelRiwayat.Visible = false;
            btnNavLayanan.ForeColor = Color.FromArgb(0, 166, 81);
            btnNavRiwayat.ForeColor = Color.Gray;

            LoadKatalog();
        }

        private void BukaTabRiwayat()
        {
            flowPanelKatalog.Visible = false;
            flowPanelRiwayat.Visible = true;
            flowPanelRiwayat.BringToFront();

            btnNavLayanan.ForeColor = Color.Gray;
            btnNavRiwayat.ForeColor = Color.FromArgb(0, 166, 81);

            LoadRiwayat();
        }

        // LOGIKA LOAD DATA

        private void LoadKatalog()
        {
            flowPanelKatalog.Controls.Clear();
            DataTable dt = controllerJasa.GetSemuaJasa();

            foreach (DataRow row in dt.Rows)
            {
                M_JasaPerawatan jasa = new M_JasaPerawatan();
                jasa.IdJasa = Convert.ToInt32(row["id_jasa"]);
                jasa.NamaJasa = row["nama_jasa"].ToString();
                jasa.Deskripsi = row["deskripsi"].ToString();
                jasa.Harga = Convert.ToDecimal(row["harga"]);
                jasa.JamOperasional = row["jam_operasional"].ToString();
                jasa.Slot = Convert.ToInt32(row["slot_ketersediaan"]);

                UC_KartuPelanggan kartu = new UC_KartuPelanggan();
                kartu.SetData(jasa);
                kartu.Margin = new Padding(15);
                kartu.OnPesanClicked += Kartu_OnPesanClicked;

                flowPanelKatalog.Controls.Add(kartu);
            }
        }

        private void LoadRiwayat()
        {
            if (flowPanelRiwayat != null) flowPanelRiwayat.Controls.Clear();

            DataTable dt = controllerTransaksi.GetRiwayatPelanggan(this.idPelangganLogin);

            if (dt.Rows.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Data tidak ditemukan di database.";
                lbl.AutoSize = true;
                lbl.ForeColor = Color.Red;
                flowPanelRiwayat.Controls.Add(lbl);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                try
                { 

                    UC_RiwayatPelanggan kartu = new UC_RiwayatPelanggan();

                    string namaJasa = row["nama_jasa"] == DBNull.Value
                        ? "(Data Tidak Ada)"
                        : row["nama_jasa"].ToString();

                    string tgl = "-";
                    if (row["tanggal_transaksi"] != DBNull.Value)
                    {
                        tgl = Convert.ToDateTime(row["tanggal_transaksi"]).ToString("dd MMM yyyy");
                    }

                    decimal total = row["total_biaya"] == DBNull.Value ? 0 : Convert.ToDecimal(row["total_biaya"]);

                    string status = row["status"].ToString();
                    string pembayaran = row["metode_pembayaran"].ToString();

                    kartu.SetData(namaJasa, status, tgl, pembayaran, total);

                    kartu.Width = flowPanelRiwayat.Width - 40;
                    kartu.Margin = new Padding(0, 0, 0, 15);
                    kartu.Visible = true; 

                    flowPanelRiwayat.Controls.Add(kartu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan baris: " + ex.Message);
                }
            }
        }

        private void UpdateStatistik()
        {
            try
            {
                var dataStats = controllerTransaksi.GetStatistikPelanggan(this.idPelangganLogin);
                if (lblStatTotal != null)
                    lblStatTotal.Text = dataStats["total"].ToString();

                if (lblStatProses != null)
                    lblStatProses.Text = dataStats["proses"].ToString();

                if (lblStatSelesai != null)
                    lblStatSelesai.Text = dataStats["selesai"].ToString();

                if (lblStatPengeluaran != null)
                    lblStatPengeluaran.Text = "Rp " + dataStats["pengeluaran"].ToString("N0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal update statistik: " + ex.Message);
            }
        }

        // EVENT HANDLER

        private void Kartu_OnPesanClicked(object sender, EventArgs e)
        {
            UC_KartuPelanggan kartu = (UC_KartuPelanggan)sender;
            M_JasaPerawatan jasa = kartu.DataJasa;

            FormPesanLayanan formPesan = new FormPesanLayanan();
            formPesan.SetDataPesanan(jasa, this.namaPelanggan, "");

            if (formPesan.ShowDialog() == DialogResult.OK)
            {
                // METODE YANG DIPILIH USER
                string metodeBayar = formPesan.MetodePembayaranTerpilih;

                bool sukses = controllerTransaksi.BuatPesananBaru(
                    this.idPelangganLogin,
                    jasa.IdJasa,
                    jasa.Harga,
                    metodeBayar
                );

                if (sukses)
                {
                    MessageBox.Show("Pesanan Berhasil!...", "Sukses");
                    BukaTabRiwayat();
                    UpdateStatistik();
                }
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin ingin keluar?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new FormLogin().Show();
            }
        }
    }
}