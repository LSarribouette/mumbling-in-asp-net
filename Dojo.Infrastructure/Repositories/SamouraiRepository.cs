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
    public class SamouraiRepository : BaseRepository<Samourai>, ISamouraiRepository
    {
        public SamouraiRepository(DojoContext dojoContext) : base(dojoContext)
        {
        }
    }
}
