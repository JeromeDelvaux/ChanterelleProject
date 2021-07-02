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
    public class InscriptionController : ControllerBase
    {
        private IInscription<int, InscriptionClient, InscriptionViewClient> _inscriptionServicesClient;

        public InscriptionController(IInscription<int, InscriptionClient, InscriptionViewClient> inscriptionServicesClient)
        {
            _inscriptionServicesClient = inscriptionServicesClient;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_inscriptionServicesClient.GetAll());
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_inscriptionServicesClient.Get(id));
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_inscriptionServicesClient.DeleteInscription(id))
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
        public IActionResult Create([FromBody] FormsCreateInscription formsCreateInscription)
        {
            if (formsCreateInscription is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                int idNewInscription = _inscriptionServicesClient.InsertInscription(formsCreateInscription.ToInscriptionClient());
                if (idNewInscription == 0){return BadRequest();}
                return Ok(idNewInscription);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id, [FromBody] FormsUpdateInscription formsUpdateInscription)
        {
            if (formsUpdateInscription is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                bool resultTransaction = _inscriptionServicesClient.UpdateInscription(id, formsUpdateInscription.ToInscriptionClient());
                if (resultTransaction == false){return BadRequest();}
                return Ok(resultTransaction);
            }
        }
    }
}
