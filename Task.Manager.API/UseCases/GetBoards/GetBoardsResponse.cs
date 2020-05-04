using System;
using Task.Manager.Domain.Boards.ValueObjects;

namespace Task.Manager.API.UseCases.GetBoards
{
    public class GetBoardsResponse
    {
        public GetBoardsResponse(BoardId boardId, Name  name)
        {
            Id = boardId.ToGuid();
            Name = name.ToString();
        }

        public Guid Id { get;  }
        public string Name { get; }
    }
}
