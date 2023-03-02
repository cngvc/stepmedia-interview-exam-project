namespace EmployeeManagement.Models
{
    public class StaffManager
    {
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
    }
}