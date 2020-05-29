using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryInterfaces
{
    public interface IGamesPlatformsRepository : IRepository<GamesPlatforms>
    {
        IEnumerable<GamesPlatforms> GetGamesByPlatform(int platform);
        IEnumerable<GamesPlatforms> GetPlatformsByGame(int game);
    }
}
