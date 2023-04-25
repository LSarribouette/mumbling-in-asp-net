using Dojo.Domain.Interfaces.Repositories;
using Dojo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Dojo.Domain.Services
{
    public class BaseService<T> : IService<T> where T : class
    {
        protected readonly IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual void Create(T entity)
        {
            _repository.Add(entity);
        }

        public List<T> FetchAll()
        {
            return _repository.GetAll();
        }

        public IPagedList<T> FetchAllPaged(int? pageNumber = 1, int? pageSize = 10)
        {
            return _repository.GetAllPaged(pageNumber, pageSize);
        }

        public T FindById(int id)
        {
            return _repository.GetById(id);
        }

        public void Delete(T entity)
        {
            _repository.Remove(entity);
        }

        public void Edit(T entity)
        {
            _repository.Update(entity);
        }
    }
}
