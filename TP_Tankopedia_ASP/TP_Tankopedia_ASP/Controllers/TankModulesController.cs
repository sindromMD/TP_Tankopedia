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
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We couldn't find any Tank Modules in our library!" });
            }
            return await _context.TankModules.ToListAsync();
        }

        // GET: api/TankModules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TankModule>> GetTankModule(int id)
        {
          if (_context.TankModules == null)
          {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We couldn't find any TankModules in our library!" });

            }
            var tankModule = await _context.TankModules.FindAsync(id);

            if (tankModule == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = $"Well, we tried to find the Module with id-{id}, but we don't seem to have any Modules matching this search'" });

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
                return StatusCode(StatusCodes.Status400BadRequest, new { Message = "Module ID doesn't match the requested ID." });
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
                    return StatusCode(StatusCodes.Status404NotFound, new { Message = "The Tank Module was not found. It may have been deleted by another user." });

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
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Entity set 'TankopediaDbContext.Tanks' is null." });
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
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We couldn't find any Tank Module in our library!" });
            }
            var tankModule = await _context.TankModules.FindAsync(id);
            if (tankModule == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = $"We couldn't delete the Tank Module with ID {id} , because it doesn't exist in our library!" });
            }

            _context.TankModules.Remove(tankModule);
            await _context.SaveChangesAsync();

            return StatusCode(StatusCodes.Status204NoContent, new { Message = "The Tank Module has been successfully deleted." });
        }

        private bool TankModuleExists(int id)
        {
            return (_context.TankModules?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
