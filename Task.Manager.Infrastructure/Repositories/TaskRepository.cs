using System;
using System.Collections.Generic;
using System.Text;
using Task.Manager.Domain.Tasks;

namespace Task.Manager.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void Add(Domain.Tasks.Task entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Tasks.Task> Find(Domain.Tasks.Task spec)
        {
            throw new NotImplementedException();
        }

        public Domain.Tasks.Task FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Domain.Tasks.Task FindOne(Domain.Tasks.Task spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Tasks.Task entity)
        {
            throw new NotImplementedException();
        }
    }
}
