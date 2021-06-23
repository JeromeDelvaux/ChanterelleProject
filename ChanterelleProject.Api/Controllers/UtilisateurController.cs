using ChanterelleProject.Api.Forms;
using ChanterelleProject.Api.Mappers;
using ChanterelleProject.ClientServices.Services;
using ChanterelleProject.Models.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatternRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IRepository<int,UtilisateurClient> _utilisateursServiceClient;

        public UtilisateurController(IRepository<int,UtilisateurClient> utilisateursServiceClient)
        {
            this._utilisateursServiceClient = utilisateursServiceClient;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<UtilisateurClient> GetAll()
        {
            return _utilisateursServiceClient.GetAll();
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
