﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Domain.Ports.Repositories
{
    public interface IBaseRepository<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        List<TEntity> GetAll();
        TEntity GetById(TKey id);
    }
}
