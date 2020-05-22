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
    
    public class RouteController : ControllerBase
    {

        /**
         * Obtiene todos las rutas.
         * @return: Lista de rutas.
         */
        [HttpGet]
        public async Task<ActionResult<List<Route>>> Get()
        {
            var listRoutes = await GetListRoutes();

            if (listRoutes.Count < 0)
                return NotFound();

            return listRoutes;
        }

        /**
         * Crea un ruta.
         * @param package: Informacion del ruta.
         * @return: Lista de rutas actualizada.
         */
        [HttpPost]
        public async Task<ActionResult<List<Route>>> Post(Route route)
        {
            var listRoutes = await GetListRoutes();

            listRoutes.Add(new Route()
            {
                Id = listRoutes.Count + 1,
                District = route.District,
                Name = route.Name

            });

            return listRoutes;
        }

        /**
         * Actualiza la informacion del ruta.
         * @param route: Informacion del ruta.
         * @return: Toda la informacion del ruta actualizada.
         */
        [HttpPut]
        public async Task<ActionResult<List<Route>>> Put(Route route)
        {
            var listRoutes = await GetListRoutes();

            var routeUpdate = listRoutes.Find(u => u.Id == route.Id);

            if (routeUpdate == null)
                return NotFound();

            listRoutes.First(u => u.Id == routeUpdate.Id).District = route.District;
            listRoutes.First(u => u.Id == routeUpdate.Id).Name = route.Name;

            return listRoutes;
        }

        /**
         * Elimina un ruta.
         * @param id: ID del ruta.
         * @return: Lista de rutas actualizada.
         */
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Route>>> Delete(int id)
        {
            var listRoutes = await GetListRoutes();

            var routeDelete = listRoutes.Find(u => u.Id == id);

            if (routeDelete == null)
                return NotFound();

            listRoutes.Remove(routeDelete);
            return listRoutes;
        }



        //DATA BASE
        private async Task<List<Route>> GetListRoutes()
        {
            var listRoutes = new List<Route>()
            {
               new Route{Id=0, Name = "Sarapiquí", District = new string[] {"Horquetas", "La virgen", "Puerto Viejo"} },
               new Route{Id=1, Name = "San Ramón Central", District = new string[] {"San Ramón Central", "San Rafael", "Samora" } },
               new Route{Id=2, Name = "Cartago Oriental", District = new string[] {"Cartago Oriental", "Los Angeles", "San Blas" } }
            };

            return listRoutes;
        }

    }

}