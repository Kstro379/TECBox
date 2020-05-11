using System.Collections.Generic;
using Packages.Models;

namespace Packages.Data
{
    public class PackageRepository
    {
        private List<Package> packages;

        public PackageRepository()
        {
            this.packages = new List<Package>
            {
               new Package{Tracking_Id=0, Status= "Bodega", Description="Es un paquete de sumo cuidado", Initial_Date="10/05/2020", Deliver_Date="12/05/2020", Id_Route=1, Dni_Client=209870456, Dni_Employee=309870567},
               new Package{Tracking_Id=0, Status= "Bodega", Description="Es un paquete de sumo cuidado", Initial_Date="10/05/2020", Deliver_Date="12/05/2020", Id_Route=1, Dni_Client=209870456, Dni_Employee=309870567}
            };
        }

        public IEnumerable<Package> GetAppCommands()
        {
            return packages;
        }

        //Es necesario crear esta función por nombre
        public Package GetCommandById(int id)
        {
             
            return packages[id];
        }
    }
}