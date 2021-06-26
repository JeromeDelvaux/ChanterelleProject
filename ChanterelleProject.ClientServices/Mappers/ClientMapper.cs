using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.ClientServices.Mappers
{
    internal static class ClientMapper
    {
        internal static UtilisateurClientFullAttributeForView ToUtilisateurClientFullAttributeForView(this UtilisateurGlobalFullAttributeForView utilisateur)
        {
            return new UtilisateurClientFullAttributeForView(
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
        internal static UtilisateurGlobal ToUtilisateursGlobal(this UtilisateurClient utilisateur)
        {
            return new UtilisateurGlobal()
            { 
                Nom = utilisateur.Nom,
                Prenom = utilisateur.Prenom,
                Adresse = utilisateur.Adresse,
                DateNaissance = utilisateur.DateNaissance,
                RegistreNational = utilisateur.RegistreNational,
                Sexe = utilisateur.Sexe,
                DateDebutContrat = utilisateur.DateDebutContrat,
                Telephone = utilisateur.Telephone,
                Mail = utilisateur.Mail,
                TypeUtilisateur_Id = utilisateur.TypeUtilisateur_Id,
                MotDePasse = utilisateur.MotDePasse
            };
        }
    }
}

