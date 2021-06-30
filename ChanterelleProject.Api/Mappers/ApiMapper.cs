using ChanterelleProject.Api.Forms;
using ChanterelleProject.Models.Client;
using System;

namespace ChanterelleProject.Api.Mappers
{
    internal static class ApiMapper
    {
        internal static UtilisateurClient ToUtilisateursClient(this FormsCreateUtilisateur formsCreateUtilisateur)
        {
            return new UtilisateurClient(
                0,
                formsCreateUtilisateur.Nom,
                formsCreateUtilisateur.Prenom,
                formsCreateUtilisateur.Adresse,
                formsCreateUtilisateur.DateNaissance,
                formsCreateUtilisateur.RegistreNational,
                formsCreateUtilisateur.Sexe,
                formsCreateUtilisateur.DateDebutContrat,
                formsCreateUtilisateur.Telephone,
                formsCreateUtilisateur.Mail,
                formsCreateUtilisateur.TypeUtilisateur_Id,
                formsCreateUtilisateur.MotDePasse);
        }
        internal static UtilisateurClient ToUtilisateursClient(this FormsUpdateUtilisateur formsUpdateUtilisateur)
        {
            return new UtilisateurClient(
                0,
                formsUpdateUtilisateur.Nom,
                formsUpdateUtilisateur.Prenom,
                formsUpdateUtilisateur.Adresse,
                formsUpdateUtilisateur.DateNaissance,
                formsUpdateUtilisateur.RegistreNational,
                formsUpdateUtilisateur.Sexe,
                formsUpdateUtilisateur.DateDebutContrat,
                formsUpdateUtilisateur.Telephone,
                formsUpdateUtilisateur.Mail,
                formsUpdateUtilisateur.TypeUtilisateur_Id,
                formsUpdateUtilisateur.MotDePasse);
        }
        internal static ParaMedicalClient ToParaMedicalClient(this FormsCreateParaMedical formsCreateParaMedical)
        {
            return new ParaMedicalClient(
                0,
                formsCreateParaMedical.Nom,
                formsCreateParaMedical.Prenom,
                formsCreateParaMedical.Adresse,
                formsCreateParaMedical.DateNaissance,
                formsCreateParaMedical.RegistreNational,
                formsCreateParaMedical.Sexe,
                formsCreateParaMedical.DateDebutContrat,
                formsCreateParaMedical.Telephone,
                formsCreateParaMedical.Mail,
                formsCreateParaMedical.TypeUtilisateur_Id,
                formsCreateParaMedical.MotDePasse,
                formsCreateParaMedical.NumInami,
                formsCreateParaMedical.SpecialisationId);
        }
        internal static ParaMedicalClient ToParaMedicalClient(this FormsUpdateParaMedical formsUpdateParaMedical)
        {
            return new ParaMedicalClient(
                0,
                formsUpdateParaMedical.Nom,
                formsUpdateParaMedical.Prenom,
                formsUpdateParaMedical.Adresse,
                formsUpdateParaMedical.DateNaissance,
                formsUpdateParaMedical.RegistreNational,
                formsUpdateParaMedical.Sexe,
                formsUpdateParaMedical.DateDebutContrat,
                formsUpdateParaMedical.Telephone,
                formsUpdateParaMedical.Mail,
                formsUpdateParaMedical.TypeUtilisateur_Id,
                formsUpdateParaMedical.MotDePasse,
                formsUpdateParaMedical.NumInami,
                formsUpdateParaMedical.SpecialisationId);
        }
        internal static SpecialisationParaMedicalClient ToSpecialisationParaMedicalClient(this FormsCreateSpecialisationParaMedical formsCreateSpecialisationParaMedical)
        {
            return new SpecialisationParaMedicalClient(
                0,
                formsCreateSpecialisationParaMedical.IntituleSpecialisation);
        }
        internal static SpecialisationParaMedicalClient ToSpecialisationParaMedicalClient(this FormsUpdateSpecialisationParaMedical formsUpdateSpecialisationParaMedical)
        {
            return new SpecialisationParaMedicalClient(
                0,
                formsUpdateSpecialisationParaMedical.IntituleSpecialisation);
        }
        internal static TypeUtilisateurClient ToTypeUtilisateurClient(this FormsCreateTypeUtilisateur formsCreateTypeUtilisateur)
        {
            return new TypeUtilisateurClient(
                0,
                formsCreateTypeUtilisateur.IntituleTypeUtilisateur);
        }
        internal static TypeUtilisateurClient ToTypeUtilisateurClient(this FormsUpdateTypeUtilisateur formsUpdateTypeUtilisateur)
        {
            return new TypeUtilisateurClient(
                0,
                formsUpdateTypeUtilisateur.IntituleTypeUtilisateur);
        }
        internal static MedecinExterneClient ToMedecinExterneClient(this FormsCreateMedecinExterne formsCreateMedecinExterne)
        {
            return new MedecinExterneClient(
                0,
                formsCreateMedecinExterne.NumInami,
                formsCreateMedecinExterne.Nom,
                formsCreateMedecinExterne.Prenom,
                formsCreateMedecinExterne.Adresse,
                formsCreateMedecinExterne.Mail,
                formsCreateMedecinExterne.DateNaissance,
                formsCreateMedecinExterne.TelephonePerso,
                formsCreateMedecinExterne.TelephoneCabinet);
        }
        internal static MedecinExterneClient ToMedecinExterneClient(this FormsUpdateMedecinExterne formsUpdateMedecinExterne)
        {
            return new MedecinExterneClient(
                0,
                formsUpdateMedecinExterne.NumInami,
                formsUpdateMedecinExterne.Nom,
                formsUpdateMedecinExterne.Prenom,
                formsUpdateMedecinExterne.Adresse,
                formsUpdateMedecinExterne.Mail,
                formsUpdateMedecinExterne.DateNaissance,
                formsUpdateMedecinExterne.TelephonePerso,
                formsUpdateMedecinExterne.TelephoneCabinet);
        }
        internal static ClasseClient ToClasseClient(this FormsCreateClasse formsCreateClasse)
        {
            return new ClasseClient(
                0,
                formsCreateClasse.IntituleClasse,
                formsCreateClasse.NbEleveMax,
                formsCreateClasse.Utilisateur_Id);
        }
        internal static ClasseClient ToClasseClient(this FormsUpdateClasse formsUpdateClasse)
        {
            return new ClasseClient(
                0,
                formsUpdateClasse.IntituleClasse,
                formsUpdateClasse.NbEleveMax,
                formsUpdateClasse.Utilisateur_Id);
        }
        internal static AllocationParaMedicalsClient ToAllocationParaMedicalsClient(this FormsCreateAllocationParaMedicals formsCreateAllocationParaMedicals)
        {
            return new AllocationParaMedicalsClient(
                0,
                formsCreateAllocationParaMedicals.DateDebut,
                formsCreateAllocationParaMedicals.Class_Id,
                formsCreateAllocationParaMedicals.ParaMedical_Id);
        }
        internal static AllocationParaMedicalsClient ToAllocationParaMedicalsClient(this FormsUpdateAllocationParaMedicals formsUpdateAllocationParaMedicals)
        {
            return new AllocationParaMedicalsClient(
                0,
                new DateTime(),
                formsUpdateAllocationParaMedicals.Class_Id,
                formsUpdateAllocationParaMedicals.ParaMedical_Id);
        }
        internal static AllocationClassesClient ToAllocationClassesClient(this FormsCreateAllocationClasses formsCreateAllocationClasses)
        {
            return new AllocationClassesClient(
                0,
                formsCreateAllocationClasses.DateDebut,
                formsCreateAllocationClasses.Class_Id,
                formsCreateAllocationClasses.Utilisateur_Id);
        }
        internal static AllocationClassesClient ToAllocationClassesClient(this FormsUpdateAllocationClasses formsUpdateAllocationClasses)
        {
            return new AllocationClassesClient(
                0,
                new DateTime(),
                formsUpdateAllocationClasses.Class_Id,
                formsUpdateAllocationClasses.Utilisateur_Id);
        }
    }
}
