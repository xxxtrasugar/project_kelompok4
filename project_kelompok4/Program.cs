using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_kelompok4.View;
namespace project_kelompok4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ubah baris ini dari "new Form1()" menjadi "new FormLogin()"
            Application.Run(new FormLogin());
        }
    }
}
