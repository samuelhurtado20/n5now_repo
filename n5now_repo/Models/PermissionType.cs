using System.ComponentModel.DataAnnotations;

namespace n5now_repo.Models
{
    public class PermissionType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
    }
}