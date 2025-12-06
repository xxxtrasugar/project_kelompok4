using System;
using System.Drawing;
using System.Windows.Forms;
using project_kelompok4.Model;

namespace project_kelompok4.View
{
    public partial class FormPesanLayanan : Form
    {
        public M_JasaPerawatan JasaTerpilih { get; private set; }
        public string MetodePembayaranTerpilih { get; private set; }

        public FormPesanLayanan()
        {
            InitializeComponent();
            this.Paint += FormPesanLayanan_Paint; // Garis pinggir form

            if (comboPembayaran.Items.Count == 0)
            {
                comboPembayaran.Items.Add("Transfer Bank (BCA/Mandiri)");
                comboPembayaran.Items.Add("E-Wallet (Gopay/OVO)");
                comboPembayaran.Items.Add("Tunai (COD)");
                comboPembayaran.SelectedIndex = 0; // Default pilih pertama
            }
        }

        // Fungsi untuk menerima data dari Dashboard
        public void SetDataPesanan(M_JasaPerawatan jasa, string namaUser, string alamatUser)
        {
            this.JasaTerpilih = jasa;

            lblNamaJasa.Text = jasa.NamaJasa;
            lblTotalBayar.Text = "Rp " + jasa.Harga.ToString("N0");

            lblJadwalTanggal.Text = jasa.JamOperasional;
            lblJadwalJam.Text = "Sesuai ketentuan admin";

            txtNamaPemesan.Text = namaUser;
            txtAlamatPemesan.Text = alamatUser;
            txtNoHP.Text = "";
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaPemesan.Text) ||
                string.IsNullOrWhiteSpace(txtAlamatPemesan.Text) ||
                string.IsNullOrWhiteSpace(txtNoHP.Text) ||
                string.IsNullOrWhiteSpace(comboPembayaran.Text))
            {
                MessageBox.Show("Mohon lengkapi semua data termasuk metode pembayaran!", "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SIMPAN PILIHAN USER KE VARIABEL
            this.MetodePembayaranTerpilih = comboPembayaran.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Kosmetik Border
        private void FormPesanLayanan_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}