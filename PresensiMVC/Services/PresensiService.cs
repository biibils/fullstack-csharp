using PresensiMVC.Models;

namespace PresensiMVC.Services
{
    public class PresensiService : IPresensiService
    {
        private readonly List<Presensi> _presensi;

        public PresensiService()
        {
            _presensi = new List<Presensi>
            {
                new Presensi { Id = 1, Nama = "John Doe"},
                new Presensi { Id = 2, Nama = "Jane Smith"}
            };
        }

        public
    }
}