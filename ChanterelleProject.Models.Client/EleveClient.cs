using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class EleveClient:IEntity<int>
    {
        public EleveClient(int id, string nom, string prenom, string adresse, DateTime dateNaissance, string registreNational, string sexe, int medecinExterne_Id, int classe_Id)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            DateNaissance = dateNaissance;
            RegistreNational = registreNational;
            Sexe = sexe;
            MedecinExterne_Id = medecinExterne_Id;
            Classe_Id = classe_Id;
        }

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
