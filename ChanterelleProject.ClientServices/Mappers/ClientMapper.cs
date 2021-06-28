﻿using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.ClientServices.Mappers
{
    internal static class ClientMapper
    {
        internal static UtilisateurFullAttributeForViewClient ToUtilisateurClientFullAttributeForView(this UtilisateurFullAttributeForViewGlobal utilisateurFullAttributeForViewGlobal)
        {
            return new UtilisateurFullAttributeForViewClient(
                utilisateurFullAttributeForViewGlobal.Id,
                utilisateurFullAttributeForViewGlobal.Nom,
                utilisateurFullAttributeForViewGlobal.Prenom,
                utilisateurFullAttributeForViewGlobal.Adresse,
                utilisateurFullAttributeForViewGlobal.DateNaissance,
                utilisateurFullAttributeForViewGlobal.RegistreNational,
                utilisateurFullAttributeForViewGlobal.Sexe,
                utilisateurFullAttributeForViewGlobal.DateDerniereModif,
                utilisateurFullAttributeForViewGlobal.DateDebutContrat,
                utilisateurFullAttributeForViewGlobal.Telephone,
                utilisateurFullAttributeForViewGlobal.Mail,
                utilisateurFullAttributeForViewGlobal.IntituleTypeUtilisateur,
                utilisateurFullAttributeForViewGlobal.NumInami,
                utilisateurFullAttributeForViewGlobal.IntituleSpecialisation);
        }
        internal static UtilisateurGlobal ToUtilisateursGlobal(this UtilisateurClient utilisateurClient)
        {
            return new UtilisateurGlobal()
            { 
                Nom = utilisateurClient.Nom,
                Prenom = utilisateurClient.Prenom,
                Adresse = utilisateurClient.Adresse,
                DateNaissance = utilisateurClient.DateNaissance,
                RegistreNational = utilisateurClient.RegistreNational,
                Sexe = utilisateurClient.Sexe,
                DateDebutContrat = utilisateurClient.DateDebutContrat,
                Telephone = utilisateurClient.Telephone,
                Mail = utilisateurClient.Mail,
                TypeUtilisateur_Id = utilisateurClient.TypeUtilisateur_Id,
                MotDePasse = utilisateurClient.MotDePasse
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
        internal static TypeUtilisateurClient ToTypeUtilisateurClient(this TypeUtilisateurGlobal typeUtilisateurGlobal)
        {
            return new TypeUtilisateurClient(
                typeUtilisateurGlobal.Id,
                typeUtilisateurGlobal.IntituleTypeUtilisateur);
        }
        internal static TypeUtilisateurGlobal ToTypeUtilisateurGlobal(this TypeUtilisateurClient typeUtilisateurClient)
        {
            return new TypeUtilisateurGlobal()
            {
                Id = 0,
                IntituleTypeUtilisateur = typeUtilisateurClient.IntituleTypeUtilisateur
            };
        }
    }
}

