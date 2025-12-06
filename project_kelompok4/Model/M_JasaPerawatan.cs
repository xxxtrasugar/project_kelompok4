using System;

namespace project_kelompok4.Model
{
    public class M_JasaPerawatan
    {
        public int IdJasa { get; set; }
        public string NamaJasa { get; set; }
        public string Deskripsi { get; set; }
        public decimal Harga { get; set; }
        public string JamOperasional { get; set; }
        public int Slot { get; set; }
    }
}