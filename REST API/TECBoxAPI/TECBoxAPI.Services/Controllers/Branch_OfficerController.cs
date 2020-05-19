using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TECBoxAPI.Services.Models;

namespace TECBoxAPI.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class Branch_OfficerController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Branch_Office>>> Get()
        {
            var listBranch_Officer = await GetListBranch_Officer();

            if (listBranch_Officer.Count < 0)
                return NotFound();

            return listBranch_Officer;
        }

        [HttpPost]
        public async Task<ActionResult<List<Branch_Office>>> Post(Branch_Office branch_Office)
        {
            var listBranch_Office = await GetListBranch_Officer();

            listBranch_Office.Add(new Branch_Office()
            {
                Name = branch_Office.Name,
                PhoneNumber = branch_Office.PhoneNumber,
                In_charge = branch_Office.In_charge,
                Province = branch_Office.Province,
                Canton = branch_Office.Canton,
                District = branch_Office.District,
                Address = branch_Office.Address
                

            });

            return listBranch_Office;
        }

        [HttpPut]
        public async Task<ActionResult<List<Branch_Office>>> Put(Branch_Office branch_Office)
        {
            var listBranch_Officer = await GetListBranch_Officer();

            var branch_OfficerUpdate = listBranch_Officer.Find(u => u.Name == branch_Office.Name);

            if (branch_OfficerUpdate == null)
                return NotFound();

            listBranch_Officer.First(u => u.Name == branch_OfficerUpdate.Name).Name = branch_Office.Name;
            listBranch_Officer.First(u => u.Name == branch_OfficerUpdate.Name).PhoneNumber = branch_Office.PhoneNumber;
            listBranch_Officer.First(u => u.Name == branch_OfficerUpdate.Name).In_charge = branch_OfficerUpdate.In_charge;
            listBranch_Officer.First(u => u.Name == branch_OfficerUpdate.Name).Province = branch_OfficerUpdate.Province;
            listBranch_Officer.First(u => u.Name == branch_OfficerUpdate.Name).Canton = branch_OfficerUpdate.Canton;
            listBranch_Officer.First(u => u.Name == branch_OfficerUpdate.Name).District = branch_OfficerUpdate.District;
            listBranch_Officer.First(u => u.Name == branch_OfficerUpdate.Name).Address = branch_OfficerUpdate.Address;

            return listBranch_Officer;
        }

        [HttpDelete("{name}")]
        public async Task<ActionResult<List<Branch_Office>>> Delete(string name)
        {
            var listBranch_Officer = await GetListBranch_Officer();

            var branch_OfficerDelete = listBranch_Officer.Find(u => u.Name == name);

            if (branch_OfficerDelete == null)
                return NotFound();

            listBranch_Officer.Remove(branch_OfficerDelete);
            return listBranch_Officer;
        }



        //DATA BASE
        private async Task<List<Branch_Office>> GetListBranch_Officer()
        {
            var listBranch_Officer = new List<Branch_Office>()
            {
               new Branch_Office{Name="Cartago",PhoneNumber=25552134, In_charge="Olman Castro", Province="Cartago", Canton="Cartago", District="Cartago Occidental", Address="100 metros sur del las Ruinas"},
               new Branch_Office{Name="Heredia", PhoneNumber=27610819, In_charge="Randal Solano", Province="Heredia", Canton="Srapiquí", District="La virgen", Address="Contiguo al Banco Nacional"},
               new Branch_Office{Name="Alajuela", PhoneNumber=27610819, In_charge="Brayn Cespedes", Province="Alajuela", Canton="Alajuela", District="Alajuela", Address="Diagonal al parque"}
            };

            return listBranch_Officer;
        }

    }

}