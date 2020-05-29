using Domain.Models;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenresRepository : Repository<Genre>, IGenresRepository
    {
        private ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)_context;
        public GenresRepository( ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
        public override IEnumerable<Genre> GetAll()
        {
            return  ApplicationDbContext.Genres
                 .ToList();
        }

        public override  Genre Get(int id)
        {
            return ApplicationDbContext.Genres
                .Find(id);

        }
    }
}
