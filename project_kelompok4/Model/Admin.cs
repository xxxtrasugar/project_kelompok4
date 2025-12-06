using Project_GARAP_Kelompok4.Model;
using project_kelompok4.View;

namespace project_kelompok4.Model
{
    public class Admin : Akun
    {
        public Admin(string username, string password, string nama)
            : base(username, password, "Admin")
        {
            this.NamaLengkap = nama;
        }

        public override void BukaDashboard()
        {
            // 1. Instansiasi Form Dashboard
            FormDashboardAdmin frm = new FormDashboardAdmin();

            // 2. KIRIM DATA DIRI KE DASHBOARD
            frm.SetInfoAdmin(this.NamaLengkap, this.Username);

            // 3. Tampilkan Form
            frm.Show();
        }
    }
}