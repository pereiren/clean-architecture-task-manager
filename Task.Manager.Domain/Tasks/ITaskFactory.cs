using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Tasks
{
    public interface ITaskFactory
    {
        Task CreateTaskInstance(Summary summary, Description description, AcceptanceCriteria acceptanceCriteria, Points points, Priority priority);
    }
}
