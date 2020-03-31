using Task.Manager.Domain.Boards.ValueObjects;

namespace Task.Manager.Domain.Boards
{
    public interface IBoardFactory
    {
        Board CreateBoard(Name name);
    }
}
