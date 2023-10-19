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
    public class StrategicRolesController : ControllerBase
    {
        private readonly TankopediaDbContext _context;

        public StrategicRolesController(TankopediaDbContext context)
        {
            _context = context;
        }

        // GET: api/StrategicRoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StrategicRole>>> GetStrategicRoles()
        {
          if (_context.StrategicRoles == null)
          {
              return NotFound();
          }
            return await _context.StrategicRoles.OrderBy(sr=>sr.Name).ToListAsync();
        }

        // GET: api/StrategicRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StrategicRole>> GetStrategicRole(int id)
        {
          if (_context.StrategicRoles == null)
          {
              return NotFound();
          }
            var strategicRole = await _context.StrategicRoles.FindAsync(id);

            if (strategicRole == null)
            {
                return NotFound();
            }

            return strategicRole;
        }

        // PUT: api/StrategicRoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStrategicRole(int id, StrategicRole strategicRole)
        {
            if (id != strategicRole.Id)
            {
                return BadRequest();
            }

            _context.Entry(strategicRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StrategicRoleExists(id))
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

        // POST: api/StrategicRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StrategicRole>> PostStrategicRole(StrategicRole strategicRole)
        {
          if (_context.StrategicRoles == null)
          {
              return Problem("Entity set 'TankopediaDbContext.StrategicRoles'  is null.");
          }
            _context.StrategicRoles.Add(strategicRole);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStrategicRole", new { id = strategicRole.Id }, strategicRole);
        }

        // DELETE: api/StrategicRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStrategicRole(int id)
        {
            if (_context.StrategicRoles == null)
            {
                return NotFound();
            }
            var strategicRole = await _context.StrategicRoles.FindAsync(id);
            if (strategicRole == null)
            {
                return NotFound();
            }

            _context.StrategicRoles.Remove(strategicRole);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StrategicRoleExists(int id)
        {
            return (_context.StrategicRoles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
