using ChanterelleProject.Models.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChanterelleProject.GlobalServices.Mappers
{
    public static class DataRecordExtensions
    {
        internal static UtilisateurGlobal ToUtilisateur(this IDataRecord dataRecord)
        {
            return new UtilisateurGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                Nom = Convert.ToString(dataRecord["Nom"]),
                Prenom = Convert.ToString(dataRecord["Prenom"]),
                Adresse = Convert.ToString(dataRecord["Adressse"]),
                DateNaissance = Convert.ToDateTime(dataRecord["DateNaissance"]),
                RegistreNational = Convert.ToString(dataRecord["RegistreNational"]),
                Sexe = Convert.ToString(dataRecord["Sexe"]),
                DateDerniereModif = Convert.ToDateTime(dataRecord["DateDerniereModif"]),
                DateDebutContrat = Convert.ToDateTime(dataRecord["DateDebutContrat"]),
                Telephone = Convert.ToString(dataRecord["Telephone"]),
                Mail = Convert.ToString(dataRecord["Mail"]),
                TypeUtilisateur_Id = Convert.ToInt32(dataRecord["TypeUtilisateur_Id"]),
            };
        }
        internal static UtilisateurGlobalView ToUtilisateurView(this IDataRecord dataRecord)
        {
            return new UtilisateurGlobalView()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                Nom = Convert.ToString(dataRecord["Nom"]),
                Prenom = Convert.ToString(dataRecord["Prenom"]),
                Adresse = Convert.ToString(dataRecord["Adressse"]),
                DateNaissance = Convert.ToDateTime(dataRecord["DateNaissance"]),
                RegistreNational = Convert.ToString(dataRecord["RegistreNational"]),
                Sexe = Convert.ToString(dataRecord["Sexe"]),
                DateDerniereModif = Convert.ToDateTime(dataRecord["DateDerniereModif"]),
                DateDebutContrat = Convert.ToDateTime(dataRecord["DateDebutContrat"]),
                Telephone = Convert.ToString(dataRecord["Telephone"]),
                Mail = Convert.ToString(dataRecord["Mail"]),
                TypeUtilisateur_Id = Convert.ToInt32(dataRecord["TypeUtilisateur_Id"]),
                NumInami = dataRecord["NumInami"] is DBNull ? null : Convert.ToString(dataRecord["NumInami"]),
                SpecialisationId = dataRecord["Specialisation_Id"] is DBNull ? 0 : Convert.ToInt32(dataRecord["Specialisation_Id"])
            };
        }
        internal static TraitementGlobal ToTraitement(this IDataRecord dataRecord)
        {
            return new TraitementGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                NomMedicament = Convert.ToString(dataRecord["NomMedicament"]),
                Posologie = Convert.ToString(dataRecord["Posologie"]),
                DateDebut = Convert.ToDateTime(dataRecord["DateDebut"]),
                DateFin = Convert.ToDateTime(dataRecord["DateFin"]),
                NomCreateur = Convert.ToString(dataRecord["NomCreateur"]),
                Objectif = Convert.ToString(dataRecord["Objectif"]),
                actif = Convert.ToBoolean(dataRecord["actif"]),
                TargetPieceJointe = Convert.ToString(dataRecord["TargetPieceJointe"]),
                Utilisateur_Id = Convert.ToInt32(dataRecord["Utilisateur_Id"]),
                Eleve_Id = Convert.ToInt32(dataRecord["Eleve_Id"]),
               };
        }
    }
}
