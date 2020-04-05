using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Task.Manager.Domain;
using Task.Manager.Domain.Tasks;

namespace Task.Manager.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public System.Threading.Tasks.Task Add(Domain.Tasks.Task entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Tasks.Task> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Tasks.Task> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Tasks.Task> FindOne(Domain.Tasks.Task spec)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Remove(Domain.Tasks.Task entity)
        {
            throw new NotImplementedException();
        }
    }
}
