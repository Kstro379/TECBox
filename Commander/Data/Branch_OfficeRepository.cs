using System.Collections.Generic;
using Branch_Offices.Models;

namespace Branch_Offices.Data
{
    public class Branch_OfficeRepository
    {
        private List<Branch_Office> branch_offices;

        public Branch_OfficeRepository()
        {
            this.branch_offices = new List<Branch_Office>
            {
               new Branch_Office{Name="Cartago",PhoneNumber=25552134, In_charge="Olman Castro", Province="Cartago", Canton="Cartago", District="Cartago Occidental", Address="100 metros sur del las Ruinas"},
               new Branch_Office{Name="Heredia", PhoneNumber=27610819, In_charge="Randal Solana", Province="Heredia", Canton="Srapiquí", District="La virgen", Address="Contiguo al Banco Nacional"}
            };
        }

        public IEnumerable<Branch_Office> GetAppCommands()
        {
            return branch_offices;
        }

        //Es necesario crear esta función por nombre
        public Branch_Office GetCommandById(int id)
        {
             
            return branch_offices[id];
        }
    }
}