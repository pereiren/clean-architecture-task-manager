using Task.Manager.Domain.Boards;
using Task.Manager.Domain.Boards.ValueObjects;
using Task.Manager.Domain.Columns;
using Task.Manager.Domain.Columns.ValueObjects;
using Task.Manager.Domain.Tasks;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Infrastructure.Factories
{
    public class EntityFactory : IBoardFactory, IColumnFactory, ITaskFactory
    {
        public Domain.Columns.Column AddColumn(BoardId boardId, Title title, TaskStatus taskStatus)
        {
            return new Column(boardId, title, taskStatus);
        }

        public Domain.Boards.Board CreateBoard(Name name)
        {
            return new Board(name);
        }

        public Domain.Tasks.Task CreateTaskInstance(Summary summary, Description description, AcceptanceCriteria acceptanceCriteria, Points points, Priority priority)
        {
            return new Task(summary, description, acceptanceCriteria, points, priority);
        }
    }
}
