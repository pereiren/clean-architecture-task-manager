using System;

namespace Task.Manager.Domain.Columns.ValueObjects
{
    public struct ColumnId
    {
        private readonly Guid _columnId;

        public ColumnId(Guid columnId)
        {
            if (columnId.Equals(Guid.Empty))
                throw new ArgumentNullException($"Column Id does not have any value");

            _columnId = columnId;
        }
    }
}
