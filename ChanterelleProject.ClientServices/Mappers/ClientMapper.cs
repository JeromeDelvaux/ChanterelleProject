﻿using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.ClientServices.Mappers
{
    internal static class ClientMapper
    {
        internal static UtilisateurClient ToUtilisateursCLient(this Utilisateur utilisateur)
        {
            return new UtilisateurClient(
                utilisateur.Id,
                utilisateur.Nom,
                utilisateur.Prenom,
                utilisateur.Adresse,
                utilisateur.DateNaissance,
                utilisateur.RegistreNational,
                utilisateur.Sexe,
                utilisateur.DateDerniereModif,
                utilisateur.DateDebutContrat,
                utilisateur.Telephone,
                utilisateur.Mail,
                utilisateur.TypeUtilisateur_Id,
                utilisateur.MotDePasse,
                utilisateur.NumInami,
                utilisateur.SpecialisationId);
        }
        internal static Utilisateur ToUtilisateursGlobal(this UtilisateurClient utilisateur)
        {
            return new Utilisateur()
            {
                Id = utilisateur.Id,
                Nom = utilisateur.Nom,
                Prenom = utilisateur.Prenom,
                Adresse = utilisateur.Adresse,
                DateNaissance = utilisateur.DateNaissance,
                RegistreNational = utilisateur.RegistreNational,
                Sexe = utilisateur.Sexe,
                DateDerniereModif = utilisateur.DateDerniereModif,
                DateDebutContrat = utilisateur.DateDebutContrat,
                Telephone = utilisateur.Telephone,
                Mail = utilisateur.Mail,
                TypeUtilisateur_Id = utilisateur.TypeUtilisateur_Id,
                MotDePasse = utilisateur.MotDePasse,
                NumInami = utilisateur.NumInami,
                SpecialisationId = utilisateur.SpecialisationId
            };
        }
    }
}
