using project_kelompok4.View;
using System;
using System.Windows.Forms;

namespace Project_GARAP_Kelompok4.Model
{
    // Konsep OOP: INHERITANCE
    public class Pelanggan : Akun
    {
        public string Alamat { get; set; }

        public Pelanggan(int id, string username, string password, string nama, string alamat)
            : base(username, password, "Pelanggan")
        {
            this.Id = id;
            this.NamaLengkap = nama;
            this.Alamat = alamat;
        }

        public override void BukaDashboard()
        {
            FormUtamaPelanggan frm = new FormUtamaPelanggan(
                this.Id,
                this.NamaLengkap,
                this.Username
            );

            frm.Show();
        }
    }
}