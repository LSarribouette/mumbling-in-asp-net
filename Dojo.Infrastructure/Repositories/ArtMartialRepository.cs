using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Infrastructure.Repositories
{
    public class ArtMartialRepository : BaseRepository<ArtMartial>, IArtMartialRepository
    {
        public ArtMartialRepository(DojoContext dojoContext) : base(dojoContext)
        {
        }
    }
}
