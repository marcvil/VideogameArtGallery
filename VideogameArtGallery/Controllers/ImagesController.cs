﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using Domain.Models;
using Domain.RepositoryInterfaces;
using System.IO;
using System.Text;

namespace VideogameArtGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;


        private readonly IImagesRepository repository;

        public ImagesController(IImagesRepository repo)
        {
            repository = repo;
            
        }

        
        // GET: api/Images
        [HttpGet]
        public  ActionResult<List<ImageDTO>> GetImages()
        {
 
             IEnumerable<Image> listImages = repository.GetAll();
            List<ImageDTO> list = new List<ImageDTO>();
            
            if (listImages == null)
            {
                return NotFound();
            }
            else
            {
                foreach (Image i in listImages)
                {
                    Byte[] b = System.IO.File.ReadAllBytes(i.ImgUrl);   // You can use your own method over here.  
                    string base64ImageRepresentation = "data:image/jpeg;base64," + Convert.ToBase64String(b);
                    ImageDTO img = new ImageDTO
                    {
                        imageId = i.ImageId,
                        imgName = i.ImgName,
                        imgDescription = i.ImgDescription,
                        imgUrl = base64ImageRepresentation,
                        platform = i.PlatformId 
                    };
                    list.Add(img);

                }

                return Ok(list);

            }

            
        }

        // GET: api/Images/5
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ImageDTO>> GetImage(int id)
        {
            // Image image =  repository.Get(id);
            Image image = await  repository.GetAsync(id);
            if (image == null)
            {
                return NotFound();
            }
            else { 

            Byte[] b = System.IO.File.ReadAllBytes(image.ImgUrl);   // You can use your own method over here.  
            string base64ImageRepresentation ="data:image/jpeg;base64," + Convert.ToBase64String(b);
            //var file = File(b, "image/jpeg;base64", image.ImgName);
            
               ImageDTO img = new ImageDTO
            {
                imageId = image.ImageId,
                imgName = image.ImgName,
                imgDescription = image.ImgDescription,
                platform = image.PlatformId,
                imgUrl = base64ImageRepresentation
                   
               };

            return Ok(img);

            }



        }



        // PUT: api/Images/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImage(int id, Image image)
        {
            if (id != image.ImageId)
            {
                return BadRequest();
            }

            _context.Entry(image).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageExists(id))
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

        // POST: api/Images
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Image>> PostImage(Image image)
        {
            _context.Images.Add(image);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImage", new { id = image.ImageId }, image);
        }

        // DELETE: api/Images/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Image>> DeleteImage(int id)
        {
            var image = await _context.Images.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }

            _context.Images.Remove(image);
            await _context.SaveChangesAsync();

            return image;
        }

        private bool ImageExists(int id)
        {
            return _context.Images.Any(e => e.ImageId == id);
        }
    }
}
