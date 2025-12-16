using PresensiMVC.Models;

namespace PresensiMVC.Services
{
    public interface IPresensiService
    {
        Task<List<Presensi>> GetAllPresensiAsync();
        Task<Presensi> GetPresensiByIdAsync(int id);
        Task<bool> CreatePresensiAsync(Presensi presensi);
        Task<bool> UpdatePresensiAsync(int id, Presensi presensi);
        Task<bool> DeletePresensiAsync(int id);
    }
}