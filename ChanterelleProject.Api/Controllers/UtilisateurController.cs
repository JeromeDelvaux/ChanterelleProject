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
        private readonly IUtilisateur<int,UtilisateurClient> _utilisateursServiceClient;
        private readonly IUtilisateurView<int, UtilisateurClientView> _utilisateursServiceClientView;

        public UtilisateurController(IUtilisateur<int,UtilisateurClient> utilisateursServiceClient, IUtilisateurView<int, UtilisateurClientView> utilisateursServiceClientView)
        {
            this._utilisateursServiceClient = utilisateursServiceClient;
            this._utilisateursServiceClientView = utilisateursServiceClientView;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<UtilisateurClient> GetAll()
        {
            return _utilisateursServiceClientView.GetAll();
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
    }
}
