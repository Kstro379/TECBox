using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Routes.Data;
using Routes.Models;

namespace Routes.Controllers
{
    [Route("api/routes")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly RouteRepository _repository = new RouteRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Route>> GetAllCommands()
        {
            var routeItems = _repository.GetAppCommands();

            return Ok(routeItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Route> GetCommandById(int id)
        {
            var routeItem = _repository.GetCommandById(id);

            return Ok(routeItem);
        }
    }
}