using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Project_GARAP.Controller;

namespace project_kelompok4.View
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            TengahkanPanel();
        }

        private void FormRegister_Resize(object sender, EventArgs e)
        {
            TengahkanPanel();
        }

        private void TengahkanPanel()
        {
            if (panel1 != null)
            {
                panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
                panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            }
        }

        // Logika Tombol Daftar
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtKonfirmasi.Text;
            
            string nama = user; 
            string alamat = email;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(email) ||
        string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDASI EMAIL (HARUS ADA @ dan TITIK)
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format Email tidak valid!\nContoh: petani@gmail.com", "Validasi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // VALIDASI PASSWORD (KEAMANAN)

            // Syarat A: Minimal 8 Karakter
            if (pass.Length < 8)
            {
                MessageBox.Show("Password minimal harus 8 karakter!", "Password Lemah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Syarat B: Password dan Konfirmasi harus sama
            if (pass != confirm)
            {
                MessageBox.Show("Konfirmasi Password tidak cocok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // PROSES SIMPAN KE DATABASE
            try
            {
                C_Register controller = new C_Register();

                bool sukses = controller.RegistrasiPelanggan(user, pass, nama, alamat);

                if (sukses)
                {
                    MessageBox.Show("Registrasi Berhasil!\nSilakan login dengan akun baru Anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin login = new FormLogin();
                    login.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error Database");
            }
        }

        // Link ke Login
        private void lblMasuk_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void lblMasuk_Click_1(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();

            formLogin.Show();

            this.Hide();
        }
    }
}