using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp.Processing;
using TP_Tankopedia_ASP.Data;
using TP_Tankopedia_ASP.Models;
using TP_Tankopedia_ASP.Utility;

namespace TP_Tankopedia_ASP.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly TankopediaDbContext _context;

        public PicturesController(TankopediaDbContext context)
        {
            _context = context;
        }

        // GET: api/Pictures
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Picture>>> GetPicture()
        {
          if (_context.Picture == null)
          {
              return NotFound();
          }
            return await _context.Picture.ToListAsync();
        }

        // GET: api/Pictures/5
        [HttpGet("{size}/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Picture>> GetPicture(string size, int id)
        {
            var picture = await _context.Picture.FindAsync(id);

            if (picture == null)
            {
                return NotFound();
            }

            Match m = Regex.Match(size, "lg|sm|original");

            if (!m.Success)
            {
                return BadRequest();
            }

            byte[] bytes = System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + "/images/" + size + "/" + picture.FileName);

            return File(bytes, picture.MimeType);
        }


        [HttpPut]   //(Pour les tests) Ajout d'une image via Swagger
        [DisableRequestSizeLimit]
        [Authorize(Roles = AppConstants.AdminRole + "," + AppConstants.TankCommander)]
        public async Task<ActionResult<Picture>> PostPictureSwagger(IFormFile file)
        {
            try
            {
                // Télécharger l'image
                Image originalImage = Image.Load(file.OpenReadStream());
                Picture picture = new Picture();
                picture.FileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                picture.MimeType = file.ContentType;
                picture.DateOfAddition = DateTime.Now;

                // Enregistrer l'image originale dans le dossier "original".
                originalImage.Save(Directory.GetCurrentDirectory() + "/images/original/" + picture.FileName);

                // Créer une copie de l'image à redimensionner(large)
                Image lgImage = originalImage;
                // Redimensionne l'image - large
                lgImage.Mutate(i =>
                    i.Resize(new ResizeOptions()
                    {
                        Mode = ResizeMode.Min,
                        Size = new Size() { Height = 300 }
                    })
                    );
                // Enregistrer une large image dans le dossier "lg"
                lgImage.Save(Directory.GetCurrentDirectory() + "/images/lg/" + picture.FileName);

                // Créer une copie de l'image à redimensionner(small)
                Image smImage = lgImage;
                // Redimensionne la petite image
                smImage.Mutate(i =>
                    i.Resize(new ResizeOptions()
                    {
                        Mode = ResizeMode.Min,
                        Size = new Size() { Height = 150 }
                    })
                    );
                // Enregistrer la petite image dans le dossier "sm".
                smImage.Save(Directory.GetCurrentDirectory() + "/images/sm/" + picture.FileName);

                _context.Picture.Add(picture);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { }
            return Ok();
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        [Authorize(Roles = AppConstants.AdminRole)]
        public async Task<ActionResult<Picture>> PostPicture()
        {
            try
            {
                // Télécharger l'image
                IFormCollection formCollection = await Request.ReadFormAsync();
                IFormFile file = formCollection.Files.GetFile("image");
                Image originalImage = Image.Load(file.OpenReadStream());
                Picture picture = new Picture();
                picture.FileName = Guid.NewGuid().ToString() + Path.GetFileName(file.FileName);
                picture.MimeType = file.ContentType;
                picture.DateOfAddition = DateTime.Now;

                // Enregistrer l'image originale dans le dossier "original".
                originalImage.Save(Directory.GetCurrentDirectory() + "/images/original/" + picture.FileName);

                // Créer une copie de l'image à redimensionner(large)
                Image lgImage = originalImage;
                // Redimensionne l'image - large
                lgImage.Mutate(i =>
                    i.Resize(new ResizeOptions()
                    {
                        Mode = ResizeMode.Min,
                        Size = new Size() { Height = 300 }
                    })
                    );
                // Enregistrer une large image dans le dossier "lg"
                lgImage.Save(Directory.GetCurrentDirectory() + "/images/lg/" + picture.FileName);

                // Créer une copie de l'image à redimensionner(small)
                Image smImage = lgImage;
                // Redimensionne la petite image
                smImage.Mutate(i =>
                    i.Resize(new ResizeOptions()
                    {
                        Mode = ResizeMode.Min,
                        Size = new Size() { Height = 150 }
                    })
                    );
                // Enregistrer la petite image dans le dossier "sm".
                smImage.Save(Directory.GetCurrentDirectory() + "/images/sm/" + picture.FileName);

                _context.Picture.Add(picture);
                await _context.SaveChangesAsync();
                return picture;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = AppConstants.AdminRole)]
        public async Task<IActionResult> DeletePicture(int id)
        {
            var picture = await _context.Picture.FindAsync(id);
            if (picture == null)
            {
                return NotFound();
            }
            System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/lg/" + picture.FileName);
            System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/sm/" + picture.FileName);
            System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/original/" + picture.FileName);
            _context.Picture.Remove(picture);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool PictureExists(int id)
        {
            return (_context.Picture?.Any(e => e.pictureId == id)).GetValueOrDefault();
        }
    }
}
