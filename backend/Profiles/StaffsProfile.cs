using AutoMapper;
using EmployeeManagement.Dtos;
using EmployeeManagement.Models;

namespace EmployeeManagement.Profiles;

public class StaffsProfile : Profile
{
    public StaffsProfile()
    {
        CreateMap<StaffDto, Staff>();
    }
}