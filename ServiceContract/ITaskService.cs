
using ServiceContract.DTO;
using ServiceContract.Enums;

namespace ServiceContract
{
    public interface ITaskService
    {
        TaskResponse CreateTask(TaskRequest request);
        // TaskResponse CreateUpdate(TaskUpdateRequest request);
        TaskResponse GetTaskByID(Guid TaskID);
        TaskResponse GetFilteredTask(string searchBy, string? searchString);
        TaskResponse GetSortedTask(List<TaskResponse> tasks, string sortBy, enOrderOptions orderBy);
        List<TaskResponse> GellAllTaks();
        bool DeleteTaks(Guid TaskID);
     }
}
