using System;

namespace Task.Manager.Domain.Boards.ValueObjects
{
    public struct BoardId
    {
        private readonly Guid _boardId;
        
        public BoardId(Guid boardId)
        {
            if (boardId.Equals(Guid.Empty))
                throw new ArgumentNullException($"Board Id does not have any value");

            _boardId = boardId;
        }
    }
}
