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
    
    public class RoleController : ControllerBase
    {

        /**
         * Obtiene todos los roles.
         * @return: Lista de roles.
         */
        [HttpGet]
        public async Task<ActionResult<List<Role>>> Get()
        {
            var listRoles = await GetListRoles();

            if (listRoles.Count < 0)
                return NotFound();

            return listRoles;
        }

        /**
         * Crea un rol.
         * @param package: Informacion del rol.
         * @return: Lista de roles actualizada.
         */
        [HttpPost]
        public async Task<ActionResult<List<Role>>> Post(Role role)
        {
            var listRoles = await GetListRoles();

            listRoles.Add(new Role()
            {
                Name = role.Name,
                Description = role.Description,
                Dni_Employee = role.Dni_Employee

            });

            return listRoles;
        }

        /**
         * Actualiza la informacion del rol.
         * @param role: Informacion del rol.
         * @return: Toda la informacion del rol actualizada.
         */
        [HttpPut]
        public async Task<ActionResult<List<Role>>> Put(Role role)
        {
            var listRoles = await GetListRoles();

            var roleUpdate = listRoles.Find(u => u.Name == role.Name);

            if (roleUpdate == null)
                return NotFound();

            listRoles.First(u => u.Name == roleUpdate.Name).Description = role.Description;
            listRoles.First(u => u.Name == roleUpdate.Name).Dni_Employee = role.Dni_Employee;
            

            return listRoles;
        }

        /**
         * Elimina un rol.
         * @param name: Nombre del rol.
         * @return: Lista de roles actualizada.
         */
        [HttpDelete("{name}")]
        public async Task<ActionResult<List<Role>>> Delete(string name)
        {
            var listRoles = await GetListRoles();

            var rolesDelete = listRoles.Find(u => u.Name == name);

            if (rolesDelete == null)
                return NotFound();

            listRoles.Remove(rolesDelete);
            return listRoles;
        }



        //DATA BASE
        private async Task<List<Role>> GetListRoles()
        {
            var listRoles = new List<Role>()
            {
               new Role{Name="Administrador",Description="Engardado de administrar un departamento", Dni_Employee = new int[] {27840876} },
               new Role{Name="Repartidor",Description="Encargado de entregar los paquetes", Dni_Employee = new int[] {506780345, 401580278 } },
               new Role{Name="Bodeguero",Description="Encargado de gestionar los paquetes y productos", Dni_Employee = new int[] { } }
            };

            return listRoles;
        }

    }

}