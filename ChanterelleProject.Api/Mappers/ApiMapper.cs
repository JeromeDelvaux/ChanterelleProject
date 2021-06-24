using ChanterelleProject.Api.Forms;
using ChanterelleProject.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Mappers
{
    internal static class ApiMapper
    {
        internal static UtilisateurClient ToUtilisateursClient(this FormsCreateUtilisateur utilisateur)
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
                utilisateur.MotDePasse);
        }
    }
}
