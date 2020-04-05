using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task.Manager.Domain
{
    public interface IRepository<TEntity>
        where TEntity : IAggregateRoot
    {
        Task<TEntity> FindById(Guid id);
        Task<TEntity> FindOne(TEntity spec);
        IEnumerable<TEntity> FindAll();
        System.Threading.Tasks.Task Add(TEntity entity);
        System.Threading.Tasks.Task Remove(TEntity entity);
    }
}
