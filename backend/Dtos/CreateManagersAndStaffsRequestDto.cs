using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Dtos
{
    public class CreateEmployeesRequestDto
    {
        [Required]
        public ICollection<TeamDto> Teams { get; set; }
    }

    public class TeamDto
    {
        [Required]
        public ManagerDto Manager { get; set; }

        [Required]
        public ICollection<StaffDto> Staffs { get; set; }
    }

    public class StaffDto
    {
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
    }

    public class ManagerDto
    {
        public string FullName { get; set; }
    }
}