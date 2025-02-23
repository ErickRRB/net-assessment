using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Core.Entities;

namespace EmployeeManagement.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        Department Add(Department department);
    }
}