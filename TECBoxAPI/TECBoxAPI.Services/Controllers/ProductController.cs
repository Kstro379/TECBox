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
    
    public class ProductController : ControllerBase
    {

        /**
         * Obtiene todos los productos.
         * @return: Lista de productos.
         */
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            var listProducts = await GetListProducts();

            if (listProducts.Count < 0)
                return NotFound();

            return listProducts;
        }

        /**
         * Crea un Producto.
         * @param product: Informacion del producto.
         * @return: Lista de productos actualizada.
         */
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

        /**
         * Actualiza la informacion del producto.
         * @param product: Informacion del producto.
         * @return: Toda la informacion del producto actualizada.
         */
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

        /**
         * Elimina un producto.
         * @param code: Code del producto.
         * @return: Lista de producto actualizada.
         */
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
               new Product{Code=12345, Name="Celular papito",Description="Moderno telefono", Price=200, Discount=0, Tax=13, Dni_Employee=27840876, Dni_client=207840516, Branch_Office="Cartago" },
               new Product{Code=12346, Name="Equipo Audio",Description="Equipo de audio", Price=250, Discount=5, Tax=13, Dni_Employee=27840876, Dni_client=207840516, Branch_Office="Heredia" },
               new Product{Code=12447, Name="Luces móviles",Description="Tachos LED", Price=100, Discount=20, Tax=13, Dni_Employee=27840876, Dni_client=207840516, Branch_Office="Cartago" },
               new Product{Code=12444, Name="Refri",Description="vdvdfv", Price=200, Discount=3, Tax=13, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Cartago" },
               new Product{Code=12423, Name="Horno",Description="vfdvdfv", Price=400, Discount=40, Tax=6, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Cartago" },
               new Product{Code=11111, Name="olk",Description="vdfvdfv", Price=256, Discount=22, Tax=6, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=9963, Name="Table sansumg",Description="vfdvdfv", Price=98, Discount=12, Tax=6, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=12, Name="Lapto1",Description="vdfvd", Price=567, Discount=98, Tax=6, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=1, Name="labop2",Description="vfdvd", Price=87, Discount=76, Tax=13, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=2, Name="bci",Description="vdfvdf", Price=123, Discount=23, Tax=6, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=87, Name="Pantalla plana",Description="hhkhk", Price=477, Discount=65, Tax=6, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=1243, Name="Aprobar curos S.A",Description="ihuh", Price=877, Discount=78, Tax=6, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=1244, Name="Obajeto mistico",Description="ekkee", Price=987, Discount=2, Tax=13, Dni_Employee=27840876, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=1245, Name="Covid-19",Description="ikkl", Price=267, Discount=34, Tax=6, Dni_Employee=506780345, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=1246, Name="Casa mueñecas",Description="kjehkj", Price=1000, Discount=76, Tax=6, Dni_Employee=27840876, Dni_client=207840516, Branch_Office="Alajuela" },
               new Product{Code=1228, Name="Objeto misterioso 2",Description="Místico", Price=987, Discount=87, Tax=6, Dni_Employee=506780345, Dni_client=307840671, Branch_Office="Alajuela" },
               new Product{Code=1249, Name="Objeto misterioso 3",Description="Místico", Price=98, Discount=34, Tax=6, Dni_Employee=506780345, Dni_client=307840671, Branch_Office="Alajuela" },
               new Product{Code=121, Name="Objeto misterioso 4",Description="Místico", Price=5678, Discount=12, Tax=13, Dni_Employee=506780345, Dni_client=307840671, Branch_Office="Cartago" },
               new Product{Code=123, Name="Objeto misterioso 5",Description="Místico", Price=8765, Discount=34, Tax=6, Dni_Employee=506780345, Dni_client=307840671, Branch_Office="Alajuela" },
               new Product{Code=18, Name="Objeto misterioso 6",Description="Místico", Price=25268, Discount=76, Tax=6, Dni_Employee=506780345, Dni_client=307840671, Branch_Office="Cartago" },
               new Product{Code=19, Name="Objeto misterioso 7",Description="Místico", Price=2233, Discount=33, Tax=6, Dni_Employee=27840876, Dni_client=307840671, Branch_Office="Alajuela" },
               new Product{Code=234, Name="Objeto misterioso 8",Description="Místico", Price=8753, Discount=54, Tax=6, Dni_Employee=27840876, Dni_client=307840671, Branch_Office="Cartago" },
               new Product{Code=987, Name="Objeto misterioso 9",Description="Místico", Price=2672, Discount=34, Tax=13, Dni_Employee=27840876, Dni_client=307840671, Branch_Office="Alajuela" },

            };

            return listProducts;
        }

    }

}