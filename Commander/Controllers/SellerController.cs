using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sellers.Data;
using Sellers.Models;

namespace Sellers.Controllers
{
    [Route("api/sellers")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly SellerRepository _repository = new SellerRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Seller>> GetAllCommands()
        {
            var sellerItems = _repository.GetAppCommands();

            return Ok(sellerItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Seller> GetCommandById(int id)
        {
            var sellerItem = _repository.GetCommandById(id);

            return Ok(sellerItem);
        }
    }
}