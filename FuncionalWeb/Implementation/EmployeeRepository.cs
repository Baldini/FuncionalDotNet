using FuncionalWeb.Models;

namespace FuncionalWeb.Implementation
{
    public interface IEmployeeRepository
    {
        Employee GeyById(string id);
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee GeyById(string id)
            => new Employee();
    }
}
