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
    public class EleveController : ControllerBase
    {
        private IEleve<int,EleveClient,EleveViewClient> _eleveServicesClient;

        public EleveController(IEleve<int, EleveClient, EleveViewClient> eleveServicesClient)
        {
            _eleveServicesClient = eleveServicesClient;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_eleveServicesClient.GetAll());
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_eleveServicesClient.Get(id));
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_eleveServicesClient.DeleteEleve(id))
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
        public IActionResult Create([FromBody] FormsCreateEleve formsCreateEleve)
        {
            if (formsCreateEleve is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                int idNewEleve = _eleveServicesClient.InsertEleve(formsCreateEleve.ToEleveClient());
                if (idNewEleve == 0){return BadRequest();}
                return Ok(idNewEleve);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id, [FromBody] FormsUpdateEleve formsUpdateEleve)
        {
            if (formsUpdateEleve is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                bool resultTransaction = _eleveServicesClient.UpdateEleve(id, formsUpdateEleve.ToEleveClient());
                if (resultTransaction == false){return BadRequest();}
                return Ok(resultTransaction);
            }
        }
    }
}
