using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client.ModelClientForViews
{
    public class EleveViewClient:IEntity<int>
    {
        public EleveViewClient(int id, string nom, string prenom, string adresse, DateTime dateNaissance, string registreNational, string sexe, DateTime dateDerniereModif, DateTime dateInscription, string nomMedecinExterne, string nomClasse, IEnumerable<TraitementViewClient> traitementsAdministres)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            DateNaissance = dateNaissance;
            RegistreNational = registreNational;
            Sexe = sexe;
            DateDerniereModif = dateDerniereModif;
            DateInscription = dateInscription;
            NomMedecinExterne = nomMedecinExterne;
            NomClasse = nomClasse;
            TraitementsAdministres = traitementsAdministres;
        }

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
        public string NomClasse { get; set; }
        public IEnumerable<TraitementViewClient> TraitementsAdministres { get; set; }
    }
}
