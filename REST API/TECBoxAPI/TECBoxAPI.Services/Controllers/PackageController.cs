using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
               new Package{Tracking_Id=0, Status= "Bodega", Description="Es un paquete de sumo cuidado", Initial_Date="10/05/2020", Deliver_Date="12/05/2020", Id_Route=1, Dni_Client=209870456, Dni_Employee=309870567},
               new Package{Tracking_Id=1, Status= "Bodega", Description="Es un paquete de sumo cuidado", Initial_Date="10/05/2020", Deliver_Date="12/05/2020", Id_Route=2, Dni_Client=209870456, Dni_Employee=309870567}
            };

            return listPakages;
        }

    }

}