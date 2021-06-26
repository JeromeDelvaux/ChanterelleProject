using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms
{
    public class FormsUpdateSpecialisationParaMedical
    {
        [Required]
        public string Intitule { get; set; }
    }
}
