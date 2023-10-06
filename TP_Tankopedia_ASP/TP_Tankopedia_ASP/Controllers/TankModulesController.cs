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
    public class TankModulesController : ControllerBase
    {
        private readonly TankopediaDbContext _context;

        public TankModulesController(TankopediaDbContext context)
        {
            _context = context;
        }

        // GET: api/TankModules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TankModule>>> GetTankModules()
        {
          if (_context.TankModules == null)
          {
              return NotFound();
          }
            return await _context.TankModules.ToListAsync();
        }

        // GET: api/TankModules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TankModule>> GetTankModule(int id)
        {
          if (_context.TankModules == null)
          {
              return NotFound();
          }
            var tankModule = await _context.TankModules.FindAsync(id);

            if (tankModule == null)
            {
                return NotFound();
            }

            return tankModule;
        }

        // PUT: api/TankModules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTankModule(int id, TankModule tankModule)
        {
            if (id != tankModule.Id)
            {
                return BadRequest();
            }

            _context.Entry(tankModule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TankModuleExists(id))
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

        // POST: api/TankModules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TankModule>> PostTankModule(TankModule tankModule)
        {
          if (_context.TankModules == null)
          {
              return Problem("Entity set 'TankopediaDbContext.TankModules'  is null.");
          }
            _context.TankModules.Add(tankModule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTankModule", new { id = tankModule.Id }, tankModule);
        }

        // DELETE: api/TankModules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTankModule(int id)
        {
            if (_context.TankModules == null)
            {
                return NotFound();
            }
            var tankModule = await _context.TankModules.FindAsync(id);
            if (tankModule == null)
            {
                return NotFound();
            }

            _context.TankModules.Remove(tankModule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TankModuleExists(int id)
        {
            return (_context.TankModules?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
