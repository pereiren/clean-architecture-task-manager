using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Task.Manager.Domain.Columns.ValueObjects;

namespace Task.Manager.Domain.Columns
{
    public class Column
    {
        public ColumnId ColumnId { get; set; }
        
        public Title Name { get; set; }

        public TaskStatus TaskStatus { get; set; }
    }
}
