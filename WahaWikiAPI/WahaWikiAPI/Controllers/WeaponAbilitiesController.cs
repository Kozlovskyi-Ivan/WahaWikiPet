using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WahaWikiAPI.Database;
using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;
using WahaWikiAPI.Services;

namespace WahaWikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponAbilitiesController : ControllerBase
    {
        private readonly WahaDbContext _context;
        private readonly IWeaponAbilityService _weaponAbilityService;

        public WeaponAbilitiesController(WahaDbContext context, IWeaponAbilityService weaponAbilityService)
        {
            _context = context;
            _weaponAbilityService = weaponAbilityService;
        }

        // GET: api/WeaponAbilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeaponAbilities>>> GetWeaponAbilities()
        {
            return await _weaponAbilityService.GetWeaponAbilities();
        }

        // GET: api/WeaponAbilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WeaponAbilities>> GetWeaponAbilities(int id)
        {
            var weaponAbilities = await _weaponAbilityService.GetWeaponAbilityById(id);

            if (weaponAbilities == null)
            {
                return NotFound();
            }

            return weaponAbilities;
        }

        // PUT: api/WeaponAbilities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeaponAbilities(int id, CreateWeaponAbility weaponAbilities)
        {

            if (await WeaponAbilitiesExists(id))
            {
                return NotFound();
            }

            try
            {
                await _weaponAbilityService.UpdateWeaponAbility(id, weaponAbilities);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!(await WeaponAbilitiesExists(id)))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/WeaponAbilities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WeaponAbilities>> PostWeaponAbilities(CreateWeaponAbility weaponAbilities)
        {
            var weaponAbility = await _weaponAbilityService.CreateWeaponAbility(weaponAbilities);

            return CreatedAtAction("GetWeaponAbilities", new { id = weaponAbility.Id }, weaponAbility);
        }

        // DELETE: api/WeaponAbilities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeaponAbilities(int id)
        {
            var weaponAbilities = await _weaponAbilityService.GetWeaponAbilityById(id);
            if (weaponAbilities == null)
            {
                return NotFound();
            }

            await _weaponAbilityService.DeleteWeaponAbility(id);

            return NoContent();
        }

        private async Task<bool> WeaponAbilitiesExists(int id)
        {
            var weaponAbility = await _weaponAbilityService.GetWeaponAbilityById(id);

            return weaponAbility == null;
        }
    }
}
