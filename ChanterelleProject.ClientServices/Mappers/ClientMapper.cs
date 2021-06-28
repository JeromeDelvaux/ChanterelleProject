using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.ClientServices.Mappers
{
    internal static class ClientMapper
    {
        internal static UtilisateurClientFullAttributeForView ToUtilisateurClientFullAttributeForView(this UtilisateurGlobalFullAttributeForView utilisateurGlobalFullAttributeForView)
        {
            return new UtilisateurClientFullAttributeForView(
                utilisateurGlobalFullAttributeForView.Id,
                utilisateurGlobalFullAttributeForView.Nom,
                utilisateurGlobalFullAttributeForView.Prenom,
                utilisateurGlobalFullAttributeForView.Adresse,
                utilisateurGlobalFullAttributeForView.DateNaissance,
                utilisateurGlobalFullAttributeForView.RegistreNational,
                utilisateurGlobalFullAttributeForView.Sexe,
                utilisateurGlobalFullAttributeForView.DateDerniereModif,
                utilisateurGlobalFullAttributeForView.DateDebutContrat,
                utilisateurGlobalFullAttributeForView.Telephone,
                utilisateurGlobalFullAttributeForView.Mail,
                utilisateurGlobalFullAttributeForView.IntituleTypeUtilisateur,
                utilisateurGlobalFullAttributeForView.NumInami,
                utilisateurGlobalFullAttributeForView.IntituleSpecialisation);
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
        internal static ParaMedicalGlobal ToParaMedicalGlobal(this ParaMedicalClient paraMedicalClient)
        {
            return new ParaMedicalGlobal()
            {
                Nom = paraMedicalClient.Nom,
                Prenom = paraMedicalClient.Prenom,
                Adresse = paraMedicalClient.Adresse,
                DateNaissance = paraMedicalClient.DateNaissance,
                RegistreNational = paraMedicalClient.RegistreNational,
                Sexe = paraMedicalClient.Sexe,
                DateDebutContrat = paraMedicalClient.DateDebutContrat,
                Telephone = paraMedicalClient.Telephone,
                Mail = paraMedicalClient.Mail,
                TypeUtilisateur_Id = paraMedicalClient.TypeUtilisateur_Id,
                MotDePasse = paraMedicalClient.MotDePasse,
                NumInami= paraMedicalClient.NumInami,
                SpecialisationId = paraMedicalClient.SpecialisationId
            };
        }
        internal static SpecialisationParaMedicalClient ToSpecialisationParaMedicalClient(this SpecialisationParaMedicalGlobal specialisationParaMedicalGlobal)
        {
            return new SpecialisationParaMedicalClient(
                specialisationParaMedicalGlobal.Id,
                specialisationParaMedicalGlobal.IntituleSpecialisation);
        }
        internal static SpecialisationParaMedicalGlobal ToSpecialisationParaMedicalGlobal(this SpecialisationParaMedicalClient specialisationParaMedicalClient)
        {
            return new SpecialisationParaMedicalGlobal()
            {
                Id= 0,
                IntituleSpecialisation = specialisationParaMedicalClient.IntituleSpecialisation
            };
        }
    }
}

