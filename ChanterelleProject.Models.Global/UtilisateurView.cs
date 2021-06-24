using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class UtilisateurView : Utilisateur
    {
        public string NumInami { get; set; }
        public int? SpecialisationId { get; set; }
    }
}
