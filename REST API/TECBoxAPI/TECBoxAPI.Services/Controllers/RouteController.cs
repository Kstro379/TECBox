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
    public class RouteController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Route>>> Get()
        {
            var listRoutes = await GetListRoutes();

            if (listRoutes.Count < 0)
                return NotFound();

            return listRoutes;
        }

        [HttpPost]
        public async Task<ActionResult<List<Route>>> Post(Route route)
        {
            var listRoutes = await GetListRoutes();

            listRoutes.Add(new Route()
            {
                Id = listRoutes.Count + 1,
                District = route.District

            });

            return listRoutes;
        }

        [HttpPut]
        public async Task<ActionResult<List<Route>>> Put(Route route)
        {
            var listRoutes = await GetListRoutes();

            var routeUpdate = listRoutes.Find(u => u.Id == route.Id);

            if (routeUpdate == null)
                return NotFound();

            listRoutes.First(u => u.Id == routeUpdate.Id).District = route.District;
          
            return listRoutes;
        }

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
               new Route{Id=0, District="La Virgen"},
               new Route{Id=1, District="San Ramón"},
               new Route{Id=2, District="Cartago"}
            };

            return listRoutes;
        }

    }

}