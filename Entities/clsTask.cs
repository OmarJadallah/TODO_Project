
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class clsTask
    {
        [Key]
        public Guid TaskID { get; set; }

        [StringLength(20)]
        public string TaskName { get; set; } = string.Empty;

        [StringLength(300)]
        public string? TaskDescription { get; set; } = string.Empty;
        public DateTime TaskCreateDate { get; set; }
        public DateTime? TaskDueDate { get; set; }

        [StringLength(10)]
        public string TaskStatus { get; set; } = "Working";

        [StringLength(15)]
        public string TaskPriority { get; set;} = string.Empty;

        public Guid TaskTagID { get; set; } = Guid.Empty;

    }
}
