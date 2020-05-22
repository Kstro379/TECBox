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
    
    public class EmployeeController : ControllerBase
    {
        /**
         * Obtiene todos los empleados.
         * @return: Lista de empleados.
         */
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            var listEmployees = await GetListEmployees();

            if (listEmployees.Count < 0)
                return NotFound();

            return listEmployees;
        }

        /**
         * Realiza la comprobacion del empleado.
         * @param employeeModel: Informacion del empleado.
         * @return: Toda la informacion del empleado.
         */
        [HttpGet("login")]
        public async Task<ActionResult<Employee>> GetByEmployeeNamePassword(EmployeeModel employeeModel)
        {
            var listEmployees = await GetListEmployees();

            if (listEmployees.Count < 0)
                return NotFound();

            var employee = listEmployees.FirstOrDefault(
                u => u.UserName == employeeModel.User && u.Password == employeeModel.Password
                );

            if (employee == null)
                return NotFound();

            return employee;
        }

        /**
         * Obtiene la informacion del empleado.
         * @param id: ID del empleado.
         * @return: Toda la informacion del Empleado.
         */
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetDni(int id)
        {
            var listEmployees = await GetListEmployees();

            var employeGet = listEmployees.Find(u => u.Dni == id);

            return employeGet;
        }

        /**
         * Crea un empleado.
         * @param employee: Informacion del empleado.
         * @return: Lista de empleados actualizada.
         */
        [HttpPost]
        public async Task<ActionResult<List<Employee>>> Post(Employee employee)
        {
            var listEmployees = await GetListEmployees();

            listEmployees.Add(new Employee()
            {
                Dni = employee.Dni,
                UserName = employee.UserName,
                Password = employee.Password,
                Name = employee.Name,
                Last_Name = employee.Last_Name,
                Date_Admission = employee.Date_Admission,
                Birthdate = employee.Birthdate,
                Hour_Salary = employee.Hour_Salary,
                Branch_Office = employee.Branch_Office

            });

            return listEmployees;
        }

        /**
         * Actualiza la informacion del empleado.
         * @param employee: Informacion del empleado.
         * @return: Informacion del empleado actualizado.
         */
        [HttpPut]
        public async Task<ActionResult<List<Employee>>> Put(Employee employee)
        {
            var listEmployees = await GetListEmployees();

            var employeeUpdate = listEmployees.Find(u => u.Dni == employee.Dni);

            if (employeeUpdate == null)
                return NotFound();

            listEmployees.First(u => u.Dni == employeeUpdate.Dni).UserName = employee.UserName;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Password = employee.Password;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Name = employee.Name;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Last_Name = employee.Last_Name;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Date_Admission = employee.Date_Admission;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Birthdate = employee.Birthdate;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Hour_Salary = employee.Hour_Salary;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Branch_Office = employee.Branch_Office;
            

            return listEmployees;
        }

        /**
         * Elimina el empleado.
         * @param DNI: DNI del Empleado.
         * @return: Lista de empleados actualizada.
         */
        [HttpDelete("{dni}")]
        public async Task<ActionResult<List<Employee>>> Delete(int dni)
        {
            var listEmployees = await GetListEmployees();

            var employeeDelete = listEmployees.Find(u => u.Dni == dni);

            if (employeeDelete == null)
                return NotFound();

            listEmployees.Remove(employeeDelete);
            return listEmployees;
        }



        //DATA BASE
        private async Task<List<Employee>> GetListEmployees()
        {
            var listEmployees = new List<Employee>()
            {
               new Employee{Dni=27840876, UserName = "trabajador1", Password="trabajador1", Name="Oscar", Last_Name="Rodrigues", Date_Admission="2010-12-12", Birthdate="1987-10-10", Hour_Salary=3000, Branch_Office="Cartago"},
               new Employee{Dni=506780345, UserName= "trabajador2", Password="trabajador2", Name="Daniel", Last_Name="Martinez", Date_Admission="2019-04-04", Birthdate="1991-02-02", Hour_Salary=2000, Branch_Office="Heredia"},
               new Employee{Dni=401580278, UserName= "trabajador3", Password="trabajador3", Name="Lufy", Last_Name="D.", Date_Admission="2019-01-04", Birthdate="1991-08-02", Hour_Salary=200000, Branch_Office="Cartado"}
            };

            return listEmployees;
        }

    }

    public class EmployeeModel
    {
        public string User { get; set; }
        public string Password { get; set; }
    }

}