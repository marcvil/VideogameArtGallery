using Domain.Models;
using Domain.RepositoryInterfaces;

using System.Collections.Generic;
using System.Linq;


namespace DAL.Repositories
{
    public class GamesPlatformsRepository : Repository<GamesPlatforms>, IGamesPlatformsRepository
    {
        private ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)_context;
        public GamesPlatformsRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public override IEnumerable<GamesPlatforms> GetAll()
        {
            return ApplicationDbContext.GamesPlatforms
                 .ToList();
        }

        public IEnumerable<GamesPlatforms> GetGamesByPlatform(int platformId)
        {
            return ApplicationDbContext.GamesPlatforms
                .Where(x => x.PlatformId == platformId).ToList();
        }

        public IEnumerable<GamesPlatforms> GetPlatformsByGame(int gameId)
        {
            return ApplicationDbContext.GamesPlatforms
              .Where(x => x.GameId == gameId).ToList();
        }
    }
}
