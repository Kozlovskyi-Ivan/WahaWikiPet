using Microsoft.EntityFrameworkCore;
using WahaWikiAPI.Database;
using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;

namespace WahaWikiAPI.Services
{
    public class UnitService : IUnitService
    {
        private readonly WahaDbContext _context;
        public UnitService(WahaDbContext context)
        {
            _context=context;
        }
        public async Task CreateUnit(CreateUnitModel unitModel)
        {
            var newUnit = new Unit()
            {
                Name = unitModel.Name,
                Power = unitModel.Power
            };

            List<Weapon> weapons = new List<Weapon>();
            List<Abilities> abilities = new List<Abilities>();
            List<UnitStat> unitStatList = new List<UnitStat>();

            if (_context.WeaponTypes.Any(e => e.Id == unitModel.UnitTypeId))
            {
                newUnit.UnitType = await _context.UnitTypes.FirstAsync(e => e.Id == unitModel.UnitTypeId);
            }

            if (unitModel.UnitWeaponId != null)
            {
                foreach (var weaponId in (unitModel.UnitWeaponId))
                {
                    var unitWeapon = await _context.Weapons.FirstOrDefaultAsync(x => x.WeaponId == weaponId);

                    if (unitWeapon != null)
                    {
                        weapons.Add(unitWeapon);
                    }
                }
            }

            if (unitModel.UnitAbilitiesId != null)
            {
                foreach (var abilitiesId in (unitModel.UnitAbilitiesId))
                {
                    var unitability = await _context.Abilities.FirstOrDefaultAsync(x => x.Id == abilitiesId);

                    if (unitability != null)
                    {
                        abilities.Add(unitability);
                    }
                }
            }

            if (unitModel.UnitStatList != null)
            {
                foreach (var UnitStat in (unitModel.UnitStatList))
                {
                    unitStatList.Add(new UnitStat
                    {
                        ModelName = UnitStat.ModelName,
                        Move = UnitStat.Move,
                        MinNumber = UnitStat.MinNumber,
                        MaxNumber = UnitStat.MaxNumber,
                        WS = UnitStat.WS,
                        BS = UnitStat.BS,
                        Strength = UnitStat.Strength,
                        Toughness = UnitStat.Toughness,
                        Attacks = UnitStat.Attacks,
                        Wounds = UnitStat.Wounds,
                        Leadership = UnitStat.Leadership,
                        SavingThrows = UnitStat.SavingThrows,
                        PointPrice = UnitStat.PointPrice

                    });
                }
            }

            newUnit.Weapons = weapons;
            newUnit.Abilities = abilities;
            newUnit.UnitStatList = unitStatList;

            _context.Units.Add(newUnit);
            await _context.SaveChangesAsync();
        }
        public async Task<Unit?> UpdateUnit(int unitId,CreateUnitModel unitModel)
        {
            List<Weapon> weapons = new List<Weapon>();
            List<Abilities> abilities = new List<Abilities>();
            List<UnitStat> unitStatList = new List<UnitStat>();

            var unit = await _context.Units
                .FirstOrDefaultAsync(t => t.Id == unitId);

            unit.Name = unitModel.Name;
            unit.Power = unitModel.Power;

            _context.UnitWeaponRelationships
                .RemoveRange(_context.UnitWeaponRelationships
                .Where(x => x.UnitId == unit.Id));

            _context.UnitAbilitiesRelationships
                .RemoveRange(_context.UnitAbilitiesRelationships
                .Where(x => x.UnitId == unit.Id));

            _context.StatLines
                .RemoveRange(_context.StatLines
                .Where(x => x.Unit.Id == unit.Id));

            if (unitModel.UnitWeaponId != null)
            {
                foreach (var weapon in unitModel.UnitWeaponId)
                {
                    var existingWeapon = await _context.Weapons.FirstOrDefaultAsync(x => x.WeaponId == weapon);

                    if (existingWeapon != null)
                    {
                        weapons.Add(existingWeapon);
                    }
                }
            }

            if (unitModel.UnitAbilitiesId != null)
            {
                foreach (var ability in unitModel.UnitAbilitiesId)
                {
                    var existingAbilies = await _context.Abilities.FirstOrDefaultAsync(x => x.Id == ability);

                    if (existingAbilies != null)
                    {
                        abilities.Add(existingAbilies);
                    }
                }
            }

            if (unitModel.UnitStatList != null)
            {
                foreach (var unitStat in unitModel.UnitStatList)
                {
                    unitStatList.Add(new UnitStat
                    {
                        ModelName = unitStat.ModelName,
                        Move = unitStat.Move,
                        MinNumber = unitStat.MinNumber,
                        MaxNumber = unitStat.MaxNumber,
                        WS = unitStat.WS,
                        BS = unitStat.BS,
                        Strength = unitStat.Strength,
                        Toughness = unitStat.Toughness,
                        Attacks = unitStat.Attacks,
                        Wounds = unitStat.Wounds,
                        Leadership = unitStat.Leadership,
                        SavingThrows = unitStat.SavingThrows,
                        PointPrice = unitStat.PointPrice

                    });
                }
            }

            unit.Weapons = weapons;
            unit.UnitStatList = unitStatList;
            unit.Abilities = abilities;

            await _context.SaveChangesAsync();

            return unit;
        }
        public async Task<List<Unit>> GetUnitAll()
        {
            return await _context.Units
                .Include(t => t.Weapons).ThenInclude(t => t.WeaponType)
                .Include(t => t.Weapons).ThenInclude(t => t.WeaponAbilities)
                .Include(t => t.Abilities)
                .Include(t => t.UnitStatList)
                .Include(t => t.UnitType)
                .ToListAsync();
        }
        public async Task<Unit?> GetUnitById(int id)
        {
            return await _context.Units
                .Include(t => t.Weapons).ThenInclude(t => t.WeaponType)
                .Include(t => t.Weapons).ThenInclude(t => t.WeaponAbilities)
                .Include(t => t.Abilities)
                .Include(t => t.UnitStatList)
                .Include(t => t.UnitType).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
