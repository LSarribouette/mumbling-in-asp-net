using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Dojo.Domain.Services
{
    public class SamouraiService
    {
        private readonly ISamouraiRepository _samouraiRepository;

        public SamouraiService(ISamouraiRepository samouraiRepository)
        {
            _samouraiRepository = samouraiRepository;
        }

        public List<Samourai> GetAllSamourais()
        {
            return _samouraiRepository.GetAll();
        }

        public IPagedList<Samourai> GetAllSamouraisPaged(int? pageNumber = 1, int? pageSize = 10)
        {
            return _samouraiRepository.GetAllPaged(pageNumber, pageSize);
        }

        public Samourai GetSamouraiById(int id)
        {
            return _samouraiRepository.GetById(id);
        }

        public void CreateSamourai(Samourai samourai)
        {
            _samouraiRepository.Add(samourai);
        }
    }
}
