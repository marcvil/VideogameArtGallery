using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using Domain.Models;
using Domain.RepositoryInterfaces;

namespace VideogameArtGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGamesRepository repository;

        public GamesController(IGamesRepository repo)
        {
            repository = repo;
        }

        // GET: api/Games
        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetAll()
        {

            return Ok(repository.GetAll());
        }

        
       // GET: api/Games/5
       [HttpGet("{id}")]
       public ActionResult<Game> Get(int id)
       {
           var game = repository.Get(id);

           if (game != null)
           {
               return Ok(game);
           }
           else
           {
               return NotFound();
           }

       }
      
       
       // GET: api/Genres/genreName
       [HttpGet("GetByGenre/{genreId}")]
       public ActionResult<IEnumerable<Game>> GetByGenre(int genreId)
       {
           var game = repository.GetByGenre(genreId);

           if (game != null)
           {
               return Ok(game);
           }
           else
           {
               return NotFound();
           }

       }
        
       
    }

}
