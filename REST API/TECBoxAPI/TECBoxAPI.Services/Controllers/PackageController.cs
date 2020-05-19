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
    
    public class PackageController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Package>>> Get()
        {
            var listPackages = await GetListPackages();

            if (listPackages.Count < 0)
                return NotFound();

            return listPackages;
        }

        [HttpPost]
        public async Task<ActionResult<List<Package>>> Post(Package package)
        {
            var listPackages = await GetListPackages();

            listPackages.Add(new Package()
            {

                Tracking_Id = listPackages.Count + 1,
                Status = package.Status,
                Description = package.Description,
                Initial_Date = package.Initial_Date,
                Deliver_Date = package.Deliver_Date,
                Id_Route = package.Id_Route,
                Dni_Client = package.Dni_Client,
                Dni_Employee = package.Dni_Employee

            });

            return listPackages;
        }

        [HttpPut]
        public async Task<ActionResult<List<Package>>> Put(Package package)
        {
            var listPackages = await GetListPackages();

            var packagesUpdate = listPackages.Find(u => u.Tracking_Id == package.Tracking_Id);

            if (packagesUpdate == null)
                return NotFound();

            listPackages.First(u => u.Tracking_Id == packagesUpdate.Tracking_Id).Status = package.Status;
            listPackages.First(u => u.Tracking_Id == packagesUpdate.Tracking_Id).Description = package.Description;
            listPackages.First(u => u.Tracking_Id == packagesUpdate.Tracking_Id).Initial_Date = package.Initial_Date;
            listPackages.First(u => u.Tracking_Id == packagesUpdate.Tracking_Id).Deliver_Date = package.Deliver_Date;
            listPackages.First(u => u.Tracking_Id == packagesUpdate.Tracking_Id).Id_Route = package.Id_Route;
            listPackages.First(u => u.Tracking_Id == packagesUpdate.Tracking_Id).Dni_Client = package.Dni_Client;
            listPackages.First(u => u.Tracking_Id == packagesUpdate.Tracking_Id).Dni_Employee = package.Dni_Employee;
            

            return listPackages;
        }

        [HttpDelete("{tracking_Id}")]
        public async Task<ActionResult<List<Package>>> Delete(int tracking_Id)
        {
            var listPackages = await GetListPackages();

            var packagesDelete = listPackages.Find(u => u.Tracking_Id == tracking_Id);

            if (packagesDelete == null)
                return NotFound();

            listPackages.Remove(packagesDelete);
            return listPackages;
        }



        //DATA BASE
        private async Task<List<Package>> GetListPackages()
        {
            var listPakages = new List<Package>()
            {
               new Package{Tracking_Id=0, Status= "Entregado al cliente", Description="Es un paquete de sumo cuidado", Initial_Date="10/02/2020", Deliver_Date="12/03/2020", Id_Route=1, Dni_Client=207840516, Dni_Employee=27840876,},
               new Package{Tracking_Id=1, Status= "Listo para Entrega", Description="Es un paquete de sumo cuidado", Initial_Date="10/02/2020", Deliver_Date="12/03/2020", Id_Route=2, Dni_Client=307840671, Dni_Employee=27840876,},
               new Package{Tracking_Id=2, Status= "Entregado al cliente", Description="Es un paquete de sumo cuidado", Initial_Date="10/03/2020", Deliver_Date="12/04/2020", Id_Route=1, Dni_Client=207840516, Dni_Employee=27840876,},
               new Package{Tracking_Id=3, Status= "Listo para Entrega", Description="Es un paquete de sumo cuidado", Initial_Date="10/04/2020", Deliver_Date="12/05/2020", Id_Route=2, Dni_Client=307840671, Dni_Employee=27840876,},
               new Package{Tracking_Id=4, Status= "Entregado al cliente", Description="Es un paquete de sumo cuidado", Initial_Date="10/04/2020", Deliver_Date="12/05/2020", Id_Route=1, Dni_Client=207840516, Dni_Employee=27840876,},
               new Package{Tracking_Id=5, Status= "Listo para Entrega", Description="Es un paquete de sumo cuidado", Initial_Date="10/02/2020", Deliver_Date="12/03/2020", Id_Route=2, Dni_Client=307840671, Dni_Employee=506780345},
               new Package{Tracking_Id=6, Status= "Entregado al cliente", Description="Es un paquete de sumo cuidado", Initial_Date="10/01/2020", Deliver_Date="12/02/2020", Id_Route=1, Dni_Client=207840516, Dni_Employee=506780345},
               new Package{Tracking_Id=7, Status= "Entregado al cliente", Description="Es un paquete de sumo cuidado", Initial_Date="10/01/2022", Deliver_Date="12/02/2020", Id_Route=2, Dni_Client=307840671, Dni_Employee=506780345},
               new Package{Tracking_Id=8, Status= "Listo para Entrega", Description="Es un paquete de sumo cuidado", Initial_Date="10/01/2021", Deliver_Date="12/02/2020", Id_Route=1, Dni_Client=207840516, Dni_Employee=506780345},
               new Package{Tracking_Id=9, Status= "Entregado al cliente", Description="Es un paquete de sumo cuidado", Initial_Date="10/01/2020", Deliver_Date="12/02/2020", Id_Route=2, Dni_Client=307840671, Dni_Employee=506780345}
            };

            return listPakages;
        }

    }

}