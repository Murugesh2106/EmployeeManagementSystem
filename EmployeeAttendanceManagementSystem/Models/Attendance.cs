using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAttendanceManagementSystem.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        [Required]
        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public virtual Employee Employees { get; set; }


        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan CheckInTime { get; set; }

        [Required]
        public TimeSpan CheckOutTime { get; set; }
    }
}
