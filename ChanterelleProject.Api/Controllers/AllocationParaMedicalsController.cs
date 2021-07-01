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
    public class AllocationParaMedicalsController : ControllerBase
    {
        private IAllocationParaMedicals<int, AllocationParaMedicalsClient, AllocationParaMedicalsViewClient> _allocationParaMedicalsServicesClient;

        public AllocationParaMedicalsController(IAllocationParaMedicals<int, AllocationParaMedicalsClient, AllocationParaMedicalsViewClient> allocationParaMedicalsServicesClient)
        {
            _allocationParaMedicalsServicesClient = allocationParaMedicalsServicesClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<AllocationParaMedicalsViewClient> GetAll()
        {
            return _allocationParaMedicalsServicesClient.GetAll();
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public AllocationParaMedicalsViewClient GetOne(int id)
        {
            return _allocationParaMedicalsServicesClient.Get(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_allocationParaMedicalsServicesClient.DeleteAllocationParaMedicals(id))
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
        public IActionResult Create([FromBody] FormsCreateAllocationParaMedicals formsCreateAllocationParaMedicals)
        {
            int idNewSpecialisation = _allocationParaMedicalsServicesClient.InsertAllocationParaMedicals(formsCreateAllocationParaMedicals.ToAllocationParaMedicalsClient());
            if (idNewSpecialisation == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(idNewSpecialisation);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id, [FromBody] FormsUpdateAllocationParaMedicals formsUpdateAllocationParaMedicals)
        {
            bool resultTransaction = _allocationParaMedicalsServicesClient.UpdateAllocationParaMedicals(id, formsUpdateAllocationParaMedicals.ToAllocationParaMedicalsClient());
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
