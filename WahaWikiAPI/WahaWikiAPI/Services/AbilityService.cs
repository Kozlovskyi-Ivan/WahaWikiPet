using Microsoft.EntityFrameworkCore;
using WahaWikiAPI.Database;
using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;

namespace WahaWikiAPI.Services
{
    
    public class AbilityService : IAbilityService
    {
        private readonly WahaDbContext _context;
        public AbilityService(WahaDbContext context)
        {
            _context= context;
        }
        public async Task<Abilities> CreateAbility(CreateAbility ability)
        {
            var newAbility = new Abilities();

            newAbility.Name = ability.Name;
            newAbility.ShortName = ability.ShortName;
            newAbility.Description = ability.Description;

            _context.Abilities.Add(newAbility);

            await _context.SaveChangesAsync();

            return newAbility;
        }

        public async Task<List<Abilities>> GetAbilities()
        {
            return await _context.Abilities.ToListAsync();
        }

        public async Task<Abilities?> GetAbilityById(int id)
        {
            return await _context.Abilities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAbility(int id, CreateAbility ability)
        {
            var abilityToUpdate = await _context.Abilities
                .FirstOrDefaultAsync(x=>x.Id==id);

            if (abilityToUpdate != null) {

                abilityToUpdate.Name= ability.Name;
                abilityToUpdate.ShortName= ability.ShortName;
                abilityToUpdate.Description= ability.Description;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAbility(int id)
        {
            var ability = await _context.Abilities.FirstOrDefaultAsync(x => x.Id == id);

            if (ability != null)
            {
                _context.Abilities.Remove(ability);
            }
            await _context.SaveChangesAsync();
        }
    }
}
