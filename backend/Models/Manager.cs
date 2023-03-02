using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Manager
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}