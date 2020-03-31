using Task.Manager.Domain.Boards.ValueObjects;
using Task.Manager.Domain.Columns.ValueObjects;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Boards
{
    public class Board : IAggregateRoot
    {
        public BoardId Id { get; set; }

        public Name Name { get; set; }

        public ColumnCollection Columns { get; set; }

        public TaskCollection Tasks { get; set; }

        public Board()
        {
            Tasks = new TaskCollection();
            Columns = new ColumnCollection();
        }

        public void AddTask(TaskId taskId)
        {
            Tasks.Add(taskId);
        }

        public void AddColumn(ColumnId columnId)
        {
            Columns.Add(columnId);
        }
    }
}
