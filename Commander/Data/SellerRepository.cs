using System.Collections.Generic;
using Sellers.Models;

namespace Sellers.Data
{
    public class SellerRepository
    {
        private List<Seller> sellers;

        public SellerRepository()
        {
            this.sellers = new List<Seller>
            {
               new Seller{Dni=0, Name="María", Last_Name="Castro "},
               new Seller{Dni=1, Name="Jose", Last_Name="Oses"},
               new Seller{Dni=2, Name="Ruben", Last_Name="Campos"}
            };
        }

        public IEnumerable<Seller> GetAppCommands()
        {
            return sellers;
        }

        //Es necesario crear esta función por nombre
        public Seller GetCommandById(int id)
        {
             
            return sellers[id];
        }
    }
}