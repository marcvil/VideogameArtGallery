using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IGamesRepository : IRepository<Game>
    {
        Task<Game> GetAsync(int id);
        IEnumerable<Game> GetByGenre(int genreId);


    }
}
