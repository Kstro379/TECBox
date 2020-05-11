using System.Collections.Generic;
using Clients.Models;


namespace Clients.Data
{
    public class ClientRepository
    {
        private List<Client> clients;

        public ClientRepository()
        {
            this.clients = new List<Client>
            {
               new Client{Dni=207840516, User="Oldboy379", Name="Olman", Last_Name="Castro Hernández", PhoneNumber=87032028, email="kstro379@gmail.com", Password="Estanoes", House_PhoneNumber=27610916, Locker=564389, Province="Heredia", Canton="Sarapiquí", District="La Virgen", Address="Del Bar Bonanza 2km al oeste"},
               new Client{Dni=307840671, User="Randall123", Name="Randall", Last_Name="Solano", PhoneNumber=87022029, email="Randall123@gmail.com", Password="12345", House_PhoneNumber=25557898, Locker=453290, Province="Cartago", Canton="Oreamuno", District="San Rafael", Address="Costado este del parque"}
            };
        }

        public IEnumerable<Client> GetAppCommands()
        {
            return clients;
        }

        //Es necesario crear esta función por nombre
        public Client GetCommandById(int id)
        {
             
            return clients[id];
        }
    }
}