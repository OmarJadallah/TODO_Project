
using Entities;
using ServiceContract.Enums;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ServiceContract.DTO
{
    public class TaskRequest
    {
        [Required(ErrorMessage = $"{nameof(TaskName)} can not be blank !")]
        public string TaskName { get; set; } = string.Empty;

        public string? TaskDescription { get; set; }

        [Required(ErrorMessage = $"{nameof(TaskCreateDate)} can not be blank !")]
        public DateTime TaskCreateDate { get; set; } = DateTime.Now;
        public DateTime? TaskDueDate { get; set; }

        [Required(ErrorMessage = $"{nameof(TaskStatus)} can not be blank !")]
        public enStatus TaskStatus { get; set; }

        [Required(ErrorMessage = $"{nameof(TaskPriority)} can not be blank !")]
        public enPriority TaskPriority { get; set; }

        public Guid TaskTagID { get; set;} = Guid.Empty;




        public clsTask ToTask()
        {
            return new clsTask()
            {
                TaskName = this.TaskName,
                TaskDescription = this.TaskDescription,
                TaskCreateDate = this.TaskCreateDate,
                TaskDueDate = this.TaskDueDate,
                TaskStatus = this.TaskStatus.ToString(),
                TaskPriority = this.TaskPriority.ToString(),
                TaskTagID = this.TaskTagID
            };
        }



    }
}
