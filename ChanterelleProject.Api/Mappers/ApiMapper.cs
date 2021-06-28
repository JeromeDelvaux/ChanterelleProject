using ChanterelleProject.Api.Forms;
using ChanterelleProject.Models.Client;


namespace ChanterelleProject.Api.Mappers
{
    internal static class ApiMapper
    {
        internal static UtilisateurClient ToUtilisateursClient(this FormsCreateUtilisateur formsCreateUtilisateur)
        {
            return new UtilisateurClient(
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
    }
}
