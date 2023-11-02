using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TP_Tankopedia_ASP.Data;
using TP_Tankopedia_ASP.Models;
using TP_Tankopedia_ASP.Utility;

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
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We can't find any nation in our library" });
            }
            return await _context.Nations.ToListAsync();
        }

        // GET: api/Nations/5 
        [HttpGet("{id}")]
        public async Task<ActionResult<Nation>> GetNation(int id)
        {
            if (_context.Nations == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We can't find any nation in our library" });
            }
            var nation = await _context.Nations.FindAsync(id);

            if (nation == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "Unfortunately, the nation you are looking for does not exist in our list" });

            }

            return nation;
        }


        // PUT: api/Nations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = AppConstants.AdminRole)]
        public async Task<IActionResult> PutNation(int id, Nation nation)
        {
            if (id != nation.Id)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { Message = "Nation ID doesn't match the requested ID." });

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
                    return StatusCode(StatusCodes.Status404NotFound, new { Message = "The Nation was not found. It may have been deleted by another user." });

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
        [Authorize(Roles = AppConstants.AdminRole)]
        public async Task<ActionResult<Nation>> PostNation(Nation nation)
        {
            if (_context.Nations == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We can't find any nation in our library" });

            }
            if (_context.Nations.Any(existingNation => existingNation.Name.ToLower() == nation.Name.ToLower()))
            {
                return StatusCode(StatusCodes.Status409Conflict, new { Message = "A nation with the same name already exists." });
            }

            if (_context.Nations.Count() >= 12) //Limite fixée par le développeur
            {
                return StatusCode(StatusCodes.Status403Forbidden, new { Message = "Adding more than 12 nations is impossible at the moment : restriction " });
            }
            _context.Nations.Add(nation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNation", new { id = nation.Id }, nation);
        }

        // DELETE: api/Nations/5
        [HttpDelete("{id}")]
        [Authorize(Roles = AppConstants.AdminRole)]
        public async Task<IActionResult> DeleteNation(int id)
        {
            if (_context.Nations == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "We can't find any nation in our library" });

            }
            var nation = await _context.Nations.FindAsync(id);
            if (nation == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = "Unfortunately, the nation you are looking for does not exist in our list" });

            }
            if (_context.Tanks !=null)
            {
                var associatedTanks = _context.Tanks.Where(x => x.NationID == id).Any();
                if (associatedTanks)
                {
                    return StatusCode(StatusCodes.Status403Forbidden, new { Message = "We can't wipe out the nation that has tanks " });
                }
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
