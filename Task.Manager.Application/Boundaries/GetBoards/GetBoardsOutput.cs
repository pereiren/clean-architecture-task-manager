using System.Collections.Generic;
using Task.Manager.Domain.Boards;

namespace Task.Manager.Application.Boundaries.GetBoards
{
    public class GetBoardsOutput : IUseCaseOutputPort
    {
        public IEnumerable<Board> Boards { get; }

        public GetBoardsOutput(IEnumerable<Board> boards)
        {
            Boards = boards;
        }
    }
}
