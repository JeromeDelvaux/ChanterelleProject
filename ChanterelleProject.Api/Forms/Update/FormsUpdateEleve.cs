using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms.Update
{
    public class FormsUpdateEleve
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public DateTime DateNaissance { get; set; }
        [Required]
        public string RegistreNational { get; set; }
        [Required]
        public string Sexe { get; set; }
        [Required]
        public int MedecinExterne_Id { get; set; }
        [Required]
        public int Classe_Id { get; set; }
    }
}
