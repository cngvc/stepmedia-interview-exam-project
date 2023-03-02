using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IManagerService
    {
        IEnumerable<Manager> GetManagers();

        void CreateManager(Manager manager);
    }
}