using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Manager.Domain.Boards;
using Task.Manager.Domain.Boards.ValueObjects;

namespace Task.Manager.Infrastructure.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        public System.Threading.Tasks.Task Add(Board entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Board> FindAll()
        {
            var board = new Board { Columns = new ColumnCollection(), Id = new BoardId(Guid.NewGuid()), Name = new Name("test"), Tasks = new TaskCollection() };
            var board2 = new Board { Columns = new ColumnCollection(), Id = new BoardId(Guid.NewGuid()), Name = new Name("test2"), Tasks = new TaskCollection() };
            List<Board> boards = new List<Board>();
            boards.Add(board);
            boards.Add(board2);

            return boards;
        }

        public Task<Board> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Board> FindOne(Board spec)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Remove(Board entity)
        {
            throw new NotImplementedException();
        }
    }
}
