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
            return ApplicationDbContext.Games
                .Find(id);
                 
        }
        public IEnumerable<Game> GetByGenre(int genreId)
        {
            return ApplicationDbContext.Games
                .Where(x => x.GenreId == genreId).ToList();

        }

       





    }
}
