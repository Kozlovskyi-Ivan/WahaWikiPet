using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;

namespace WahaWikiAPI.Services
{
    public interface IWeaponService
    {
        Task CreateWeapon(CreateWeaponModel weaponModel);
        Task UpdateWeapon(int Id, CreateWeaponModel weaponModel);
        Task<List<Weapon>> GetWeapons();
        Task<Weapon?> GetWeaponById(int id);
    }
}
