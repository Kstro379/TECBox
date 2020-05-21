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
    public class SellController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Sell>>> Get()
        {
            var listSells = await GetListSells();

            if (listSells.Count < 0)
                return NotFound();

            return listSells;
        }

        [HttpPost]
        public async Task<ActionResult<List<Sell>>> Post(Sell sell)
        {
            var listSells = await GetListSells();

            listSells.Add(new Sell()
            {
                Code = sell.Code,
                Name = sell.Name,
                quantity = sell.quantity,
                sell_data = sell.sell_data

            });

            return listSells;
        }


        //DATA BASE
        private async Task<List<Sell>> GetListSells()
        {
            var listSellers = new List<Sell>()
            {
               new Sell{Code=12345, Name = "Celular papito", quantity = 15, sell_data = "2020-01-12"},
               new Sell{Code=12346, Name = "Equipo Audio", quantity = 22, sell_data = "2020-01-24"},
               new Sell{Code=12447, Name = "Luces móviles", quantity = 1, sell_data = "2020-02-03"},
               new Sell{Code=12444, Name = "Refri", quantity = 2, sell_data = "2020-02-12"},
               new Sell{Code=12423, Name = "Horno", quantity = 4, sell_data = "2020-02-26"},
               new Sell{Code=11111, Name = "olk", quantity = 32, sell_data = "2020-03-11"},
               new Sell{Code=9963, Name = "Table sansumg", quantity = 21, sell_data = "2020-03-18"},
               new Sell{Code=12, Name = "Lapto1", quantity = 3, sell_data = "2020-03-25"},
               new Sell{Code=1, Name = "labop2", quantity = 7, sell_data = "2020-04-01"},
               new Sell{Code=2, Name = "bci", quantity = 8, sell_data = "2020-04-08"},
               new Sell{Code=87, Name = "Pantalla plana", quantity = 3, sell_data = "2020-04-12"},
               new Sell{Code=12345, Name = "Celular papito", quantity = 15, sell_data = "2020-04-28"},
               new Sell{Code=12346, Name = "Equipo Audio", quantity = 22, sell_data = "2020-05-10"},
               new Sell{Code=12447, Name = "Luces móviles", quantity = 1, sell_data = "2020-05-15"},
               new Sell{Code=12444, Name = "Refri", quantity = 2, sell_data = "2020-05-22"},
               new Sell{Code=12423, Name = "Horno", quantity = 4, sell_data = "2020-06-13"},
               new Sell{Code=11111, Name = "olk", quantity = 32, sell_data = "2020-06-14"},
               new Sell{Code=9963, Name = "Table sansumg", quantity = 21, sell_data = "2020-06-29"},
               new Sell{Code=12, Name = "Lapto1", quantity = 3, sell_data = "2020-07-05"},
               new Sell{Code=1, Name = "labop2", quantity = 7, sell_data = "2020-07-18"},
               new Sell{Code=2, Name = "bci", quantity = 8, sell_data = "2020-07-24"},
               new Sell{Code=87, Name = "Pantalla plana", quantity = 3, sell_data = "2020-08-12"},

            };

            return listSellers;
        }
    }
}
