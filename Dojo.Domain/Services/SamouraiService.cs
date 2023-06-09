﻿using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Dojo.Domain.Services
{
    public class SamouraiService : BaseService<Samourai>
    {
        public SamouraiService(ISamouraiRepository repository) : base(repository)
        {
        }
    }
}
