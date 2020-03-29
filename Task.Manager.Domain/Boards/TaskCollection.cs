using System.Collections.Generic;
using Task.Manager.Domain.Tasks.ValueObjects;

namespace Task.Manager.Domain.Boards
{
    public class TaskCollection
    {
        private readonly IList<TaskId> _taskIds;

        public TaskCollection()
        {
            _taskIds = new List<TaskId>();
        }

        public void Add(TaskId taskId) => _taskIds.Add(taskId);

        public IList<TaskId> GetTaskIds() => _taskIds;
    }
}
