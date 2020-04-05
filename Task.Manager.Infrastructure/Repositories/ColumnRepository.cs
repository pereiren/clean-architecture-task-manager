using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Manager.Domain.Columns;

namespace Task.Manager.Infrastructure.Repositories
{
    public class ColumnRepository : IColumnRepository
    {
        public System.Threading.Tasks.Task Add(Column entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Column> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<Column> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Column> FindOne(Column spec)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Remove(Column entity)
        {
            throw new NotImplementedException();
        }
    }
}
