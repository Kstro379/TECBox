using System.Collections.Generic;
using Roles.Models;

namespace Roles.Data
{
    public class RoleRepository
    {
        private List<Role> roles;

        public RoleRepository()
        {
            this.roles = new List<Role>
            {
               new Role{Name="Administrador",Description="Engardado de administrar un departamento", Dni_Employee=0},
               new Role{Name="Repartidor",Description="Encargado de entregar los paquetes", Dni_Employee=1},
               new Role{Name="Bodeguero",Description="Encargado de gestionar los paquetes y productos", Dni_Employee=2}
            };
        }

        public IEnumerable<Role> GetAppCommands()
        {
            return roles;
        }

        //Es necesario crear esta función por nombre
        public Role GetCommandById(int id)
        {
             
            return roles[id];
        }
    }
}