using Domain.Models;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class PlatformsRepository : Repository<Platform>, IPlatformsRepository
    {
        private ApplicationDbContext applicationDbContext => (ApplicationDbContext)_context;
        public PlatformsRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
        

        public IEnumerable<Platform> GetAllPlatformsData()
        {
            return applicationDbContext.Platforms
                 .ToList();
        }
       
    }
}
