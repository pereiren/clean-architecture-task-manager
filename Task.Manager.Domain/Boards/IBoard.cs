using Task.Manager.Domain.Boards.ValueObjects;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Boards
{
    public interface IBoard
    {
        BoardId Id { get; }

        TaskCollection Tasks { get; }

        void Create(TaskId taskId);
    }
}
