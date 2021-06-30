﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms
{
    public class FormsCreateAllocationParaMedicals
    {
        [Required]
        public int Class_Id { get; set; }
        [Required]
        public DateTime DateDebut { get; set; }
        [Required]
        public int ParaMedical_Id { get; set; }
    }
}
