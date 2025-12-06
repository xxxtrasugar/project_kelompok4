using System;

namespace Project_GARAP_Kelompok4.Model
{
    // Konsep OOP: ABSTRACTION (Class Abstract)
    public abstract class Akun
    {
        // Konsep OOP: ENCAPSULATION (Properties)
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // 'Admin' atau 'Pelanggan'
        public string NamaLengkap { get; set; }

        // Constructor
        public Akun(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        // Konsep OOP: POLYMORPHISM (Abstract Method)
        public abstract void BukaDashboard();
    }
}