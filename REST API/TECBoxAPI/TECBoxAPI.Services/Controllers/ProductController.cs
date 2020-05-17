using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TECBoxAPI.Services.Models;

namespace TECBoxAPI.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            var listProducts = await GetListProducts();

            if (listProducts.Count < 0)
                return NotFound();

            return listProducts;
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> Post(Product product)
        {
            var listProducts = await GetListProducts();

            listProducts.Add(new Product()
            {
                Code = product.Code,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Discount = product.Discount,
                Tax = product.Tax,
                Dni_Employee = product.Dni_Employee,
                Dni_client = product.Dni_client,
                Branch_Office = product.Branch_Office

            });

            return listProducts;
        }

        [HttpPut]
        public async Task<ActionResult<List<Product>>> Put(Product product)
        {
            var listProducts = await GetListProducts();

            var productUpdate = listProducts.Find(u => u.Code == product.Code);

            if (productUpdate == null)
                return NotFound();

            listProducts.First(u => u.Code == productUpdate.Code).Name = product.Name;
            listProducts.First(u => u.Code == productUpdate.Code).Description = product.Description;
            listProducts.First(u => u.Code == productUpdate.Code).Price = product.Price;
            listProducts.First(u => u.Code == productUpdate.Code).Discount= product.Discount;
            listProducts.First(u => u.Code == productUpdate.Code).Tax = product.Tax;
            listProducts.First(u => u.Code == productUpdate.Code).Dni_Employee = product.Dni_Employee;
            listProducts.First(u => u.Code == productUpdate.Code).Dni_client = product.Dni_client;
            listProducts.First(u => u.Code == productUpdate.Code).Branch_Office = product.Branch_Office;
            

            return listProducts;
        }

        [HttpDelete("{code}")]
        public async Task<ActionResult<List<Product>>> Delete(int code)
        {
            var listProducts = await GetListProducts();

            var productDelete = listProducts.Find(u => u.Code == code);

            if (productDelete == null)
                return NotFound();

            listProducts.Remove(productDelete);
            return listProducts;
        }



        //DATA BASE
        private async Task<List<Product>> GetListProducts()
        {
            var listProducts = new List<Product>()
            {
               new Product{Code=12345, Name="Celular papito",Description="Moderno telefono", Price=200, Discount=0, Tax=13, Dni_Employee=0, Dni_client=0, Branch_Office="Cartago" },
               new Product{Code=12346, Name="Equipo Audio",Description="Equipo de audio", Price=250, Discount=5, Tax=0, Dni_Employee=1, Dni_client=1, Branch_Office="Heredia" },
               new Product{Code=12447, Name="Luces móviles",Description="Tachos LED", Price=400, Discount=20, Tax=6, Dni_Employee=2, Dni_client=2, Branch_Office="Alajuela" }
            };

            return listProducts;
        }

    }

}