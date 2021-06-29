using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class MedecinExterneClient : IEntity<int>
    {
        public MedecinExterneClient(int id, string numInami, string nom, string prenom, string adresse, string mail, DateTime dateNaissance, string telephonePerso, string telephoneCabinet)
        {
            Id = id;
            NumInami = numInami;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Mail = mail;
            DateNaissance = dateNaissance;
            TelephonePerso = telephonePerso;
            TelephoneCabinet = telephoneCabinet;
        }

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
