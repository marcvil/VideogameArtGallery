using Domain.Models;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class GenresRepository : Repository<Genre>, IGenresRepository
    {
        private ApplicationDbContext applicationDbContext => (ApplicationDbContext)_context;
        public GenresRepository( ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
        public IEnumerable<Genre> GetAllGenresData()
        {
            return applicationDbContext.Genres
                 .ToList();
        }
    }
}
