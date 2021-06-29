using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class ParaMedicalClient : IEntity<int>
    {
        public ParaMedicalClient(int id, string nom, string prenom, string adresse, DateTime dateNaissance, string registreNational, string sexe, DateTime dateDebutContrat, string telephone, string mail, int typeUtilisateur_Id, string motDePasse, string numInami, int? specialisationId)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            DateNaissance = dateNaissance;
            RegistreNational = registreNational;
            Sexe = sexe;
            DateDebutContrat = dateDebutContrat;
            Telephone = telephone;
            Mail = mail;
            TypeUtilisateur_Id = typeUtilisateur_Id;
            MotDePasse = motDePasse;
            NumInami = numInami;
            SpecialisationId = specialisationId;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime DateNaissance { get; set; }
        public string RegistreNational { get; set; }
        public string Sexe { get; set; }
        public DateTime DateDebutContrat { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public int TypeUtilisateur_Id { get; set; }
        public string MotDePasse { get; set; }
        public string NumInami { get; set; }
        public int? SpecialisationId { get; set; }
    }
}
