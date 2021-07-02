using ChanterelleProject.Api.Forms.Create;
using ChanterelleProject.Api.Forms.Update;
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
    public class TypeUtilisateurController : ControllerBase
    {
        private IServices<int, TypeUtilisateurClient> _typeUtilisateurServicesClient;

        public TypeUtilisateurController(IServices<int, TypeUtilisateurClient> typeUtilisateurServicesClient)
        {
            _typeUtilisateurServicesClient = typeUtilisateurServicesClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_typeUtilisateurServicesClient.GetAll());
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_typeUtilisateurServicesClient.Get(id));
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_typeUtilisateurServicesClient.Delete(id))
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
        public IActionResult Create([FromBody] FormsCreateTypeUtilisateur formsCreateTypeUtilisateur)
        {
            if (formsCreateTypeUtilisateur is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                int idNewSpecialisation = _typeUtilisateurServicesClient.Insert(formsCreateTypeUtilisateur.ToTypeUtilisateurClient());
                if (idNewSpecialisation == 0){return BadRequest();}
                return Ok(idNewSpecialisation);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id, [FromBody] FormsUpdateTypeUtilisateur formsUpdateTypeUtilisateur)
        {
            if (formsUpdateTypeUtilisateur is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                bool resultTransaction = _typeUtilisateurServicesClient.Update(id, formsUpdateTypeUtilisateur.ToTypeUtilisateurClient());
                if (resultTransaction == false){return BadRequest();}
                return Ok(resultTransaction);
            }
        }
    }
}
