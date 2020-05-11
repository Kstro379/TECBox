using System.Collections.Generic;
using Products.Models;

namespace Products.Data
{
    public class ProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            this.products = new List<Product>
            {
               new Product{Code=12345, Name="Celular papito",Description="Moderno telefono", Price=200, Discount=0, Tax=13, Dni_Employee=0, Dni_client=0, Branch_Office="Cartago" },
               new Product{Code=12346, Name="Equipo Audio",Description="Equipo de audio", Price=250, Discount=5, Tax=0, Dni_Employee=1, Dni_client=1, Branch_Office="Heredia" },
               new Product{Code=12447, Name="Luces móviles",Description="Tachos LED", Price=400, Discount=20, Tax=6, Dni_Employee=2, Dni_client=2, Branch_Office="Alajuela" }
            };
        }

        public IEnumerable<Product> GetAppCommands()
        {
            return products;
        }

        //Es necesario crear esta función por nombre
        public Product GetCommandById(int id)
        {
             
            return products[id];
        }
    }
}