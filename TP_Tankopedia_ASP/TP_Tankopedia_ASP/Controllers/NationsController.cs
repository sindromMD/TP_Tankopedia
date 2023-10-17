using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_Tankopedia_ASP.Data;
using TP_Tankopedia_ASP.Models;

namespace TP_Tankopedia_ASP.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NationsController : ControllerBase
    {
        private readonly TankopediaDbContext _context;

        public NationsController(TankopediaDbContext context)
        {
            _context = context;
        }

        // GET: api/Nations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nation>>> GetNations()
        {
          if (_context.Nations == null)
          {
              return NotFound();
          }
            return await _context.Nations.ToListAsync();
        }

        // GET: api/Nations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nation>> GetNation(int id)
        {
          if (_context.Nations == null)
          {
              return NotFound();
          }
            var nation = await _context.Nations.FindAsync(id);

            if (nation == null)
            {
                return NotFound();
            }

            return nation;
        }

        // PUT: api/Nations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNation(int id, Nation nation)
        {
            if (id != nation.Id)
            {
                return BadRequest();
            }

            _context.Entry(nation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NationExists(id))
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

        // POST: api/Nations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nation>> PostNation(Nation nation)
        {
          if (_context.Nations == null)
          {
              return Problem("Entity set 'TankopediaDbContext.Nations'  is null.");
          }
            _context.Nations.Add(nation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNation", new { id = nation.Id }, nation);
        }

        // DELETE: api/Nations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNation(int id)
        {
            if (_context.Nations == null)
            {
                return NotFound();
            }
            var nation = await _context.Nations.FindAsync(id);
            if (nation == null)
            {
                return NotFound();
            }
            var associatedTanks = _context.Tanks.Where(x => x.Id == id).Any();
            if (associatedTanks)
            {
                return StatusCode(StatusCodes.Status403Forbidden, new { Message = "We can't wipe out the nation that has tanks " });
            }

            _context.Nations.Remove(nation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NationExists(int id)
        {
            return (_context.Nations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
