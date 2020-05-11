using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Roles.Data;
using Roles.Models;

namespace Roles.Controllers
{
    [Route("api/roles")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleRepository _repository = new RoleRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Role>> GetAllCommands()
        {
            var roleItems = _repository.GetAppCommands();

            return Ok(roleItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Role> GetCommandById(int id)
        {
            var roleItem = _repository.GetCommandById(id);

            return Ok(roleItem);
        }
    }
}