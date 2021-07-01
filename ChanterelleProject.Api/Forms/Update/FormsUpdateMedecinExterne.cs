using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms.Update
{
    public class FormsUpdateMedecinExterne
    {
        [Required]
        public string NumInami { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public DateTime DateNaissance { get; set; }
        [Required]
        public string TelephonePerso { get; set; }
        [Required]
        public string TelephoneCabinet { get; set; }
    }
}
