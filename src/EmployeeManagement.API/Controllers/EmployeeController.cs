using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Interfaces;
using EmployeeManagement.Application.DTOs;
using AutoMapper;

namespace EmployeeManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeesController(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<EmployeeDto>> GetAll()
    {
        var employees = _employeeRepository.GetAll();
        return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employees));
    }

    [HttpGet("{id}")]
    public ActionResult<EmployeeDto> GetById(int id)
    {
        var employee = _employeeRepository.GetById(id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<EmployeeDto>(employee));
    }

    [HttpPost]
    public ActionResult<EmployeeDto> Create(CreateEmployeeDto createEmployeeDto)
    {
        var employee = _mapper.Map<Employee>(createEmployeeDto);
        var createdEmployee = _employeeRepository.Add(employee);
        return CreatedAtAction(
            nameof(GetById), 
            new { id = createdEmployee.Id }, 
            _mapper.Map<EmployeeDto>(createdEmployee));
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, CreateEmployeeDto updateEmployeeDto)
    {
        var existingEmployee = _employeeRepository.GetById(id);
        if (existingEmployee == null)
        {
            return NotFound();
        }

        _mapper.Map(updateEmployeeDto, existingEmployee);
        _employeeRepository.Update(existingEmployee);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var employee = _employeeRepository.GetById(id);
        if (employee == null)
        {
            return NotFound();
        }

        _employeeRepository.Delete(id);
        return NoContent();
    }
}