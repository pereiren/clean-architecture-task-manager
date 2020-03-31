using System;
using System.Collections.Generic;
using Task.Manager.Domain.Boards;

namespace Task.Manager.Infrastructure.Repositories
{
    public class BoardRepository : IBoardRepository
    {


        public void Add(Board entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Board> Find(Board spec)
        {
            throw new NotImplementedException();
        }

        public Board FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Board FindOne(Board spec)
        {
            throw new NotImplementedException();
        }

        public void Remove(Board entity)
        {
            throw new NotImplementedException();
        }
    }
}
