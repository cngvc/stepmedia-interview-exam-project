using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Services
{
    public class ManagerService : IManagerService
    {
        private readonly AppDbContext _context;

        public ManagerService(AppDbContext context)
        {
            _context = context;
        }

        public void CreateManager(Manager manager)
        {
            if (manager == null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            _context.Managers.Add(manager);
            _context.SaveChanges();
        }

        public IEnumerable<Manager> GetManagers()
        {
            var managers = _context.Managers.AsQueryable().Include(e => e.Staffs).OrderBy(e => e.FullName).ToList();
            foreach (var manager in managers)
            {
                manager.Staffs = manager.Staffs.OrderBy(e => e.DOB.Date).ToList();
            }
            return managers;
        }
    }
}