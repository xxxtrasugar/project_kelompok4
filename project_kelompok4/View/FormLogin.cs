using System;
using System.Drawing;
using System.Windows.Forms;
using Project_GARAP.Controller;
using Project_GARAP_Kelompok4.Model;

namespace project_kelompok4.View
{
    public partial class FormLogin : Form
    {
        // Variabel untuk menyimpan role yang dipilih (Default: Pelanggan)
        private string roleTerpilih = "Pelanggan";

        public FormLogin()
        {
            InitializeComponent();
        }

        // LOGIKA TAMPILAN (LAYOUT)

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TengahkanPanel();
            UpdateTampilanRole();
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            TengahkanPanel();
        }

        private void TengahkanPanel()
        {
            // PanelLogin selalu di tengah layar
            if (panelLogin != null) // Cek null agar aman
            {
                panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
                panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
            }
        }

        // LOGIKA PILIH ROLE

        private void btnRolePelanggan_Click(object sender, EventArgs e)
        {
            roleTerpilih = "Pelanggan";
            UpdateTampilanRole();
        }

        private void btnRoleAdmin_Click(object sender, EventArgs e)
        {
            roleTerpilih = "Admin";
            UpdateTampilanRole();
        }

        private void UpdateTampilanRole()
        {
            // Warna Hijau (Aktif) dan Putih (Pasif)
            Color warnaAktif = Color.FromArgb(0, 166, 81);
            Color warnaPasif = Color.White;
            Color textAktif = Color.White;
            Color textPasif = Color.Gray;

            if (roleTerpilih == "Pelanggan")
            {
                btnRolePelanggan.BackColor = warnaAktif;
                btnRolePelanggan.ForeColor = textAktif;
                btnRoleAdmin.BackColor = warnaPasif;
                btnRoleAdmin.ForeColor = textPasif;
            }
            else
            {
                btnRoleAdmin.BackColor = warnaAktif;
                btnRoleAdmin.ForeColor = textAktif;
                btnRolePelanggan.BackColor = warnaPasif;
                btnRolePelanggan.ForeColor = textPasif;
            }
        }

        // LOGIKA UTAMA: LOGIN (OOP)

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            C_Login controller = new C_Login();

            // Konsep OOP: Polymorphism
            // menerima objek 'Akun', tidak peduli itu Admin atau Pelanggan
            Akun akunUser = controller.ValidasiLogin(user, pass, roleTerpilih);

            if (akunUser != null)
            {
                akunUser.BukaDashboard();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal! Username atau Password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TOMBOL KELUAR

        private void lblKembali_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        private void lblDaftar_Click(object sender, EventArgs e)
        {
            FormRegister formReg = new FormRegister();

            formReg.Show();

            this.Hide();
        }
    }
}