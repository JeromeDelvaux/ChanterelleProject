using PatternRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class Utilisateur : IEntity<int>
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime DateNaissance { get; set; }
        public string RegistreNational { get; set; }
        public string Sexe { get; set; }
        public DateTime DateDerniereModif { get; set; }
        public DateTime DateDebutContrat { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public int TypeUtilisateur_Id { get; set; }
        public string MotDePasse { get; set; }
        public string NumInami { get; set; }
        public int? SpecialisationId { get; set; }

    }
}
