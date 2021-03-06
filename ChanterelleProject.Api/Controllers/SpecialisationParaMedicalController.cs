using ChanterelleProject.Api.Forms.Create;
using ChanterelleProject.Api.Forms.Update;
using ChanterelleProject.Api.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChanterelleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialisationParaMedicalController : ControllerBase
    {
        private IServices<int, SpecialisationParaMedicalClient> _specialisationParaMedicalServicesClient;

        public SpecialisationParaMedicalController(IServices<int, SpecialisationParaMedicalClient> specialisationParaMedicalClient)
        {
            _specialisationParaMedicalServicesClient = specialisationParaMedicalClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_specialisationParaMedicalServicesClient.GetAll());
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_specialisationParaMedicalServicesClient.Get(id));
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_specialisationParaMedicalServicesClient.Delete(id))
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
        public IActionResult Create([FromBody] FormsCreateSpecialisationParaMedical formsCreateSpecialisationParaMedical)
        {
            if (formsCreateSpecialisationParaMedical is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                int idNewSpecialisation = _specialisationParaMedicalServicesClient.Insert(formsCreateSpecialisationParaMedical.ToSpecialisationParaMedicalClient());
                if (idNewSpecialisation == 0){return BadRequest();}
                return Ok(idNewSpecialisation);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id, [FromBody] FormsUpdateSpecialisationParaMedical formsCreateSpecialisationParaMedical)
        {
            if (formsCreateSpecialisationParaMedical is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                bool resultTransaction = _specialisationParaMedicalServicesClient.Update(id, formsCreateSpecialisationParaMedical.ToSpecialisationParaMedicalClient());
                if (resultTransaction == false){return BadRequest();}
                return Ok(resultTransaction);
            }
        }
    }
}
