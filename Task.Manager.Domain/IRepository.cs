using System;
using System.Collections.Generic;

namespace Task.Manager.Domain
{
    public interface IRepository<TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity FindById(Guid id);
        TEntity FindOne(TEntity spec);
        IEnumerable<TEntity> Find(TEntity spec);
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
