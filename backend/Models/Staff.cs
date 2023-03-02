using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EmployeeManagement.Models
{
    public class Staff
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [JsonIgnore]
        public ICollection<Manager> Managers { get; set; }
    }
}