using System;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Infrastructure.Factories
{
    public class Task : Domain.Tasks.Task
    {
        public Task()
        {

        }

        public Task(Summary summary, Description description, AcceptanceCriteria acceptanceCriteria, Points points, Priority priority)
        {
            TaskId = new TaskId(Guid.NewGuid());
            Summary = summary;
            Description = description;
            AcceptanceCriteria = acceptanceCriteria;
            Points = points;
            Priority = priority;
        }
    }
}
