using Dojo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Dojo.Domain.Interfaces.Services
{
    public interface IService<T> where T : class
    {
        public List<T> FetchAll();

        public IPagedList<T> FetchAllPaged(int? pageNumber = 1, int? pageSize = 10);

        public T FindById(int id);

        public void Create(T entity);

        public void Edit(T entity);

        public void Delete(T entity);
    }
}
