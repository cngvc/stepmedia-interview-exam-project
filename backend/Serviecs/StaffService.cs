using EmployeeManagement.Data;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class StaffService : IStaffService
    {
        private readonly AppDbContext _context;

        public StaffService(AppDbContext context)
        {
            _context = context;
        }

        public void CreateStaff(Staff staff)
        {
            if (staff == null)
            {
                throw new ArgumentNullException(nameof(staff));
            }
            _context.Staffs.Add(staff);
            _context.SaveChanges();
        }
    }
}