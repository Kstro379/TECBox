using System.Collections.Generic;
using Employees.Models;

namespace Employees.Data
{
    public class EmployeeRepository
    {
        private List<Employee> employees;

        public EmployeeRepository()
        {
            this.employees = new List<Employee>
            {
               new Employee{Dni=27840876, Password="trabajador1", Name="Oscar", Last_Name="Rodrigues", Date_Admission="12/12/2010", Birthdate="10/10/1987", Hour_Salary=3000, Branch_Office="Cartago"},
               new Employee{Dni=506780345, Password="trabajador2", Name="Daniel", Last_Name="Martinez", Date_Admission="04/04/2019", Birthdate="02/02/1991", Hour_Salary=2000, Branch_Office="Heredia"}
            };
        }

        public IEnumerable<Employee> GetAppCommands()
        {
            return employees;
        }

        //Es necesario crear esta función por nombre
        public Employee GetCommandById(int id)
        {
             
            return employees[id];
        }
    }
}