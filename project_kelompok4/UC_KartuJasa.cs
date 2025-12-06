using System;
using System.Drawing;
using System.Windows.Forms;
using project_kelompok4.Model;

namespace project_kelompok4.View
{
    public partial class UC_KartuJasa : UserControl
    {
        public event EventHandler OnEditClicked;
        public event EventHandler OnDeleteClicked;

        // Simpan ID Jasa
        public int IdJasa { get; private set; }

        public UC_KartuJasa()
        {
            InitializeComponent();
        }

        public M_JasaPerawatan DataAsli { get; private set; }

        // untuk mengisi data ke kartu
        public void SetData(M_JasaPerawatan jasa)
        {
            this.DataAsli = jasa;
            this.IdJasa = jasa.IdJasa;
            lblNama.Text = jasa.NamaJasa;
            lblDeskripsi.Text = jasa.Deskripsi;
            lblHarga.Text = "Rp " + jasa.Harga.ToString("N0") + " / " + jasa.JamOperasional;
            lblJadwal.Text = "Jadwal: " + jasa.JamOperasional;

            // Logika Status (Opsional)
            if (jasa.Slot > 0)
            {
                lblStatus.Text = "Tersedia";
                lblStatus.BackColor = Color.FromArgb(200, 255, 200); // Hijau muda
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Penuh";
                lblStatus.BackColor = Color.FromArgb(255, 200, 200); // Merah muda
                lblStatus.ForeColor = Color.Red;
            }
        }

        // Wiring Tombol
        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEditClicked?.Invoke(this, e);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            OnDeleteClicked?.Invoke(this, e);
        }
    }
}