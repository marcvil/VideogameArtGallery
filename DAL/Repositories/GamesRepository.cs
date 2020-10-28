using Domain.Models;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GamesRepository : Repository<Game>, IGamesRepository
    {
        private ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)_context;
        public GamesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        #region GETS

        public override Game Get(int id)
        {


            Game result = ApplicationDbContext.Games  //.Find(id);
                .Include(g => g.Genre)
                .Include(p => p.GamesPlatforms).ThenInclude(p => p.Platform)
                .Include(i => i.Images)
                .First(g => g.GameId == id);
               
            return result;

        }
        public async Task<Game> GetAsync(int id)
        {
            return await ApplicationDbContext.Games  //.Find(id);
                 .Include(g => g.Genre).ThenInclude(gg => gg.Genre)
                 .Include(i=>i.ImageCover)
                 .Include(l => l.ImageGameLogo)
                 .Include(p => p.GamesPlatforms).ThenInclude(p => p.Platform)
                 .FirstAsync(g => g.GameId == id);

          
        }


        #region GetBY...
        public IEnumerable<Game> GetByGenre(int genreId)
        {
            return null;
            //return ApplicationDbContext.Games
            //.Where(x => x.GenreId == genreId).ToList();

        }
        #endregion
        

        public override IEnumerable<Game> GetAll()
        {
            return ApplicationDbContext.Games
                 .ToList();
        }

       

      
       
        #endregion
        #region Others
        #endregion






    }
}
