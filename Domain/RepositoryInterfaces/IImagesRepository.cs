using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IImagesRepository : IRepository<Image>
    {
         Task<Image> GetAsync(int id);

         Task<IEnumerable<Image>> GetByOrderAsync(int pageIndex, int pageSize);
    }
}
