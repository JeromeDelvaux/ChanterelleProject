using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms.Create
{
    public class FormsCreateClasse
    {
        [Required]
        public string IntituleClasse { get; set; }
        [Required]
        public int NbEleveMax { get; set; }
        [Required]
        public int Utilisateur_Id { get; set; }
    }
}
