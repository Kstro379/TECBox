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
    
    public class UserController : ControllerBase
    {

        /**
         * Obtiene todos los Usuarios.
         * @return: Lista de Usuarios.
         */
        [HttpGet]
        public async Task<ActionResult<List<UserEntity>>> Get()
        {
            var listUsers = await GetListUsers();

            if (listUsers.Count < 0)
                return NotFound();

            return listUsers;
        }

        [HttpGet("login")]
        public async Task<ActionResult<UserEntity>> GetByUserNamePassword(UserModel userModel)
        {
            var listUsers = await GetListUsers();

            if (listUsers.Count < 0)
                return NotFound();

            var userEntity = listUsers.FirstOrDefault(
                u => u.UserName == userModel.UserName && u.Password == userModel.Password
                );

            if (userEntity == null)
                return NotFound();

            return userEntity;
        }

        [HttpPost]
        public async Task<ActionResult<List<UserEntity>>> Post(UserEntity userEntity)
        {
            var listUsers = await GetListUsers();

            listUsers.Add(new UserEntity()
            {
                Id = listUsers.Count + 1,
                Name = userEntity.Name,
                UserName = userEntity.UserName,
                Password = userEntity.Password

            });

            return listUsers;
        }

        [HttpPut]
        public async Task<ActionResult<List<UserEntity>>> Put(UserEntity userEntity)
        {
            var listUsers = await GetListUsers();

            var userUpdate = listUsers.Find(u => u.Id == userEntity.Id);

            if (userUpdate == null)
                return NotFound();

            listUsers.First(u => u.Id == userUpdate.Id).Name = userEntity.Name;
            listUsers.First(u => u.Id == userUpdate.Id).UserName = userEntity.UserName;
            listUsers.First(u => u.Id == userUpdate.Id).Password = userEntity.Password;

            return listUsers;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<UserEntity>>> Delete( int id)
        {
            var listUsers = await GetListUsers();

            var userDelete = listUsers.Find(u => u.Id == id);

            if (userDelete == null)
                return NotFound();

            listUsers.Remove(userDelete);
            return listUsers;
        }



        //DATA BASE
        private async Task<List<UserEntity>> GetListUsers()
        {
            var listUsers = new List<UserEntity>()
            {
                new UserEntity(){Id = 1, Name = "Olman Castro", UserName = "user01", Password = "pass01"},
                new UserEntity(){Id = 2, Name = "Rolando Ureña", UserName = "user02", Password = "pass02"},
                new UserEntity(){Id = 3, Name = "Alvaro Chacon", UserName = "user03", Password = "pass03"},
                new UserEntity(){Id = 4, Name = "Alejandra Hernández", UserName = "user04", Password = "pass04"},
                new UserEntity(){Id = 5, Name = "Laura Castro", UserName = "user05", Password = "pass05"}
            };

            return listUsers;
        }
        
    }

    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}