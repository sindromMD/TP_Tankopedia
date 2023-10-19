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
    public class TanksController : ControllerBase
    {
        private readonly TankopediaDbContext _context;

        public TanksController(TankopediaDbContext context)
        {
            _context = context;
        }

        // GET: api/Tanks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tank>>> GetTanks()
        {
          if (_context.Tanks == null)
          {
              return StatusCode(StatusCodes.Status404NotFound, new {Message = "We couldn't find any tanks in our library!" });
          }
            return await _context.Tanks.ToListAsync();
        }

        // GET: api/Tanks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tank>> GetTank(int id)
        {
          if (_context.Tanks == null)
          {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We couldn't find any tanks in our library!" });
            }
            var tank = await _context.Tanks.FindAsync(id);

            if (tank == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = $"Well, we tried to summon the tank with id-{id}, but it seems it\'s playing hide and seek in the Error 404 camouflage mode. Tactical difficulties, you know!'" });
            }
            return tank;
        }
        //GET : api/Tanks/{nationID}/{roleID}
        [HttpGet("{nationId}/{roleId?}")]
        public async Task<ActionResult<List<Tank>>> GetTanksFileredByNationAndRole(int nationId, int? roleId)
        {

            List<Tank> filteredTanks = new List<Tank>();
            if (_context.Tanks != null)
            {
                filteredTanks = await _context.Tanks
                   .Where(t => t.NationID == nationId && (roleId == 0 || t.StrategicRoleId == roleId))
                   .Include(x => x.Nation)
                   .ToListAsync();

            }
            else
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We couldn't find any tanks in our library!" });

            return filteredTanks;
        }

        //GET : api/Tanks/{nationID}/{roleID}
        [HttpGet("{typeId}/{roleId?}")]
        public async Task<ActionResult<List<Tank>>> GetTanksFileredByTypeTankAndRole(int typeId, int? roleId)
        {

            List<Tank> filteredTanks = new List<Tank>();
            if (_context.Tanks != null)
            {
                filteredTanks = await _context.Tanks
                   .Where(t => t.TypeID == typeId && (roleId == 0 || t.StrategicRoleId == roleId))
                   .Include(x => x.TypeTank)
                   .ToListAsync();

            }
            else
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We couldn't find any tanks in our library!" });

            return filteredTanks;
        }

        // PUT: api/Tanks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTank(int id, Tank tank)
        {
            if (id != tank.Id)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { Message = "Tank ID doesn't match the requested ID." });
            }

            _context.Entry(tank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TankExists(id))
                {
                    return StatusCode(StatusCodes.Status404NotFound, new { Message = "The tank was not found. It may have been deleted by another user." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tanks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tank>> PostTank(Tank tank)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { Message = "New tank data is invalid or required fields are not filled in. Try again but complete all the required" });
            }
            if (_context.Tanks == null)
          {
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Entity set 'TankopediaDbContext.Tanks' is null." });
            }
            _context.Tanks.Add(tank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTank", new { id = tank.Id }, tank);
        }

        // DELETE: api/Tanks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTank(int id)
        {
            if (_context.Tanks == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We couldn't find any tanks in our library!" });
            }
            var tank = await _context.Tanks.FindAsync(id);
            if (tank == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = $"We couldn't delete the tank with ID {id} , because it doesn't exist in our library!" });
            }

            _context.Tanks.Remove(tank);
            await _context.SaveChangesAsync();

            return StatusCode(StatusCodes.Status204NoContent, new { Message = "The tank has been successfully deleted." });
        }

        private bool TankExists(int id)
        {
            return (_context.Tanks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
