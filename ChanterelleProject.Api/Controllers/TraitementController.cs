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
    public class TraitementController : ControllerBase
    {
        private ITraitement<int, TraitementClient, TraitementViewClient> _traitementServicesClient;

        public TraitementController(ITraitement<int, TraitementClient, TraitementViewClient> traitementServicesClient)
        {
            _traitementServicesClient = traitementServicesClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_traitementServicesClient.GetAll());
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_traitementServicesClient.Get(id));
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult DeleteTraitement(int id)
        {
            if (_traitementServicesClient.DeleteTraitement(id))
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
        public IActionResult CreateTraitement([FromBody] FormsCreateTraitement formsCreateTraitement)
        {
            if (formsCreateTraitement is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                int idNewTraitement = _traitementServicesClient.InsertTraitement(formsCreateTraitement.ToTraitementClient());
                if (idNewTraitement == 0){return BadRequest();}
                return Ok(idNewTraitement);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult UpdateTraitement(int id, [FromBody] FormsUpdateTraitement formsUpdateTraitement)
        {
            if (formsUpdateTraitement is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                bool resultTransaction = _traitementServicesClient.UpdateTraitement(id, formsUpdateTraitement.ToTraitementClient());
                if (resultTransaction == false){return BadRequest();}
                return Ok(resultTransaction);
            }
        }
    }
}
