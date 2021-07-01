using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Client.ModelClientForViews;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChanterelleProject.ClientServices.Mappers
{
    internal static class ClientMapper
    {
        internal static UtilisateurViewClient ToUtilisateurViewClient(this UtilisateurViewGlobal utilisateurViewGlobal)
        {
            return new UtilisateurViewClient(
                utilisateurViewGlobal.Id,
                utilisateurViewGlobal.Nom,
                utilisateurViewGlobal.Prenom,
                utilisateurViewGlobal.Adresse,
                utilisateurViewGlobal.DateNaissance,
                utilisateurViewGlobal.RegistreNational,
                utilisateurViewGlobal.Sexe,
                utilisateurViewGlobal.DateDerniereModif,
                utilisateurViewGlobal.DateDebutContrat,
                utilisateurViewGlobal.Telephone,
                utilisateurViewGlobal.Mail,
                utilisateurViewGlobal.IntituleTypeUtilisateur,
                utilisateurViewGlobal.NumInami,
                utilisateurViewGlobal.IntituleSpecialisation);
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
                NumInami = paraMedicalClient.NumInami,
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
                Id = 0,
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
        internal static MedecinExterneClient ToMedecinExterneClient(this MedecinExterneGlobal medecinExterneGlobalGlobal)
        {
            return new MedecinExterneClient(
                medecinExterneGlobalGlobal.Id,
                medecinExterneGlobalGlobal.NumInami,
                medecinExterneGlobalGlobal.Nom,
                medecinExterneGlobalGlobal.Prenom,
                medecinExterneGlobalGlobal.Adresse,
                medecinExterneGlobalGlobal.Mail,
                medecinExterneGlobalGlobal.DateNaissance,
                medecinExterneGlobalGlobal.TelephonePerso,
                medecinExterneGlobalGlobal.TelephoneCabinet);
        }
        internal static MedecinExterneGlobal ToMedecinExterneGlobal(this MedecinExterneClient medecinExterneClient)
        {
            return new MedecinExterneGlobal()
            {
                Id = medecinExterneClient.Id,
                NumInami = medecinExterneClient.NumInami,
                Nom = medecinExterneClient.Nom,
                Prenom = medecinExterneClient.Prenom,
                Adresse = medecinExterneClient.Adresse,
                Mail = medecinExterneClient.Mail,
                DateNaissance = medecinExterneClient.DateNaissance,
                TelephonePerso = medecinExterneClient.TelephonePerso,
                TelephoneCabinet = medecinExterneClient.TelephoneCabinet,
            };
        }
        internal static ClasseViewClient ToClasseViewClient(this ClasseViewGlobal classeViewGlobal)
        {
            return new ClasseViewClient(
                classeViewGlobal.Id,
                classeViewGlobal.IntituleClasse,
                classeViewGlobal.NbEleveMax,
                classeViewGlobal.NomTitulaire);
        }
        internal static ClasseGlobal ToClasseGlobal(this ClasseClient classeClient)
        {
            return new ClasseGlobal()
            {
                IntituleClasse = classeClient.IntituleClasse,
                NbEleveMax = classeClient.NbEleveMax,
                Utilisateur_Id = classeClient.Utilisateur_Id
            };
        }
        internal static AllocationParaMedicalsViewClient ToAllocationParaMedicalsViewClient(this AllocationParaMedicalsViewGlobal allocationParaMedicalsViewGlobal)
        {
            return new AllocationParaMedicalsViewClient(
                allocationParaMedicalsViewGlobal.Id,
                allocationParaMedicalsViewGlobal.DateDebut,
                allocationParaMedicalsViewGlobal.NomClasse,
                allocationParaMedicalsViewGlobal.NomParaMedical);
        }
        internal static AllocationParaMedicalsGlobal ToAllocationParaMedicalsGlobal(this AllocationParaMedicalsClient allocationParaMedicalsClient)
        {
            return new AllocationParaMedicalsGlobal()
            {
                DateDebut = allocationParaMedicalsClient.DateDebut,
                Classe_Id = allocationParaMedicalsClient.Classe_Id,
                ParaMedical_Id = allocationParaMedicalsClient.ParaMedical_Id
            };
        }
        internal static AllocationClassesViewClient ToAllocationClassesViewClient(this AllocationClassesViewGlobal allocationClassesViewGlobal)
        {
            return new AllocationClassesViewClient(
                allocationClassesViewGlobal.Id,
                allocationClassesViewGlobal.DateDebut,
                allocationClassesViewGlobal.NomClasse,
                allocationClassesViewGlobal.NomProfesseur);
        }
        internal static AllocationClassesGlobal ToAllocationClassesGlobal(this AllocationClassesClient allocationClassesClient)
        {
            return new AllocationClassesGlobal()
            {
                DateDebut = allocationClassesClient.DateDebut,
                Classe_Id = allocationClassesClient.Classe_Id,
                Utilisateur_Id = allocationClassesClient.Utilisateur_Id
            };
        }
        internal static TraitementViewClient ToTraitementViewClient(this TraitementViewGlobal traitementViewGlobal)
        {
            return new TraitementViewClient(
                traitementViewGlobal.Id,
                traitementViewGlobal.NomMedicament,
                traitementViewGlobal.Posologie,
                traitementViewGlobal.DateDebut,
                traitementViewGlobal.DateFin,
                traitementViewGlobal.Objectif,
                traitementViewGlobal.TargetPrescriptionMedical,
                traitementViewGlobal.NomCreateur,
                traitementViewGlobal.NomEleve);
        }
        internal static TraitementGlobal ToTraitementGlobal(this TraitementClient traitementClient)
        {
            return new TraitementGlobal()
            {
                Id = traitementClient.Id,
                NomMedicament = traitementClient.NomMedicament,
                Posologie = traitementClient.Posologie,
                DateDebut = traitementClient.DateDebut,
                DateFin = traitementClient.DateFin,
                Objectif = traitementClient.Objectif,
                TargetPrescriptionMedical = traitementClient.TargetPrescriptionMedical,
                Utilisateur_Id = traitementClient.Utilisateur_Id,
                Eleve_Id = traitementClient.Eleve_Id
            };
        }
        internal static EleveViewClient ToEleveViewClient(this EleveViewGlobal eleveViewGlobal)
        {
            return new EleveViewClient(
                eleveViewGlobal.Id,
                eleveViewGlobal.Nom,
                eleveViewGlobal.Prenom,
                eleveViewGlobal.Adresse,
                eleveViewGlobal.DateNaissance,
                eleveViewGlobal.RegistreNational,
                eleveViewGlobal.Sexe,
                eleveViewGlobal.DateDerniereModif,
                eleveViewGlobal.DateInscription,
                eleveViewGlobal.NomMedecinExterne,
                eleveViewGlobal.NomClasse,
                eleveViewGlobal.TraitementsAdministres.Select(x => x.ToTraitementViewClient()) // Appel de la méthode ToTraitementViewClient afin de mapper la liste de TraitementViewGlobal vers traitementViewCLient
                ) ;
        }
        internal static EleveGlobal ToEleveGlobal(this EleveClient eleveClient)
        {
            return new EleveGlobal()
            {
                Id = eleveClient.Id,
                Nom = eleveClient.Nom,
                Prenom = eleveClient.Prenom,
                Adresse = eleveClient.Adresse,
                DateNaissance = eleveClient.DateNaissance,
                RegistreNational = eleveClient.RegistreNational,
                Sexe = eleveClient.Sexe,
                MedecinExterne_Id = eleveClient.MedecinExterne_Id,
                Classe_Id=eleveClient.Classe_Id
            };
        }
    }
}

