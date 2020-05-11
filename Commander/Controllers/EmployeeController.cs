using System.Collections.Generic;
using Employees.Data;
using Employees.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _repository = new EmployeeRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Employee>> GetAllCommands()
        {
            var employeeItems = _repository.GetAppCommands();

            return Ok(employeeItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Employee> GetCommandById(int id)
        {
            var employeeItem = _repository.GetCommandById(id);

            return Ok(employeeItem);
        }
    }
}