using System;
using System.Drawing;
using System.Windows.Forms;
using project_kelompok4.Controller;
using project_kelompok4.Model;

namespace project_kelompok4.View
{
    public partial class FormTambahJasa : Form
    {
        private bool isEditMode = false;
        private int idJasaEdit = 0;

        // Constructor
        public FormTambahJasa()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            comboStatus.SelectedIndex = 0; 
            comboSatuan.SelectedIndex = 0; 
            this.Padding = new Padding(2);
            this.Paint += FormTambahJasa_Paint;
        }

        private void FormTambahJasa_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tombol Batal
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // LOGIKA SIMPAN DATA
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || numHarga.Value <= 0)
            {
                MessageBox.Show("Nama Layanan dan Harga wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            M_JasaPerawatan jasaBaru = new M_JasaPerawatan();

            // --- LOGIKA EMOJI ---
            string icon = string.IsNullOrWhiteSpace(txtIcon.Text) ? "🌱" : txtIcon.Text.Trim();
            jasaBaru.NamaJasa = $"{icon} {txtNama.Text}";

            // Deskripsi & Harga
            jasaBaru.Deskripsi = txtDeskripsi.Text;
            jasaBaru.Harga = numHarga.Value;

            // LOGIKA JADWAL & SATUAN
            string tgl = dateTanggal.Value.ToString("dd MMM yyyy");
            string jam = timeJam.Value.ToString("HH:mm");
            string satuan = comboSatuan.Text;

            jasaBaru.JamOperasional = $"{tgl} • {jam} ({satuan})";

            // --- LOGIKA SLOT ---
            if (comboStatus.Text == "Tersedia")
            {
                jasaBaru.Slot = 10;
            }
            else
            {
                jasaBaru.Slot = 0;
            }

            C_Jasa controller = new C_Jasa();
            bool berhasil = false;

            if (isEditMode)
            {
                // MODE UPDATE
                jasaBaru.IdJasa = idJasaEdit;
                berhasil = controller.UpdateJasa(jasaBaru);
            }
            else
            {
                // MODE TAMBAH BARU
                berhasil = controller.TambahJasa(jasaBaru);
            }

            if (berhasil)
            {
                string pesan = isEditMode ? "Data berhasil diperbarui!" : "Layanan berhasil ditambahkan!";
                MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // Fungsi untuk memasukkan data lama ke form
        public void SetDataEdit(M_JasaPerawatan jasaLama)
        {
            isEditMode = true; 
            idJasaEdit = jasaLama.IdJasa;

            this.Text = "Edit Layanan";

            string[] pisahNama = jasaLama.NamaJasa.Split(new char[] { ' ' }, 2);
            if (pisahNama.Length > 1)
            {
                txtIcon.Text = pisahNama[0];
                txtNama.Text = pisahNama[1];
            }
            else
            {
                txtNama.Text = jasaLama.NamaJasa;
            }

            txtDeskripsi.Text = jasaLama.Deskripsi;
            numHarga.Value = jasaLama.Harga;

            if (jasaLama.Slot > 0) comboStatus.Text = "Tersedia";
            else comboStatus.Text = "Penuh";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}