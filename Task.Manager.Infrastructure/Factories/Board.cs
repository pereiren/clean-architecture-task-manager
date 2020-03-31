using System;
using Task.Manager.Domain.Boards.ValueObjects;

namespace Task.Manager.Infrastructure.Factories
{
    public class Board : Domain.Boards.Board
    {
        public Board()
        {

        }

        public Board(Name name)
        {
            Id = new BoardId(Guid.NewGuid());
            Name = name;
        }
    }
}
