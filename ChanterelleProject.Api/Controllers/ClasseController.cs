using ChanterelleProject.Api.Forms;
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
    public class ClasseController : ControllerBase
    {
        private IClasse<int, ClasseClient, ClasseFullAttributeForViewClient> _classeServicesClient;

        public ClasseController(IClasse<int, ClasseClient, ClasseFullAttributeForViewClient> classeServicesClient)
        {
            _classeServicesClient = classeServicesClient;
        }
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<ClasseFullAttributeForViewClient> GetAll()
        {
            return _classeServicesClient.GetAll();
        }

        [HttpGet]
        [Route("GetOne/{id}")]
        public ClasseFullAttributeForViewClient GetOne(int id)
        {
            return _classeServicesClient.Get(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (_classeServicesClient.DeleteClasse(id))
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
        public IActionResult Create([FromBody] FormsCreateClasse formsCreateClasse)
        {
            int idNewSpecialisation = _classeServicesClient.InsertClasse(formsCreateClasse.ToClasseClient());
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
        public IActionResult Update(int id, [FromBody] FormsUpdateClasse formsUpdateClasse)
        {
            bool resultTransaction = _classeServicesClient.UpdateClasse(id, formsUpdateClasse.ToClasseClient());
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
