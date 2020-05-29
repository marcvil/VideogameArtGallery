using Domain.Models;
using Domain.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideogameArtGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesPlatformsController : ControllerBase
    {
        private readonly IGamesPlatformsRepository repository;

        public GamesPlatformsController(IGamesPlatformsRepository repo)
        {
            repository = repo;
        }

        // GET: api/Games_Platform
        [HttpGet]
        public ActionResult<IEnumerable<GamesPlatforms>> GetAll()
        {

            return Ok(repository.GetAll());
        }




        // GET: api/Games_Platform/id
        [HttpGet("GetByPlatform/{platformId}")]
        public ActionResult<IEnumerable<GamesPlatforms>> GetByPlatform(int platformId)
        {
            var games = repository.GetGamesByPlatform(platformId);

            if (games != null)
            {
                return Ok(games);
            }
            else
            {
                return NotFound();
            }

        }
        // GET: api/Games_Platform/id
        [HttpGet("GetByGame/{gameId}")]
        public ActionResult<IEnumerable<GamesPlatforms>> GetByGame(int gameId)
        {
            var platforms = repository.GetGamesByPlatform(gameId);

            if (platforms != null)
            {
                return Ok(platforms);
            }
            else
            {
                return NotFound();
            }

        }
    }

}