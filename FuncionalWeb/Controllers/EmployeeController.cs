using Microsoft.AspNetCore.Mvc;
using FuncionalWeb.Implementation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuncionalWeb.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {

        public IEmployeeRepository Repo1;

        [HttpGet]
        public IActionResult Get1(string id)
        {
            var result = Repo1.GeyById(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        #region .: Option :.
        public IEmployeeRepositoryOption Repo2;
        [HttpGet]
        public IActionResult Get2(string id)
        {
            return Repo2.GeyById(id)
                 .Match<IActionResult>(
                     some: employee => Ok(employee),
                     none: () => NotFound());
        }

        [HttpGet]
        public IActionResult Get3(string id) => Repo2.GeyById(id)
            .Match<IActionResult>(
                Ok,
                NotFound
            );
        #endregion

        #region .: Either :.
        public IEmployeeRepositoryEither Repo3;

        [HttpGet]
        public IActionResult Get4(string id) => Repo3.GeyById(id).Match<IActionResult>(
            left: e => BadRequest(e),
            right: s => s.Match<IActionResult>(
                some: employee => Ok(employee),
                none: () => NotFound()
                ));

        [HttpGet]
        public IActionResult Get5(string id) => Repo3.GeyById(id).Match<IActionResult>(
            BadRequest,
            s => s.Match<IActionResult>(
                Ok,
                NotFound
            ));

        #endregion

        #region .: Try :.
        public IEmployeeRepositoryTry Repo4;

        public IActionResult Get6(string id) => Repo4.GeyById(id).Match<IActionResult>(
            failure: e => BadRequest(e),
            success: s => s.Match<IActionResult>(
                some: employee => Ok(employee),
                none: () => NotFound()
            ));

        public IActionResult Get7(string id) => Repo4.GeyById(id).Match<IActionResult>(
            BadRequest,
            s => s.Match<IActionResult>(
                Ok,
                NotFound
            ));
        #endregion

    }
}
