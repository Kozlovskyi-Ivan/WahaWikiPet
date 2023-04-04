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
    public class WeaponsController : ControllerBase
    {
        private readonly WahaDbContext _context;
        private readonly IWeaponService _weaponService;


        public WeaponsController(WahaDbContext context, IWeaponService weaponService)
        {
            _context = context;
            _weaponService = weaponService;
        }

        // GET: api/Weapons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weapon>>> GetWeapons()
        {
            return await _weaponService.GetWeapons();
        }

        // GET: api/Weapons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weapon>> GetWeapon(int id)
        {
            var weapon = await _weaponService.GetWeaponById(id);

            if (weapon == null)
            {
                return NotFound();
            }

            return weapon;
        }

        // PUT: api/Weapons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeapon(int id, CreateWeaponModel weaponModel)
        {
            if (weaponModel == null)
            {
                return BadRequest();
            }
            await _weaponService.UpdateWeapon(id, weaponModel);

            return NoContent();
        }

        // POST: api/Weapons
        [HttpPost]
        public async Task<ActionResult<Weapon>> PostWeapon(CreateWeaponModel weaponModel)
        {
            if (weaponModel == null)
            {
                return BadRequest();
            }

            await _weaponService.CreateWeapon(weaponModel);

            return Ok();
        }

        // DELETE: api/Weapons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeapon(int id)
        {
            var weapon = await _context.Weapons.FindAsync(id);
            if (weapon == null)
            {
                return NotFound();
            }

            _context.Weapons.Remove(weapon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WeaponExists(int id)
        {
            return _context.Weapons.Any(e => e.WeaponId == id);
        }
    }
}
