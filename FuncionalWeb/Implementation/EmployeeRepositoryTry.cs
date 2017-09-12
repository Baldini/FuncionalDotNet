using System;
using FuncionalWeb.Helpers;
using FuncionalWeb.Models;

namespace FuncionalWeb.Implementation
{
    public interface IEmployeeRepositoryTry
    {
        Try<Exception, Option<Employee>> GeyById(string id);
    }

    public class EmployeeRepositoryTry : IEmployeeRepositoryTry
    {
        public Try<Exception, Option<Employee>> GeyById(string id)
            => Try.Run(() => Find(id));


        public Option<Employee> Find(string id)
        {
            return new Option<Employee>();
        }
    }

}
