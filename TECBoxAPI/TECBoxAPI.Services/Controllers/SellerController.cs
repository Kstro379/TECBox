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
    
    public class SellerController : ControllerBase
    {

        /**
         * Obtiene todos los Vendedores.
         * @return: Lista de Vendedores.
         */
        [HttpGet]
        public async Task<ActionResult<List<Seller>>> Get()
        {
            var listSellers = await GetListSellers();

            if (listSellers.Count < 0)
                return NotFound();

            return listSellers;
        }

        /**
         * Crea un Vendedor.
         * @param package: Informacion del Vendedor.
         * @return: Lista de Vendedores actualizada.
         */
        [HttpPost]
        public async Task<ActionResult<List<Seller>>> Post(Seller seller)
        {
            var listSellers = await GetListSellers();

            listSellers.Add(new Seller()
            {
                Dni = seller.Dni,
                Name = seller.Name,
                Last_Name = seller.Last_Name
                
            });

            return listSellers;
        }

        /**
         * Actualiza la informacion del Vendedor.
         * @param seller: Informacion del Vendedor.
         * @return: Toda la informacion del Vendedor actualizada.
         */
        [HttpPut]
        public async Task<ActionResult<List<Seller>>> Put(Seller seller)
        {
            var listSellers = await GetListSellers();

            var sellerUpdate = listSellers.Find(u => u.Dni == seller.Dni);

            if (sellerUpdate == null)
                return NotFound();

            listSellers.First(u => u.Dni == sellerUpdate.Dni).Name = seller.Name;
            listSellers.First(u => u.Dni == sellerUpdate.Dni).Last_Name = seller.Last_Name;
            
            return listSellers;
        }

        /**
         * Elimina un Vendedor.
         * @param dni: DNI del Vendedor.
         * @return: Lista de Vendedores actualizada.
         */
        [HttpDelete("{dni}")]
        public async Task<ActionResult<List<Seller>>> Delete(int dni)
        {
            var listSellers = await GetListSellers();

            var sellerDelete = listSellers.Find(u => u.Dni == dni);

            if (sellerDelete == null)
                return NotFound();

            listSellers.Remove(sellerDelete);
            return listSellers;
        }



        //DATA BASE
        private async Task<List<Seller>> GetListSellers()
        {
            var listSellers = new List<Seller>()
            {
               new Seller{Dni=0, Name="María", Last_Name="Castro "},
               new Seller{Dni=1, Name="Jose", Last_Name="Oses"},
               new Seller{Dni=2, Name="Ruben", Last_Name="Campos"}
            };

            return listSellers;
        }

    }

}