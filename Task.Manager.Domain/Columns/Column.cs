using Task.Manager.Domain.Boards.ValueObjects;
using Task.Manager.Domain.Columns.ValueObjects;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Columns
{
    public class Column : IAggregateRoot
    {
        public BoardId BoardId { get; set; }

        public ColumnId ColumnId { get; set; }
        
        public Title Name { get; set; }

        public TaskStatus TaskStatus { get; set; }
    }
}
