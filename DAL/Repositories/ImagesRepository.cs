using Domain.Models;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class ImagesRepository : Repository<Image>, IImagesRepository
    {
        private ApplicationDbContext applicationDbContext => (ApplicationDbContext)_context;
        public ImagesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public IEnumerable<Image> GetAllImagesData()
        {
            return applicationDbContext.Images
                 .ToList();
        }
       
    }
}
