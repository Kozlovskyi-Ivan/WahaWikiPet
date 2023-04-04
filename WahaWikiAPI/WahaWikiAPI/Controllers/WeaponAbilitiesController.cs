using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WahaWikiAPI.Database;
using WahaWikiAPI.Entities;

namespace WahaWikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponAbilitiesController : ControllerBase
    {
        private readonly WahaDbContext _context;

        public WeaponAbilitiesController(WahaDbContext context)
        {
            _context = context;
        }

        // GET: api/WeaponAbilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeaponAbilities>>> GetWeaponAbilities()
        {
            return await _context.WeaponAbilities.ToListAsync();
        }

        // GET: api/WeaponAbilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WeaponAbilities>> GetWeaponAbilities(int id)
        {
            var weaponAbilities = await _context.WeaponAbilities.FindAsync(id);

            if (weaponAbilities == null)
            {
                return NotFound();
            }

            return weaponAbilities;
        }

        // PUT: api/WeaponAbilities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeaponAbilities(int id, WeaponAbilities weaponAbilities)
        {
            if (id != weaponAbilities.WeaponAbilitiesId)
            {
                return BadRequest();
            }

            _context.Entry(weaponAbilities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeaponAbilitiesExists(id))
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
        public async Task<ActionResult<WeaponAbilities>> PostWeaponAbilities(WeaponAbilities weaponAbilities)
        {
            _context.WeaponAbilities.Add(weaponAbilities);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWeaponAbilities", new { id = weaponAbilities.WeaponAbilitiesId }, weaponAbilities);
        }

        // DELETE: api/WeaponAbilities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeaponAbilities(int id)
        {
            var weaponAbilities = await _context.WeaponAbilities.FindAsync(id);
            if (weaponAbilities == null)
            {
                return NotFound();
            }

            _context.WeaponAbilities.Remove(weaponAbilities);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WeaponAbilitiesExists(int id)
        {
            return _context.WeaponAbilities.Any(e => e.WeaponAbilitiesId == id);
        }
    }
}
