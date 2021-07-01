using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class EleveGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime DateNaissance { get; set; }
        public string RegistreNational { get; set; }
        public string Sexe { get; set; }
        public int MedecinExterne_Id { get; set; }
        public int Classe_Id { get; set; }
    }
}
