using System.Collections.Generic;
using Clients.Data;
using Clients.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clients.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ClientRepository _repository = new ClientRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Client>> GetAllCommands()
        {
            var clientItems = _repository.GetAppCommands();

            return Ok(clientItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Client> GetCommandById(int id)
        {
            var clientItem = _repository.GetCommandById(id);

            return Ok(clientItem);
        }
    }
}