using Domain.Models;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DAL.Repositories
{
    public class GamesRepository : Repository<Game>, IGamesRepository
    {
        private ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)_context;
        public GamesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public override IEnumerable<Game> GetAll()
        {
            return ApplicationDbContext.Games
                 .ToList();
        }
 
        public override Game Get(int id)
        {
          

            Game result = ApplicationDbContext.Games
                .Include(g => g.Genre)
                .Include(p => p.GamesPlatforms).ThenInclude(p => p.Platform)
                .Include(i => i.Images)
                .First(g => g.GameId == id);

            return result;



        }
        public IEnumerable<Game> GetByGenre(int genreId)
        {
            return ApplicationDbContext.Games
                .Where(x => x.GenreId == genreId).ToList();

        }

       





    }
}
