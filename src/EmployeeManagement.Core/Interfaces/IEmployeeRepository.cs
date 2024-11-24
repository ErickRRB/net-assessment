using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Core.Entities;

namespace EmployeeManagement.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee? GetById(int id);
        List<Employee> GetAll();
        Employee Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}