using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAttendanceManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


    }
}
