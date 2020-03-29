using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Manager.Domain.Boards
{
    public interface IBoardFactory
    {
        IBoard NewBoardInstance()
    }
}
