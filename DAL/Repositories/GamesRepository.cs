using Domain.Models;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class GamesRepository : Repository<Game>, IGamesRepository
    {
        private ApplicationDbContext applicationDbContext => (ApplicationDbContext)_context;
        public GamesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public IEnumerable<Game> GetAllGamesData()
        {
            return applicationDbContext.Games
                 .ToList();
        }
        /*
       public IEnumerable<Game> GetGamesByGenre(string genre)
       {
          /* return applicationDbContext.Games
               .Where(g => g.GameGenres)

               .Include(gen =>gen.GameGenres).ThenInclude(g => g.GenreName)
               .Where(g => g.GameGenres.Gen)

                .ToList();
                
          }
    */
        public IEnumerable<Game> GetGamesByName(string gameName)
        {
            return applicationDbContext.Games
                .Where(x=>x.GameName.Contains(gameName))
                 .ToList();
        }

    }
}
