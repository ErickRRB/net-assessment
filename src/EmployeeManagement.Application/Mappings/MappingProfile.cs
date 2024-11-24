using AutoMapper;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Application.DTOs;

namespace EmployeeManagement.Application.Mappings
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Perfil de AutoMapper que define las reglas de mapeo entre DTOs y Entidades.
        /// 
        /// - Define como convertir objetos entre diferentes tipos (DTOs -> Entidades)
        /// - Permite transformaciones automaticas de datos
        /// - Evita escribir codigo repetitivo de mapeo manual
        /// 
        /// 1. CreateMap<Origen, Destino>() define una regla de conversion
        /// 2. El mapper automaticamente mapea propiedades con el mismo nombre
        /// 3. ForMember() permite personalizar el mapeo de propiedades especificas
        /// 
        /// Ejemplo:
        /// var employeeDto = _mapper.Map<EmployeeDto>(employee);
        /// var employee = _mapper.Map<Employee>(createEmployeeDto);
        /// </summary>
        public MappingProfile()
        {
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.DepartmentName,  // Para la propiedad DepartmentName del DTO
                    opt => opt.MapFrom(src =>            // Toma el valor de
                        src.Department != null ?          // Si Department no es null
                        src.Department.Name :             // Usa el nombre del departamento
                        string.Empty));                   // Si no, usa string vacio

            // Se usa cuando: GET /api/employees para mostrar empleados
            // Ejemplo:
            // De: Employee { Department = { Name = "IT" } }
            // A: { "departmentName": "IT" }

            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<Department, DepartmentDto>();
        }
    }
}