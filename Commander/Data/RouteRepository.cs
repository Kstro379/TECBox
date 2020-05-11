using System.Collections.Generic;
using Routes.Models;

namespace Routes.Data
{
    public class RouteRepository
    {
        private List<Route> routes;

        public RouteRepository()
        {
            this.routes = new List<Route>
            {
               new Route{Id=0, District="La Virgen"},
               new Route{Id=1, District="San Ramón"},
               new Route{Id=2, District="Cartago"}
            };
        }

        public IEnumerable<Route> GetAppCommands()
        {
            return routes;
        }

        //Es necesario crear esta función por nombre
        public Route GetCommandById(int id)
        {
             
            return routes[id];
        }
    }
}