using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Services;
using EmployeeManagement.Dtos;
using EmployeeManagement.Models;
using AutoMapper;

namespace EmployeeManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ManagersController : ControllerBase
{
    private readonly IStaffService _staffService;
    private readonly IManagerService _managerService;
    private readonly IMapper _mapper;

    public ManagersController(IStaffService staffService, IManagerService managerService, IMapper mapper)
    {
        _staffService = staffService;
        _managerService = managerService;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> CreateEmployees(CreateEmployeesRequestDto model)
    {
        if (model.Teams.Count < 3)
        {
            return BadRequest("Number of managers must be greater than or equal to 3");
        }
        var staffsCount = 0;
        foreach (var team in model.Teams)
        {
            staffsCount += team.Staffs.Count;
        }
        if (staffsCount < 10)
        {
            return BadRequest("Number of staffs must be greater than or equal to 10");
        }

        foreach (var team in model.Teams)
        {
            var manager = _mapper.Map<Manager>(team.Manager);
            var staffs = _mapper.Map<ICollection<Staff>>(team.Staffs);
            manager.Staffs = staffs;
            _managerService.CreateManager(manager);
        }
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Manager>>> GetEmployees()
    {
        var managers = _managerService.GetManagers();
        return Ok(managers);
    }
}