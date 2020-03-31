using System;
using System.Collections.Generic;
using System.Text;
using Task.Manager.Domain.Columns.ValueObjects;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Columns
{
    public interface IColumnFactory
    {
        Column AddColumn(Title title, TaskStatus taskStatus);
    }
}
