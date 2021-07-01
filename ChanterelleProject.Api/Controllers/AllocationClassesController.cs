using ChanterelleProject.Api.Forms.Create;
using ChanterelleProject.Api.Forms.Update;
using ChanterelleProject.Api.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Client.ModelClientForViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllocationClassesController : ControllerBase
    {
        private IAllocationClasses<int, AllocationClassesClient, AllocationClassesViewClient> _allocationClassesServicesClient;

        public AllocationClassesController(IAllocationClasses<int, AllocationClassesClient, AllocationClassesViewClient> allocationClassesServicesClient)
        {
            _allocationClassesServicesClient = allocationClassesServicesClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<AllocationClassesViewClient> GetAll()
        {
            return _allocationClassesServicesClient.GetAll();
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public AllocationClassesViewClient GetOne(int id)
        {
            return _allocationClassesServicesClient.Get(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_allocationClassesServicesClient.DeleteAllocationClasses(id))
            {
                return Ok(); //Retourne le statutCode 200
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] FormsCreateAllocationClasses formsCreateAllocationClasses)
        {
            int idNewAllocationClasses = _allocationClassesServicesClient.InsertAllocationClasses(formsCreateAllocationClasses.ToAllocationClassesClient());
            if (idNewAllocationClasses == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(idNewAllocationClasses);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id, [FromBody] FormsUpdateAllocationClasses formsUpdateAllocationClasses)
        {
            bool resultTransaction = _allocationClassesServicesClient.UpdateAllocationClasses(id, formsUpdateAllocationClasses.ToAllocationClassesClient());
            if (resultTransaction == false)
            {
                return BadRequest();
            }
            else
            {
                return Ok(resultTransaction);
            }
        }
    }
}
