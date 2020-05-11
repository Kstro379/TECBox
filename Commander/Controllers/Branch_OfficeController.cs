using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Branch_Offices.Data;
using Branch_Offices.Models;

namespace Branch_Offices.Controllers
{
    [Route("api/branch_offices")]
    [ApiController]
    public class Branch_OfficeController : ControllerBase
    {
        private readonly Branch_OfficeRepository _repository = new Branch_OfficeRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Branch_Office>> GetAllCommands()
        {
            var Branch_OfficeItems = _repository.GetAppCommands();

            return Ok(Branch_OfficeItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Branch_Office> GetCommandById(int id)
        {
            var Branch_OfficeItems = _repository.GetCommandById(id);

            return Ok(Branch_OfficeItems);
        }
    }
}