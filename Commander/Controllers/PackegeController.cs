using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Packages.Data;
using Packages.Models;

namespace Packages.Controllers
{
    [Route("api/packeges")]
    [ApiController]
    public class PackegeController : ControllerBase
    {
        private readonly PackageRepository _repository = new PackageRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Package>> GetAllCommands()
        {
            var PackageItems = _repository.GetAppCommands();

            return Ok(PackageItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Package> GetCommandById(int id)
        {
            var PackageItem = _repository.GetCommandById(id);

            return Ok(PackageItem);
        }
    }
}