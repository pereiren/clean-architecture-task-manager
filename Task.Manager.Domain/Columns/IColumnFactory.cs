using Task.Manager.Domain.Boards.ValueObjects;
using Task.Manager.Domain.Columns.ValueObjects;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Columns
{
    public interface IColumnFactory
    {
        Column AddColumn(BoardId boardId, Title title, TaskStatus taskStatus);
    }
}
