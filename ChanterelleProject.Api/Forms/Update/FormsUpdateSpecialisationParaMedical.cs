using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms.Update
{
    public class FormsUpdateSpecialisationParaMedical
    {
        [Required]
        public string IntituleSpecialisation { get; set; }
    }
}
