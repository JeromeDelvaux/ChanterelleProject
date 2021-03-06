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
        public IActionResult GetAll()
        {
            return Ok(_allocationClassesServicesClient.GetAll());
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_allocationClassesServicesClient.Get(id));
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
            if (formsCreateAllocationClasses is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                int idNewAllocationClasses = _allocationClassesServicesClient.InsertAllocationClasses(formsCreateAllocationClasses.ToAllocationClassesClient());
                if (idNewAllocationClasses == 0) { return BadRequest(); }
                return Ok(idNewAllocationClasses);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id, [FromBody] FormsUpdateAllocationClasses formsUpdateAllocationClasses)
        {
            if (formsUpdateAllocationClasses is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                bool resultTransaction = _allocationClassesServicesClient.UpdateAllocationClasses(id, formsUpdateAllocationClasses.ToAllocationClassesClient());
                if (resultTransaction == false){return BadRequest();}
                return Ok(resultTransaction);
            }
        }
    }
}
