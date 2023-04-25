using Dojo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Dojo.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DojoContext _dojoContext;

        public BaseRepository(DojoContext dojoContext)
        {
            _dojoContext = dojoContext;
        }

        public void Add(T entity)
        {
            _dojoContext.Set<T>().Add(entity);
            _dojoContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dojoContext.Set<T>().ToList();
        }

        public IPagedList<T> GetAllPaged(int? page = 1, int? pageSize = 10)
        {
            int count = _dojoContext.Set<T>().ToList().Count;
            return _dojoContext.Set<T>().ToPagedList(page.Value, pageSize.Value, count);
        }

        public T GetById(int id)
        {
            return _dojoContext.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _dojoContext.Set<T>().Remove(entity);
            _dojoContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dojoContext.Set<T>().Update(entity);
            _dojoContext.SaveChanges();
        }
    }
}
