using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Interfaces;
using EmployeeManagement.Application.DTOs;
using AutoMapper;

namespace EmployeeManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IMapper _mapper;

    public DepartmentsController(IDepartmentRepository departmentRepository, IMapper mapper)
    {
        _departmentRepository = departmentRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<DepartmentDto>> GetAll()
    {
        var departments = _departmentRepository.GetAll();
        return Ok(_mapper.Map<IEnumerable<DepartmentDto>>(departments));
    }

    [HttpPost]
    public ActionResult<DepartmentDto> Create(CreateDepartmentDto createDepartmentDto)
    {
        var department = _mapper.Map<Department>(createDepartmentDto);
        var createdDepartment = _departmentRepository.Add(department);
        return Ok(_mapper.Map<DepartmentDto>(createdDepartment));
    }
}