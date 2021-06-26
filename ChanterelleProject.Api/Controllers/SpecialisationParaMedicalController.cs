using ChanterelleProject.Api.Forms;
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
        private ISpecialisationParaMedical<int, SpecialisationParaMedicalClient> _specialisationParaMedicalClient;

        public SpecialisationParaMedicalController(ISpecialisationParaMedical<int, SpecialisationParaMedicalClient> specialisationParaMedicalClient)
        {
            _specialisationParaMedicalClient = specialisationParaMedicalClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<SpecialisationParaMedicalClient> GetAll()
        {
            return _specialisationParaMedicalClient.GetAll();
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public SpecialisationParaMedicalClient GetOne(int id)
        {
            return _specialisationParaMedicalClient.Get(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_specialisationParaMedicalClient.Delete(id))
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
            int idNewSpecialisation = _specialisationParaMedicalClient.Insert(formsCreateSpecialisationParaMedical.ToSpecialisationParaMedicalClient());
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
        public IActionResult Update(int id, [FromBody] FormsUpdateSpecialisationParaMedical formsUpdateSpecialisationParaMedical)
        {
            bool resultTransaction = _specialisationParaMedicalClient.Update(id, formsUpdateSpecialisationParaMedical.ToSpecialisationParaMedicalClient());
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
