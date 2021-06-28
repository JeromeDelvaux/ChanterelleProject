﻿using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class UtilisateurFullAttributeForViewClient : IEntity<int>
    {
        public UtilisateurFullAttributeForViewClient(int id, string nom, string prenom, string adresse, DateTime dateNaissance, string registreNational, string sexe, DateTime dateDerniereModif, DateTime dateDebutContrat, string telephone, string mail, string intituleTypeUtilisateur, string numInami, string intituleSpecialisation)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            DateNaissance = dateNaissance;
            RegistreNational = registreNational;
            Sexe = sexe;
            DateDerniereModif = dateDerniereModif;
            DateDebutContrat = dateDebutContrat;
            Telephone = telephone;
            Mail = mail;
            IntituleTypeUtilisateur = intituleTypeUtilisateur;
            NumInami = numInami;
            IntituleSpecialisation = intituleSpecialisation;
        }

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
        public string IntituleTypeUtilisateur { get; set; }
        public string NumInami { get; set; }
        public string IntituleSpecialisation { get; set; }
    }
}