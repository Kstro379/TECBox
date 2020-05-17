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
    public class ClientController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Client>>> Get()
        {
            var listClients = await GetListClients();

            if (listClients.Count < 0)
                return NotFound();

            return listClients;
        }

        [HttpGet("login")]
        public async Task<ActionResult<Client>> GetByUserNamePassword(ClientModel clientModel)
        {
            var listClients = await GetListClients();

            if (listClients.Count < 0)
                return NotFound();

            var client = listClients.FirstOrDefault(
                u => u.User == clientModel.User && u.Password == clientModel.Password
                );

            if (client == null)
                return NotFound();

            return client;
        }

        [HttpPost]
        public async Task<ActionResult<List<Client>>> Post(Client client)
        {
            var listClients = await GetListClients();

            listClients.Add(new Client()
            {
                Dni = client.Dni,
                User = client.User,
                Name = client.Name,
                Last_Name = client.Last_Name,
                PhoneNumber = client.PhoneNumber,
                email = client.email,
                Password = client.Password,
                House_PhoneNumber = client.House_PhoneNumber,
                Locker = client.Locker,
                Province = client.Province,
                Canton = client.Canton,
                District = client.District,
                Address = client.Address
                 

            });

            return listClients;
        }

        [HttpPut]
        public async Task<ActionResult<List<Client>>> Put(Client client)
        {
            var listClients = await GetListClients();

            var clientUpdate = listClients.Find(u => u.Dni == client.Dni);

            if (clientUpdate == null)
                return NotFound();

            listClients.First(u => u.Dni == clientUpdate.Dni).User = client.User;
            listClients.First(u => u.Dni == clientUpdate.Dni).Name = client.Name;
            listClients.First(u => u.Dni == clientUpdate.Dni).Last_Name = client.Last_Name;
            listClients.First(u => u.Dni == clientUpdate.Dni).PhoneNumber = client.PhoneNumber;
            listClients.First(u => u.Dni == clientUpdate.Dni).email = client.email;
            listClients.First(u => u.Dni == clientUpdate.Dni).Password = client.Password;
            listClients.First(u => u.Dni == clientUpdate.Dni).House_PhoneNumber = client.House_PhoneNumber;
            listClients.First(u => u.Dni == clientUpdate.Dni).Locker = client.Locker;
            listClients.First(u => u.Dni == clientUpdate.Dni).Province = client.Province;
            listClients.First(u => u.Dni == clientUpdate.Dni).Canton = client.Canton;
            listClients.First(u => u.Dni == clientUpdate.Dni).District = client.District;
            listClients.First(u => u.Dni == clientUpdate.Dni).Address = client.Address;

            return listClients;
        }

        [HttpDelete("{dni}")]
        public async Task<ActionResult<List<Client>>> Delete(int dni)
        {
            var listClients = await GetListClients();

            var clientDelete = listClients.Find(u => u.Dni == dni);

            if (clientDelete == null)
                return NotFound();

            listClients.Remove(clientDelete);
            return listClients;
        }



        //DATA BASE
        private async Task<List<Client>> GetListClients()
        {
            var listClients = new List<Client>()
            {
               new Client{Dni=207840516, User="Oldboy379", Name="Olman", Last_Name="Castro Hernández", PhoneNumber=87032028, email="kstro379@gmail.com", Password="Estanoes", House_PhoneNumber=27610916, Locker=564389, Province="Heredia", Canton="Sarapiquí", District="La Virgen", Address="Del Bar Bonanza 2km al oeste"},
               new Client{Dni=307840671, User="Randall123", Name="Randall", Last_Name="Solano", PhoneNumber=87022029, email="Randall123@gmail.com", Password="12345", House_PhoneNumber=25557898, Locker=453290, Province="Cartago", Canton="Oreamuno", District="San Rafael", Address="Costado este del parque"}
            };

            return listClients;
        }

    }

    public class ClientModel
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}