using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChanterelleProject.GlobalServices.Mappers
{
    public static class DataRecordExtensions
    {
        internal static UtilisateurFullAttributeForViewGlobal ToUtilisateurGlobalFullAttributeForView(this IDataRecord dataRecord)
        {
            return new UtilisateurFullAttributeForViewGlobal()
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
                IntituleTypeUtilisateur = Convert.ToString(dataRecord["IntituleTypeUtilisateur"]),
                NumInami = dataRecord["NumInami"] is DBNull ? null : Convert.ToString(dataRecord["NumInami"]),
                IntituleSpecialisation = dataRecord["IntituleSpecialisation"] is DBNull ? null : Convert.ToString(dataRecord["IntituleSpecialisation"])
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
        internal static SpecialisationParaMedicalGlobal ToSpecialisationParaMedicalGlobal(this IDataRecord dataRecord)
        {
            return new SpecialisationParaMedicalGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                IntituleSpecialisation = Convert.ToString(dataRecord["IntituleSpecialisation"]),
            };
        }
        internal static TypeUtilisateurGlobal ToTypeUtilisateurGlobal(this IDataRecord dataRecord)
        {
            return new TypeUtilisateurGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                IntituleTypeUtilisateur = Convert.ToString(dataRecord["IntituleTypeUtilisateur"]),
            };
        }
    }
}
