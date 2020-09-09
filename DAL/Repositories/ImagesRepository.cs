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
    public class ImagesRepository : Repository<Image>, IImagesRepository
    {
        private ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)_context;
        public ImagesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public override IEnumerable<Image> GetAll()
        {
            return ApplicationDbContext.Images
                 .ToList();
        }

        public override  Image Get(int id)
        {
            return  ApplicationDbContext.Images
                .Find(id);

        }

    }
}
