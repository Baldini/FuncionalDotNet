using System;
using FuncionalWeb.Helpers;
using FuncionalWeb.Models;

namespace FuncionalWeb.Implementation
{
    public interface IEmployeeRepositoryEither
    {
        Either<Exception, Option<Employee>> GeyById(string id);
    }

    class EmployeeRepositoryEither : IEmployeeRepositoryEither
    {
        public Either<Exception, Option<Employee>> GeyById(string id)
        {
            try
            {
                return new Either<Exception, Option<Employee>>();
            }
            catch (Exception e)
            {
                return e;
            }
        }
    }
}
