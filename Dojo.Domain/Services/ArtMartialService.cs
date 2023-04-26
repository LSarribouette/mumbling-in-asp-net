using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using Dojo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Domain.Services
{
    public class ArtMartialService : BaseService<ArtMartial>
    {
        public ArtMartialService(IArtMartialRepository repository) : base(repository)
        {
        }
    }
}
