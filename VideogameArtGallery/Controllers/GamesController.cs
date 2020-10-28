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
using VideogameArtGallery.Data_Transfer_Objects;

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


        // GET: api/Games/5
       [HttpGet("{id}")]
       public async Task<ActionResult<Game>> Get(int id)
       {
           var game = await repository.GetAsync(id);

           if (game != null)
           {
               return  Ok(game);
           }
           else
           {
               return NotFound();
           }

       }
        [HttpGet("ImageCover/{id}")]
        public async Task<ActionResult<GameCoverCardDTO>> GetImageCover(int id)
        {
            var game = await repository.GetAsync(id);

            if (game == null)
            {
                return NotFound();
            }
            else
            {
                
                GameCoverCardDTO gameCoverCard = new GameCoverCardDTO
                {
                    gameName = game.GameName,
                    gameDescription = game.GameDescription,
                    imageCoverUrl = "data:image/jpeg;base64," +
                                       Convert.ToBase64String(System.IO.File.ReadAllBytes(game.ImageCover.ImgCoverUrl)),
                    imageGameLogoUrl = "data:image/jpeg;base64," +
                                        Convert.ToBase64String(System.IO.File.ReadAllBytes(game.ImageGameLogo.ImgGameLogoUrl)),
                    platformsIds = game.GamesPlatforms.Select(g =>g.Platform.PlatformId).ToArray(),
                    genresNames = game.Genre.Select(g => g.Genre.GenreName).ToArray()

                };

                return Ok(gameCoverCard);
                
                //return Ok(game);
            }

        }
        // GET: api/Games
        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetAll()
        {

            return Ok(repository.GetAll());
        }

        
       
      
       
        
       
    }

}
