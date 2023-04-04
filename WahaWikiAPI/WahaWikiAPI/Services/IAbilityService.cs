using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;

namespace WahaWikiAPI.Services
{
    public interface IAbilityService
    {
        Task<List<Abilities>> GetAbilities();
        Task<Abilities?> GetAbilityById(int id);
        Task<Abilities?> CreateAbility(CreateAbility ability);
        Task UpdateAbility(int id, CreateAbility ability);
        Task DeleteAbility(int id);
    }
}
