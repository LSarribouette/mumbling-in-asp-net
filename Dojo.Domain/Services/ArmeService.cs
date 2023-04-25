using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Domain.Services
{
    public class ArmeService : BaseService<Arme>
    {
        public ArmeService(IArmeRepository repository) : base(repository)
        {
        }
    }
}
