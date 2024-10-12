using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class clsTag
    {
        [Key]
        public Guid TagID { get; set; }

        [StringLength(20)]
        public string TagName { get; set; } = string.Empty;
    }
}
