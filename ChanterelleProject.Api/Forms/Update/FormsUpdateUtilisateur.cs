using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms.Update
{
    public class FormsUpdateUtilisateur
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
        public DateTime DateDebutContrat { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public int TypeUtilisateur_Id { get; set; }
        [Required]
        public string MotDePasse { get; set; }
    }
}
