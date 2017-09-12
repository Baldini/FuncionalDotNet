using FuncionalWeb.Helpers;
using FuncionalWeb.Models;

namespace FuncionalWeb.Implementation
{
    public interface IEmployeeRepositoryOption
    {
        Option<Employee> GeyById(string id);
    }

    public class EmployeeRepositoryOption : IEmployeeRepositoryOption
    {
        public Option<Employee> GeyById(string id)
            => new Option<Employee>();
    }
}
