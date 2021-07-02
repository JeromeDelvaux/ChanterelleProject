using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms.Update
{
    public class FormsUpdateInscription
    {
        [Required]
        public int Eleve_Id { get; set; }
        [Required]
        public int Utilisateur_Id { get; set; }
    }
}
