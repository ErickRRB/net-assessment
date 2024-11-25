using AutoMapper;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Application.DTOs;

namespace EmployeeManagement.Application.Mappings
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Profile for AutoMapper
        /// 
        /// - Define how to convert objects between different types (DTOs -> Entities)
        /// - Allows automatic data transformations
        /// - Avoids writing repetitive manual mapping code
        /// 
        /// 1. CreateMap<Origen, Destino>() defines a conversion rule
        /// 2. The mapper automatically maps properties with the same name
        /// 3. ForMember() allows customizing the mapping of specific properties
        /// 
        /// Example:
        /// var employeeDto = _mapper.Map<EmployeeDto>(employee);
        /// var employee = _mapper.Map<Employee>(createEmployeeDto);
        /// </summary>
        public MappingProfile()
        {
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.DepartmentName,  // For the DepartmentName property of the DTO
                    opt => opt.MapFrom(src =>            // Takes the value from
                        src.Department != null ?          // If Department is not null
                        src.Department.Name :             // Use the department name
                        string.Empty));                   // If not, use an empty string

            // Used when: GET /api/employees to display employees
            // Example:
            // From: Employee { Department = { Name = "IT" } }
            // To: { "departmentName": "IT" }

            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<Department, DepartmentDto>();
        }
    }
}