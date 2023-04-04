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
    public class UnitStatsController : ControllerBase
    {
        private readonly WahaDbContext _context;

        public UnitStatsController(WahaDbContext context)
        {
            _context = context;
        }

        // GET: api/UnitStats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnitStat>>> GetStatLines()
        {
            return await _context.StatLines.ToListAsync();
        }

        // GET: api/UnitStats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UnitStat>> GetUnitStat(int id)
        {
            var unitStat = await _context.StatLines.FindAsync(id);

            if (unitStat == null)
            {
                return NotFound();
            }

            return unitStat;
        }

        // PUT: api/UnitStats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnitStat(int id, UnitStat unitStat)
        {
            if (id != unitStat.Id)
            {
                return BadRequest();
            }

            _context.Entry(unitStat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitStatExists(id))
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

        // POST: api/UnitStats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UnitStat>> PostUnitStat(UnitStat unitStat)
        {
            _context.StatLines.Add(unitStat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnitStat", new { id = unitStat.Id }, unitStat);
        }

        // DELETE: api/UnitStats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnitStat(int id)
        {
            var unitStat = await _context.StatLines.FindAsync(id);
            if (unitStat == null)
            {
                return NotFound();
            }

            _context.StatLines.Remove(unitStat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UnitStatExists(int id)
        {
            return _context.StatLines.Any(e => e.Id == id);
        }
    }
}
