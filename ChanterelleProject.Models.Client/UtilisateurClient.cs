﻿using ChanterelleProject.Interfaces;
using System;


namespace ChanterelleProject.Models.Client
{
    public class UtilisateurClient 
    {
        public UtilisateurClient(string nom, string prenom, string adresse, DateTime dateNaissance, string registreNational, string sexe, DateTime dateDebutContrat, string telephone, string mail, int typeUtilisateur_Id, string motDePasse)
        {
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
        }

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
    }
}
