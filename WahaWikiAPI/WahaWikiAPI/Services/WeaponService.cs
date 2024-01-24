using Microsoft.EntityFrameworkCore;
using WahaWikiAPI.Database;
using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;

namespace WahaWikiAPI.Services
{
    public class WeaponService : IWeaponService
    {
        private readonly WahaDbContext _context;
        public WeaponService(WahaDbContext context)
        {
            _context = context;
        }
        public async Task CreateWeapon(CreateWeaponModel weaponModel)
        {
            List<WeaponAbilities> abilities = new List<WeaponAbilities>();

            if (weaponModel.Abilities != null)
            {
                foreach (var AbilityId in (weaponModel.Abilities))
                {
                    var exectingAbility = await _context.WeaponAbilities.FirstOrDefaultAsync(e => e.Id == AbilityId);
                    if (exectingAbility != null)
                    {
                        abilities.Add(exectingAbility);
                    }
                }
            }

            var newWeapon = new Weapon()
            {
                Name = weaponModel.Name,
                AP = weaponModel.AP,
                Range = weaponModel.Range,
                NumberOfShot = weaponModel.NumberOfShot,
                Damage = weaponModel.Damage,
                Strength = weaponModel.Strength,
                WeaponAbilities = abilities
            };

            if (_context.WeaponTypes.Any(e => e.Id == weaponModel.WeaponTypeId))
            {
                newWeapon.WeaponTypeId = weaponModel.WeaponTypeId;
            }

            _context.Weapons.Add(newWeapon);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateWeapon(int id, CreateWeaponModel weaponModel)
        {
            List<WeaponAbilities> abilities = new List<WeaponAbilities>();

            var weapon = await _context.Weapons.FirstOrDefaultAsync(t => t.WeaponId == id);

            weapon.Name = weaponModel.Name;
            weapon.WeaponTypeId = weaponModel.WeaponTypeId;
            weapon.NumberOfShot = weaponModel.NumberOfShot;
            weapon.Strength = weaponModel.Strength;
            weapon.Damage = weaponModel.Damage;
            weapon.AP = weaponModel.AP; ;
            weapon.Range = weaponModel.Range;

            _context.WeaponAbilitiesRelationships
                .RemoveRange(_context.WeaponAbilitiesRelationships
                .Where(e => e.WeaponId == weapon.WeaponId)
                );

            if (weaponModel.Abilities != null)
            {
                foreach (var AbilityId in (weaponModel.Abilities))
                {
                    var exectingAbility = await _context.WeaponAbilities
                        .FirstOrDefaultAsync(e => e.Id == AbilityId);

                    if (exectingAbility != null)
                    {
                        abilities.Add(exectingAbility);
                    }
                }
            }

            await _context.SaveChangesAsync();
        }
        public async Task<List<Weapon>> GetWeapons()
        {
            return await _context.Weapons
                .Include(t => t.WeaponType)
                .Include(t => t.WeaponAbilities).IgnoreAutoIncludes()
                .ToListAsync();
        }
        public async Task<Weapon?> GetWeaponById(int id)
        {
            return await _context.Weapons
                           .Include(t => t.WeaponType)
                           .Include(t => t.WeaponAbilities)
                           .FirstOrDefaultAsync(e => e.WeaponId == id);
        }
    }
}
