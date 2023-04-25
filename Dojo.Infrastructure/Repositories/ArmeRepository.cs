﻿using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Infrastructure.Repositories
{
    public class ArmeRepository : BaseRepository<Arme>, IArmeRepository
    {
        public ArmeRepository(DojoContext dojoContext) : base(dojoContext)
        {
        }
    }
}
