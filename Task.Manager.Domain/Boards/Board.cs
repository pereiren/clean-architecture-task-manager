using Task.Manager.Domain.Boards.ValueObjects;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Boards
{
    public class Board : IBoard
    {
        public BoardId Id { get; set; }
        public TaskCollection Tasks { get; set; }

        public Board()
        {
            Tasks = new TaskCollection();
        }

        public void Create(TaskId taskId)
        {
            Tasks.Add(taskId);
        }
    }
}
