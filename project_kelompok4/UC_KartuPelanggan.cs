using System;
using System.Drawing;
using System.Windows.Forms;
using project_kelompok4.Model;

namespace project_kelompok4.View
{
    public partial class UC_KartuPelanggan : UserControl
    {
        public event EventHandler OnPesanClicked;
        public M_JasaPerawatan DataJasa { get; private set; } // Simpan data untuk dikirim saat dipesan

        public UC_KartuPelanggan()
        {
            InitializeComponent();
        }

        public void SetData(M_JasaPerawatan jasa)
        {
            this.DataJasa = jasa;

            lblNama.Text = jasa.NamaJasa;
            lblDeskripsi.Text = jasa.Deskripsi;
            lblHarga.Text = "Rp " + jasa.Harga.ToString("N0");
            lblJadwal.Text = jasa.JamOperasional;

            if (jasa.Slot > 0)
            {
                lblStatus.Text = "Tersedia";
                btnPesan.Enabled = true;
                btnPesan.BackColor = Color.FromArgb(0, 166, 81); // Hijau
            }
            else
            {
                lblStatus.Text = "Penuh";
                btnPesan.Enabled = false;
                btnPesan.Text = "Habis";
                btnPesan.BackColor = Color.Gray;
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            OnPesanClicked?.Invoke(this, e);
        }
    }
}