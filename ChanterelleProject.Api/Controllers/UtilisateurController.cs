using ChanterelleProject.Api.Forms;
using ChanterelleProject.Api.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace ChanterelleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateur<int,UtilisateurClient,UtilisateurClientView> _utilisateursServiceClient;


        public UtilisateurController(IUtilisateur<int,UtilisateurClient, UtilisateurClientView> utilisateursServiceClient)
        {
            this._utilisateursServiceClient = utilisateursServiceClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<UtilisateurClient> GetAll()
        {
            return _utilisateursServiceClient.GetAll();
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public UtilisateurClient GetOne(int id)
        {
            return _utilisateursServiceClient.Get(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_utilisateursServiceClient.Delete(id))
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
        public IActionResult Create([FromBody] FormsCreateUtilisateur formsCreateUtilisateur)
        {
            int idNewUtilisateur = _utilisateursServiceClient.Insert(formsCreateUtilisateur.ToUtilisateursClient());
            if (idNewUtilisateur == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(idNewUtilisateur);
            }
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id,[FromBody] FormsUpdateUtilisateur formsUpdateUtilisateur)
        {
            bool idNewUtilisateur = _utilisateursServiceClient.Update(id, formsUpdateUtilisateur.ToUtilisateursClient());
            if (idNewUtilisateur == false)
            {
                return BadRequest();
            }
            else
            {
                return Ok(idNewUtilisateur);
            }
        }
    }
}
