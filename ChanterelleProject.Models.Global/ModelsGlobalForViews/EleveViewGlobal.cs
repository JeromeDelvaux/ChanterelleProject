using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global.ModelsGlobalForViews
{
    public class EleveViewGlobal
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime DateNaissance { get; set; }
        public string RegistreNational { get; set; }
        public string Sexe { get; set; }
        public DateTime DateDerniereModif { get; set; }
        public DateTime DateInscription { get; set; }
        public string NomMedecinExterne { get; set; }
        public string NomClasse{ get; set; }
    }
}
