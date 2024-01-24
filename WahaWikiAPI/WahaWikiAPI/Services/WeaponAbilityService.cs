using Microsoft.EntityFrameworkCore;
using WahaWikiAPI.Database;
using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;

namespace WahaWikiAPI.Services
{
    public class WeaponAbilityService : IWeaponAbilityService
    {
        private readonly WahaDbContext context;

        public WeaponAbilityService(WahaDbContext context)
        {
            this.context = context;
        }
        public async Task<WeaponAbilities> CreateWeaponAbility(CreateWeaponAbility weaponAbility)
        {
            var newWeaponAbility = new WeaponAbilities();

            newWeaponAbility.Name = weaponAbility.Name;
            newWeaponAbility.ShortName = weaponAbility.ShortName;
            newWeaponAbility.Description = weaponAbility.Description;

            context.WeaponAbilities.Add(newWeaponAbility);

            await context.SaveChangesAsync();

            return newWeaponAbility;
        }

        public async Task DeleteWeaponAbility(int id)
        {
            var weaponAbility = await context.WeaponAbilities.FirstOrDefaultAsync(x => x.Id == id);

            if (weaponAbility != null)
            {
                context.WeaponAbilities.Remove(weaponAbility);
            }
            await context.SaveChangesAsync();
        }

        public async Task<List<WeaponAbilities>> GetWeaponAbilities()
        {
            return await context.WeaponAbilities.ToListAsync();
        }

        public async Task<WeaponAbilities?> GetWeaponAbilityById(int id)
        {
            return await context.WeaponAbilities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateWeaponAbility(int id, CreateWeaponAbility weaponAbility)
        {
            var weaponAbilityToUpdate = await context.WeaponAbilities
                .FirstOrDefaultAsync(x => x.Id == id);

            if (weaponAbilityToUpdate != null)
            {
                weaponAbilityToUpdate.Name = weaponAbility.Name;
                weaponAbilityToUpdate.ShortName = weaponAbility.ShortName;
                weaponAbilityToUpdate.Description = weaponAbility.Description;
                
                await context.SaveChangesAsync();
            }
        }
    }
}
