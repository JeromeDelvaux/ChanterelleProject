using ChanterelleProject.Api.Forms;
using ChanterelleProject.Models.Client;


namespace ChanterelleProject.Api.Mappers
{
    internal static class ApiMapper
    {
        internal static UtilisateurClient ToUtilisateursClient(this FormsCreateUtilisateur utilisateur)
        {
            return new UtilisateurClient(
                utilisateur.Nom,
                utilisateur.Prenom,
                utilisateur.Adresse,
                utilisateur.DateNaissance,
                utilisateur.RegistreNational,
                utilisateur.Sexe,
                utilisateur.DateDebutContrat,
                utilisateur.Telephone,
                utilisateur.Mail,
                utilisateur.TypeUtilisateur_Id,
                utilisateur.MotDePasse);
        }
        internal static UtilisateurClient ToUtilisateursClient(this FormsUpdateUtilisateur utilisateur)
        {
            return new UtilisateurClient(
                utilisateur.Nom,
                utilisateur.Prenom,
                utilisateur.Adresse,
                utilisateur.DateNaissance,
                utilisateur.RegistreNational,
                utilisateur.Sexe,
                utilisateur.DateDebutContrat,
                utilisateur.Telephone,
                utilisateur.Mail,
                utilisateur.TypeUtilisateur_Id,
                utilisateur.MotDePasse);
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
        internal static SpecialisationParaMedicalClient ToSpecialisationParaMedicalClient(this FormsCreateSpecialisationParaMedical specialisationParaMedical)
        {
            return new SpecialisationParaMedicalClient(
                0,
                specialisationParaMedical.IntituleSpecialisation);
        }
        internal static SpecialisationParaMedicalClient ToSpecialisationParaMedicalClient(this FormsUpdateSpecialisationParaMedical specialisationParaMedical)
        {
            return new SpecialisationParaMedicalClient(
                0,
                specialisationParaMedical.IntituleSpecialisation);
        }
    }
}
