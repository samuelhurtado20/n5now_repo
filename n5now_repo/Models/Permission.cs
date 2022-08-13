using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace n5now_repo.Models
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EmployeeForename { get; set; }

        [Required]
        public string EmployeeSurname { get; set; }

        [Required]
        public int PermissionType { get; set; }

        public DateTime PermissionDate { get; set; }

        [ForeignKey("PermissionType")]
        public PermissionType PermissionTypeRel { get; set; }
    }
}
