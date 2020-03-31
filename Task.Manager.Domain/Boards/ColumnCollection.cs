using System.Collections.Generic;
using Task.Manager.Domain.Columns.ValueObjects;

namespace Task.Manager.Domain.Boards
{
    public class ColumnCollection
    {
        private readonly IList<ColumnId> _columnIds;

        public ColumnCollection()
        {
            _columnIds = new List<ColumnId>();
        }

        public void Add(ColumnId columnId) => _columnIds.Add(columnId);

        public IList<ColumnId> GetTaskIds() => _columnIds;
    }
}
