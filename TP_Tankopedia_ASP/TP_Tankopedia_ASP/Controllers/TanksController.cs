using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
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
            return await _context.Tanks.OrderBy(x=>x.TypeTank).ToListAsync();
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
                   .Include(x => x.Nation).OrderBy(x=>x.TypeTank)
                   .ToListAsync();
                if(filteredTanks.Count == 0)
                    return StatusCode(StatusCodes.Status404NotFound, new { Message = $"We can't find tanks that match the criteria we are looking for. Search result: {filteredTanks.Count} tanks" });
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
                   .Include(x => x.TypeTank).OrderBy(x=>x.NationID)
                   .ToListAsync();
                if (filteredTanks.Count == 0)
                    return StatusCode(StatusCodes.Status404NotFound, new { Message = $"We can't find tanks that match the criteria we are looking for. \n Search result: {filteredTanks.Count} tanks" });
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
            var nation = _context.Nations.Find(tank.NationID);
            if (nation.Tanks.Count() >= 3) //Contrainte TP2
            {
                return StatusCode(StatusCodes.Status403Forbidden, new { Message = $"Maximum tank limit for this nation: \"{nation.Name}\" is restricted to 3 " });

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
