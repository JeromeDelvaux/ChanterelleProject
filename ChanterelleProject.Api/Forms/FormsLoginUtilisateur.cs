using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms
{
    public class FormsLoginUtilisateur
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string MotDePasse { get; set; }
    }
}
