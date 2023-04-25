using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Dojo.Infrastructure.Repositories
{
    public class SamouraiRepository : ISamouraiRepository
    {
        private readonly DojoWebContext _context;

        public SamouraiRepository(DojoWebContext context)
        {
            _context = context;
        }

        public List<Samourai> GetAll()
        {
            return _context.Samourai.ToList();
        }

        public IPagedList<Samourai> GetAllPaged(int? pageNumber = 1, int? pageSize = 10)
        {
            int count = _context.Samourai.Count();
            return _context.Samourai.ToPagedList(pageNumber.Value, pageSize.Value, count); 
        }

        public Samourai GetById(int id)
        {
            return _context.Samourai.Find(id);
        }

        public void Add(Samourai samourai)
        {
            Samourai newSamourai = new Samourai(); 
            newSamourai.Id = samourai.Id;
            newSamourai.Name = samourai.Name;
            newSamourai.Strength = samourai.Strength;
            _context.Add(newSamourai);
            _context.SaveChanges(); // on le mettra dans un service : pattern Unit of work
        }

        public void Update(Samourai samourai)
        {
            Samourai modified = samourai;
            modified.Id = modified.Id;
            modified.Name = modified.Name;
            modified.Strength = modified.Strength;
            _context.Update(samourai);
            _context.SaveChanges();
        }

        public void Remove(Samourai samourai)
        {
            _context.Remove(samourai);
            _context.SaveChanges();
        }
    }
}
