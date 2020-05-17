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
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            var listEmployees = await GetListEmployees();

            if (listEmployees.Count < 0)
                return NotFound();

            return listEmployees;
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> Post(Employee employee)
        {
            var listEmployees = await GetListEmployees();

            listEmployees.Add(new Employee()
            {
                Dni = employee.Dni,
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

        [HttpPut]
        public async Task<ActionResult<List<Employee>>> Put(Employee employee)
        {
            var listEmployees = await GetListEmployees();

            var employeeUpdate = listEmployees.Find(u => u.Dni == employee.Dni);

            if (employeeUpdate == null)
                return NotFound();

            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Password = employee.Password;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Name = employee.Name;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Last_Name = employee.Last_Name;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Date_Admission = employee.Date_Admission;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Birthdate = employee.Birthdate;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Hour_Salary = employee.Hour_Salary;
            listEmployees.First(u => u.Dni == employeeUpdate.Dni).Branch_Office = employee.Branch_Office;
            

            return listEmployees;
        }

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
               new Employee{Dni=27840876, Password="trabajador1", Name="Oscar", Last_Name="Rodrigues", Date_Admission="12/12/2010", Birthdate="10/10/1987", Hour_Salary=3000, Branch_Office="Cartago"},
               new Employee{Dni=506780345, Password="trabajador2", Name="Daniel", Last_Name="Martinez", Date_Admission="04/04/2019", Birthdate="02/02/1991", Hour_Salary=2000, Branch_Office="Heredia"}
            };

            return listEmployees;
        }

    }

}