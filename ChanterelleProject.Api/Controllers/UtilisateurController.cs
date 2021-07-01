using ChanterelleProject.Api.Forms.Create;
using ChanterelleProject.Api.Forms.Update;
using ChanterelleProject.Api.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Client.ModelClientForViews;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace ChanterelleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateur<int,UtilisateurClient,UtilisateurViewClient, ParaMedicalClient> _utilisateursServiceClient;


        public UtilisateurController(IUtilisateur<int,UtilisateurClient, UtilisateurViewClient, ParaMedicalClient> utilisateursServiceClient)
        {
            this._utilisateursServiceClient = utilisateursServiceClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<UtilisateurViewClient> GetAll()
        {
            return _utilisateursServiceClient.GetAll();
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public UtilisateurViewClient GetOne(int id)
        {
            return _utilisateursServiceClient.Get(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_utilisateursServiceClient.DeleteUtilisateur(id))
            {
                return Ok(); //Retourne le statutCode 200
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("CreateUtilisateur")]
        public IActionResult CreateUtilisateur([FromBody] FormsCreateUtilisateur formsCreateUtilisateur)
        {
            int idNewUtilisateur = _utilisateursServiceClient.InsertUtilisateur(formsCreateUtilisateur.ToUtilisateursClient());
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
        [Route("UpdateUtilisateur/{id}")]
        public IActionResult UpdateUtilisateur(int id,[FromBody] FormsUpdateUtilisateur formsUpdateUtilisateur)
        {
            bool resultTransaction = _utilisateursServiceClient.UpdateUtilisateur(id, formsUpdateUtilisateur.ToUtilisateursClient());
            if (resultTransaction == false)
            {
                return BadRequest();
            }
            else
            {
                return Ok(resultTransaction);
            }
        }
        [HttpPost]
        [Route("CreateParaMedical")]
        public IActionResult CreateParaMedical([FromBody] FormsCreateParaMedical formsCreateCreateParaMedical)
        {
            int idNewUtilisateur = _utilisateursServiceClient.InsertParaMedical(formsCreateCreateParaMedical.ToParaMedicalClient());
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
        [Route("UpdateParaMedical/{id}")]
        public IActionResult UpdateParaMedical(int id, [FromBody] FormsUpdateParaMedical formsUpdateParaMedical)
        {
            bool resultTransaction = _utilisateursServiceClient.UpdateParaMedical(id, formsUpdateParaMedical.ToParaMedicalClient());
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
