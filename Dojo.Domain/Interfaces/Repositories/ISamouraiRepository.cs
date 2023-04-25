using Dojo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Dojo.Domain.Interfaces.Repositories
{
    public interface ISamouraiRepository
    {
        List<Samourai> GetAll();

        IPagedList<Samourai> GetAllPaged(int? page = 1, int? pageSize = 10);

        Samourai GetById(int id);

        void Add(Samourai samourai);

        void Update(Samourai samourai);

        void Remove(Samourai samourai);
    }
}
