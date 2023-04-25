using Dojo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Dojo.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        IPagedList<T> GetAllPaged(int? page = 1, int? pageSize = 10);

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);
    }
}
