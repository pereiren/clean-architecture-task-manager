using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Tasks
{
    public class Task : IAggregateRoot
    {
        public TaskId TaskId { get; set; }
        
        public Summary Summary { get; set; }
        
        public Description Description { get; set; }

        public AcceptanceCriteria AcceptanceCriteria { get; set; }

        public Points Points { get; set; }

        public Priority Priority { get; set; }
    }
}
