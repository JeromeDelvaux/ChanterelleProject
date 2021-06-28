using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class MedecinExterneGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public string NumInami { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        public DateTime DateNaissance { get; set; }
        public string TelephonePerso { get; set; }
        public string TelephoneCabinet { get; set; }
    }
}
