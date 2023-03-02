using AutoMapper;
using EmployeeManagement.Dtos;
using EmployeeManagement.Models;

namespace EmployeeManagement.Profiles
{
    public class ManagersProfile : Profile
    {
        public ManagersProfile()
        {
            CreateMap<ManagerDto, Manager>();
        }
    }
}