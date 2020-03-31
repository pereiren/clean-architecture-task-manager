using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Manager.Domain.Tasks.ValueObjects
{
    public enum  TaskStatus
    {
        Todo = 0,
        InProgress = 1,
        Done = 2,
        Resolved = 3
    }
}
