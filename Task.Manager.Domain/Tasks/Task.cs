using System;
using System.Collections.Generic;
using System.Text;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Tasks
{
    public class Task
    {
        public TaskId TaskId { get; set; }
        public Summary Summary { get; set; }
        public Description Description { get; set; }

        public AcceptanceCriteria AcceptanceCriteria { get; set; }

        public Points Points { get; set; }

        public Priority Priority { get; set; }
    }
}
