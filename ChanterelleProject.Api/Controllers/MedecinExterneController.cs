using ChanterelleProject.Api.Forms;
using ChanterelleProject.Api.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
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
    public class MedecinExterneController : ControllerBase
    {
        private IServices<int, MedecinExterneClient> _medecinExterneServicesClient;

        public MedecinExterneController(IServices<int, MedecinExterneClient> medecinExterneServicesClient)
        {
            _medecinExterneServicesClient = medecinExterneServicesClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<MedecinExterneClient> GetAll()
        {
            return _medecinExterneServicesClient.GetAll();
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public MedecinExterneClient GetOne(int id)
        {
            return _medecinExterneServicesClient.Get(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_medecinExterneServicesClient.Delete(id))
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
        public IActionResult Create([FromBody] FormsCreateMedecinExterne formsCreateMedecinExterne)
        {
            int idNewSpecialisation = _medecinExterneServicesClient.Insert(formsCreateMedecinExterne.ToMedecinExterneClient());
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
        public IActionResult Update(int id, [FromBody] FormsUpdateMedecinExterne formsUpdateMedecinExterne)
        {
            bool resultTransaction = _medecinExterneServicesClient.Update(id, formsUpdateMedecinExterne.ToMedecinExterneClient());
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
