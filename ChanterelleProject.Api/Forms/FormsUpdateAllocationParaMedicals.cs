using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms
{
    public class FormsUpdateAllocationParaMedicals
    {
        [Required]
        public int Class_Id { get; set; }
        [Required]
        public int ParaMedical_Id { get; set; }
    }
}
