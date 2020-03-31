using System;
using Task.Manager.Domain.Boards.ValueObjects;
using Task.Manager.Domain.Columns.ValueObjects;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Infrastructure.Factories
{
    public class Column : Domain.Columns.Column
    {
        public Column()
        {

        }

        public Column(BoardId boardId, Title title, TaskStatus taskStatus)
        {
            BoardId = boardId;
            ColumnId = new ColumnId(Guid.NewGuid());
            Name = title;
            TaskStatus = taskStatus;
        }
    }
}
