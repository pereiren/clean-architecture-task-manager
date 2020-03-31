using System;
using System.Collections.Generic;
using Task.Manager.Domain.Columns;

namespace Task.Manager.Infrastructure.Repositories
{
    public class ColumnRepository : IColumnRepository
    {
        public void Add(Column entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Column> Find(Column spec)
        {
            throw new NotImplementedException();
        }

        public Column FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Column FindOne(Column spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(Column entity)
        {
            throw new NotImplementedException();
        }
    }
}
