using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Products.Data;
using Products.Models;

namespace Products.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class PodructController : ControllerBase
    {
        private readonly ProductRepository _repository = new ProductRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Product>> GetAllCommands()
        {
            var productItems = _repository.GetAppCommands();

            return Ok(productItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Product> GetCommandById(int id)
        {
            var productItem = _repository.GetCommandById(id);

            return Ok(productItem);
        }
    }
}