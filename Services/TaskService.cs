using ServiceContract;
using ServiceContract.DTO;
using ServiceContract.Enums;

namespace Services
{
    public class TaskService : ITaskService
    {
        public TaskResponse CreateTask(TaskRequest request)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTaks(Guid TaskID)
        {
            throw new NotImplementedException();
        }

        public List<TaskResponse> GellAllTaks()
        {
            throw new NotImplementedException();
        }

        public TaskResponse GetFilteredTask(string searchBy, string? searchString)
        {
            throw new NotImplementedException();
        }

        public TaskResponse GetSortedTask(List<TaskResponse> tasks, string sortBy, enOrderOptions orderBy)
        {
            throw new NotImplementedException();
        }

        public TaskResponse GetTaskByID(Guid TaskID)
        {
            throw new NotImplementedException();
        }
    }
}
