using ChanterelleProject.Api.Forms;
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
        public IActionResult GetAll()
        {
            return Ok(_utilisateursServiceClient.GetAll());
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_utilisateursServiceClient.Get(id));
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
            if (formsCreateUtilisateur is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                int idNewUtilisateur = _utilisateursServiceClient.InsertUtilisateur(formsCreateUtilisateur.ToUtilisateursClient());
                if (idNewUtilisateur == 0){return BadRequest();}
                return Ok(idNewUtilisateur);
            }
            
        }

        [HttpPut]
        [Route("UpdateUtilisateur/{id}")]
        public IActionResult UpdateUtilisateur(int id,[FromBody] FormsUpdateUtilisateur formsUpdateUtilisateur)
        {

            if (formsUpdateUtilisateur is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                bool resultTransaction = _utilisateursServiceClient.UpdateUtilisateur(id, formsUpdateUtilisateur.ToUtilisateursClient());
                if (resultTransaction == false){return BadRequest();}
                return Ok(resultTransaction);
            }
        }

        [HttpPost]
        [Route("CreateParaMedical")]
        public IActionResult CreateParaMedical([FromBody] FormsCreateParaMedical formsCreateCreateParaMedical)
        {
            if (formsCreateCreateParaMedical is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                int idNewUtilisateur = _utilisateursServiceClient.InsertParaMedical(formsCreateCreateParaMedical.ToParaMedicalClient());
                if (idNewUtilisateur == 0){return BadRequest();}
                return Ok(idNewUtilisateur);
            }
        }

        [HttpPut]
        [Route("UpdateParaMedical/{id}")]
        public IActionResult UpdateParaMedical(int id, [FromBody] FormsUpdateParaMedical formsUpdateParaMedical)
        {
            if (formsUpdateParaMedical is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                bool resultTransaction = _utilisateursServiceClient.UpdateParaMedical(id, formsUpdateParaMedical.ToParaMedicalClient());
                if (resultTransaction == false){return BadRequest();}
                return Ok(resultTransaction);
            }
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult LoginUtilisateur([FromBody] FormsLoginUtilisateur formsLoginUtilisateur)
        {

            if ( formsLoginUtilisateur is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                UtilisateurViewClient loginUtilisateur = _utilisateursServiceClient.LoginUtilisateur(formsLoginUtilisateur.Email, formsLoginUtilisateur.MotDePasse);
                if(loginUtilisateur is null){ return BadRequest(); }
                return Ok(loginUtilisateur);
            }
        }
    }
}
