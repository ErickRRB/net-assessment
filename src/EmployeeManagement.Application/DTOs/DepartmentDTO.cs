namespace EmployeeManagement.Application.DTOs
{
    public class CreateDepartmentDto
    {
        public string Name { get; set; } = string.Empty;
    }

    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}