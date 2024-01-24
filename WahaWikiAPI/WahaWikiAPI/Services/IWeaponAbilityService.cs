using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;

namespace WahaWikiAPI.Services
{
    public interface IWeaponAbilityService
    {
        Task<List<WeaponAbilities>> GetWeaponAbilities();
        Task<WeaponAbilities> GetWeaponAbilityById(int id);
        Task<WeaponAbilities> CreateWeaponAbility(CreateWeaponAbility weaponAbility);
        Task UpdateWeaponAbility(int id, CreateWeaponAbility weaponAbility);
        Task DeleteWeaponAbility(int id);
    }
}
