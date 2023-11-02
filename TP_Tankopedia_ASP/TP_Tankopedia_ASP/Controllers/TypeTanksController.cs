using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_Tankopedia_ASP.Data;
using TP_Tankopedia_ASP.Models;
using TP_Tankopedia_ASP.Utility;

namespace TP_Tankopedia_ASP.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TypeTanksController : ControllerBase
    {
        private readonly TankopediaDbContext _context;

        public TypeTanksController(TankopediaDbContext context)
        {
            _context = context;
        }

        // GET: api/TypeTanks
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<TypeTank>>> GetTypeTanks()
        {
          if (_context.TypeTanks == null)
          {
              return NotFound();
          }
            return await _context.TypeTanks.ToListAsync();
        }

        // GET: api/TypeTanks/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<TypeTank>> GetTypeTank(int id)
        {
          if (_context.TypeTanks == null)
          {
              return NotFound();
          }
            var typeTank = await _context.TypeTanks.FindAsync(id);

            if (typeTank == null)
            {
                return NotFound();
            }

            return typeTank;
        }

        // PUT: api/TypeTanks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = AppConstants.AdminRole)]
        public async Task<IActionResult> PutTypeTank(int id, TypeTank typeTank)
        {
            if (id != typeTank.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeTank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeTankExists(id))
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

        // POST: api/TypeTanks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = AppConstants.AdminRole)]
        public async Task<ActionResult<TypeTank>> PostTypeTank(TypeTank typeTank)
        {
          if (_context.TypeTanks == null)
          {
              return Problem("Entity set 'TankopediaDbContext.TypeTanks'  is null.");
          }
            _context.TypeTanks.Add(typeTank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeTank", new { id = typeTank.Id }, typeTank);
        }

        // DELETE: api/TypeTanks/5
        [HttpDelete("{id}")]
        [Authorize(Roles = AppConstants.AdminRole)]
        public async Task<IActionResult> DeleteTypeTank(int id)
        {
            if (_context.TypeTanks == null)
            {
                return NotFound();
            }
            var typeTank = await _context.TypeTanks.FindAsync(id);
            if (typeTank == null)
            {
                return NotFound();
            }

            _context.TypeTanks.Remove(typeTank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeTankExists(int id)
        {
            return (_context.TypeTanks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
