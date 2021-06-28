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
    public class TypeUtilisateurController : ControllerBase
    {
        private ITypeUtilisateur<int, TypeUtilisateurClient> _typeUtilisateurServicesClient;

        public TypeUtilisateurController(ITypeUtilisateur<int, TypeUtilisateurClient> typeUtilisateurServicesClient)
        {
            _typeUtilisateurServicesClient = typeUtilisateurServicesClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<TypeUtilisateurClient> GetAll()
        {
            return _typeUtilisateurServicesClient.GetAll();
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public TypeUtilisateurClient GetOne(int id)
        {
            return _typeUtilisateurServicesClient.Get(id);
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
            int idNewSpecialisation = _typeUtilisateurServicesClient.Insert(formsCreateTypeUtilisateur.ToTypeUtilisateurClient());
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
        public IActionResult Update(int id, [FromBody] FormsUpdateTypeUtilisateur formsUpdateTypeUtilisateur)
        {
            bool resultTransaction = _typeUtilisateurServicesClient.Update(id, formsUpdateTypeUtilisateur.ToTypeUtilisateurClient());
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
