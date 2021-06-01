using ChanterelleProject.Models.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChanterelleProject.GlobalServices.Mappers
{
    public static class DataRecordExtensions
    {
        internal static Utilisateur ToUtilisateur(this IDataRecord dataRecord)
        {
            return new Utilisateur()
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
                TypeUtilisateur_Id = Convert.ToInt32(dataRecord["TypeUtilisateur"]),
                MotDePasse = Convert.ToString(dataRecord["MotDePasse"]),
                NumInami = dataRecord["NumInami"] is DBNull ? null : Convert.ToString(dataRecord["NumInami"]),
                SpecialisationId = dataRecord["SpecialisationId"] is DBNull ? 0 : Convert.ToInt32(dataRecord["SpecialisationId"])
            };
        }
    }
}
