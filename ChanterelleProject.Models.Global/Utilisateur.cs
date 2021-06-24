using System;

namespace ChanterelleProject.Models.Global
{
    public class Utilisateur 
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
    }
}
