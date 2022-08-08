﻿using Projeto06.Data.Contexts;
using Projeto06.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente, Guid>
    {
        public ClienteRepository(DataContext dataContext)
            : base(dataContext)
        {

        }
    }
}
