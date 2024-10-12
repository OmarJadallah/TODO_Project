
using ServiceContract.Enums;
using System.ComponentModel.DataAnnotations;
using Entities;

namespace ServiceContract.DTO
{
    public class TaskResponse
    {
        [Required(ErrorMessage = $"{nameof(TaskID)} can not be blank !")]
        public Guid TaskID { get; set; }

        [Required(ErrorMessage = $"{nameof(TaskName)} can not be blank !")]
        public string TaskName { get; set; } = string.Empty;

        public string? TaskDescription { get; set; }

        [Required(ErrorMessage = $"{nameof(TaskCreateDate)} can not be blank !")]
        public DateTime TaskCreateDate { get; set; }
        public DateTime? TaskDueDate { get; set; }

        [Required(ErrorMessage = $"{nameof(TaskStatus)} can not be blank !")]
        public enStatus TaskStatus { get; set; }

        [Required(ErrorMessage = $"{nameof(TaskPriority)} can not be blank !")]
        public enPriority TaskPriority { get; set; }

        public bool isCompleted { get {  return  TaskStatus == enStatus.Done; } set { } }

        public Guid TaskTagID { get; set; } = Guid.Empty;
        

    }

    public static class TaskExtintion
    {
        public static TaskResponse ToTaskResponse(this clsTask task)
        {
            return new TaskResponse
            {
                TaskID = task.TaskID,
                TaskName = task.TaskName,
                TaskDescription = task.TaskDescription,
                TaskCreateDate = task.TaskCreateDate,
                TaskDueDate = task.TaskDueDate,
                TaskStatus = task.TaskStatus == "Working" ? enStatus.Working : enStatus.Done,
                TaskPriority = task.TaskPriority == "High" ? enPriority.High : task.TaskPriority == "Mid" ? enPriority.Mid : enPriority.Low,
                TaskTagID = task.TaskTagID

            };
        }
    }




}

