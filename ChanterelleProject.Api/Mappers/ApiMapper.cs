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
        internal static SpecialisationParaMedicalClient ToSpecialisationParaMedicalClient(this FormsCreateSpecialisationParaMedical specialisationParaMedical)
        {
            return new SpecialisationParaMedicalClient(
                0,
                specialisationParaMedical.Intitule);
        }
        internal static SpecialisationParaMedicalClient ToSpecialisationParaMedicalClient(this FormsUpdateSpecialisationParaMedical specialisationParaMedical)
        {
            return new SpecialisationParaMedicalClient(
                0,
                specialisationParaMedical.Intitule);
        }
    }
}
