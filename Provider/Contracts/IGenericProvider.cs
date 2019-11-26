﻿using System.Collections.Generic;

namespace Core.Contracts
{
    public interface IGenericProvider<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}