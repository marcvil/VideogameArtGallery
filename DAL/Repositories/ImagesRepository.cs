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
        public override Image Get(int id)
        {
            return ApplicationDbContext.Images
                .Find(id);

        }
        public async Task<Image> GetAsync(int id)
        {
            return await ApplicationDbContext.Images
                 .FindAsync(id);
        }


        public override IEnumerable<Image> GetAll()
        {
            return ApplicationDbContext.Images
                 .ToList();
        }

      

        public async Task<IEnumerable<Image>> GetByOrderAsync(int pageIndex, int pageSize)
        {
            return await ApplicationDbContext.Images
                  .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
        }
    }
}
