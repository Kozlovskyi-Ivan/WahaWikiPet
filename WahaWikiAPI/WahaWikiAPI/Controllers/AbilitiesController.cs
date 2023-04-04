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
    public class AbilitiesController : ControllerBase
    {
        private readonly WahaDbContext _context;
        private readonly IAbilityService _abilityService;

        public AbilitiesController(WahaDbContext context, IAbilityService abilityService)
        {
            _context = context;
            _abilityService = abilityService;
        }

        // GET: api/Abilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Abilities>>> GetAbilities()
        {
            return await _abilityService.GetAbilities();
        }

        // GET: api/Abilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Abilities>> GetAbility(int id)
        {
            var ability = await _abilityService.GetAbilityById(id);

            if (ability == null)
            {
                return NotFound();
            }

            return ability;
        }

        // PUT: api/Abilities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAbilities(int id, CreateAbility ability)
        {
            await _abilityService.UpdateAbility(id, ability);

            try
            {
                await _abilityService.UpdateAbility(id, ability);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AbilitiesExists(id))
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

        // POST: api/Abilities
        [HttpPost]
        public async Task<ActionResult<Abilities>> PostAbilities(CreateAbility ability)
        {
            var newAbility = await _abilityService.CreateAbility(ability);

            return CreatedAtAction("GetAbilities", new { id = newAbility.Id }, newAbility);
        }

        // DELETE: api/Abilities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbilities(int id)
        {
            await _abilityService.DeleteAbility(id);

            return Ok();
        }

        private bool AbilitiesExists(int id)
        {
            return _context.Abilities.Any(e => e.Id == id);
        }
    }
}
