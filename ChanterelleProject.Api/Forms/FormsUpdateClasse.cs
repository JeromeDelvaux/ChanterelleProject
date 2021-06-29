using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms
{
    public class FormsUpdateClasse
    {
        [Required]
        public string IntituleClasse { get; set; }
        [Required]
        public int NbEleveMax { get; set; }
        [Required]
        public int Utilisateur_Id { get; set; }
    }
}
