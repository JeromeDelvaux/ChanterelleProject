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
        internal static UtilisateurViewGlobal ToUtilisateurViewGlobal(this IDataRecord dataRecord)
        {
            return new UtilisateurViewGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                Nom = Convert.ToString(dataRecord["Nom"]),
                Prenom = Convert.ToString(dataRecord["Prenom"]),
                Adresse = Convert.ToString(dataRecord["Adresse"]),
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
        internal static MedecinExterneGlobal ToMedecinExterneGlobal(this IDataRecord dataRecord)
        {
            return new MedecinExterneGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                NumInami = dataRecord["NumInami"] is DBNull ? null : Convert.ToString(dataRecord["NumInami"]),
                Nom = Convert.ToString(dataRecord["Nom"]),
                Prenom = Convert.ToString(dataRecord["Prenom"]),
                Adresse = Convert.ToString(dataRecord["Adresse"]),
                Mail = dataRecord["Mail"] is DBNull ? null : Convert.ToString(dataRecord["Mail"]),
                DateNaissance = Convert.ToDateTime(dataRecord["DateNaissance"]),
                TelephonePerso = dataRecord["TelephonePerso"] is DBNull ? null : Convert.ToString(dataRecord["TelephonePerso"]),
                TelephoneCabinet = Convert.ToString(dataRecord["TelephoneCabinet"]),
            };
        }
        internal static ClasseViewGlobal ToClasseViewGlobal(this IDataRecord dataRecord)
        {
            return new ClasseViewGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                IntituleClasse= Convert.ToString(dataRecord["IntituleClasse"]),
                NbEleveMax= Convert.ToInt32(dataRecord["NbEleveMax"]),
                NomTitulaire=Convert.ToString(dataRecord["Nom"])
            };
        }
        internal static AllocationParaMedicalsViewGlobal ToAllocationParaMedicalsViewGlobal(this IDataRecord dataRecord)
        {
            return new AllocationParaMedicalsViewGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                DateDebut = Convert.ToDateTime(dataRecord["DateDebut"]),
                NomClasse = Convert.ToString(dataRecord["IntituleClasse"]),
                NomParaMedical= Convert.ToString(dataRecord["Nom"])
            };
        }
        internal static AllocationClassesViewGlobal ToAllocationClassesViewGlobal(this IDataRecord dataRecord)
        {
            return new AllocationClassesViewGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                DateDebut = Convert.ToDateTime(dataRecord["DateDebut"]),
                DateFin = dataRecord["DateFin"] is DBNull ? null : Convert.ToDateTime(dataRecord["DateFin"]),
                NomClasse = Convert.ToString(dataRecord["IntituleClasse"]),
                NomProfesseur = Convert.ToString(dataRecord["Nom"])
            };
        }
        internal static TraitementViewGlobal ToTraitementViewGlobal(this IDataRecord dataRecord)
        {
            return new TraitementViewGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                NomMedicament= Convert.ToString(dataRecord["NomMedicament"]),
                Posologie = Convert.ToString(dataRecord["Posologie"]),
                DateDebut = Convert.ToDateTime(dataRecord["DateDebut"]),
                DateFin= dataRecord["DateFin"] is DBNull ? null : Convert.ToDateTime(dataRecord["DateFin"]),
                Objectif= Convert.ToString(dataRecord["Objectif"]),
                TargetPrescriptionMedical= Convert.ToString(dataRecord["TargetPrescriptionMedical"]),
                NomCreateur= Convert.ToString(dataRecord["NomCreateur"]),
                NomEleve = Convert.ToString(dataRecord["NomEleve"])
            };
        }
        internal static EleveViewGlobal ToEleveViewGlobal(this IDataRecord dataRecord)
        {
            return new EleveViewGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                Nom = Convert.ToString(dataRecord["Nom"]),
                Prenom = Convert.ToString(dataRecord["Prenom"]),
                Adresse = Convert.ToString(dataRecord["Adresse"]),
                DateNaissance = Convert.ToDateTime(dataRecord["DateNaissance"]),
                RegistreNational = Convert.ToString(dataRecord["RegistreNational"]),
                Sexe = Convert.ToString(dataRecord["Sexe"]),
                DateDerniereModif = Convert.ToDateTime(dataRecord["DateDerniereModif"]),
                DateInscription = Convert.ToDateTime(dataRecord["DateDebut"]),
                NomMedecinExterne = Convert.ToString(dataRecord["NomMedecinExterne"]),
                NomClasse = Convert.ToString(dataRecord["NomClasse"])
            };
        }
        internal static InscriptionViewGlobal ToInscriptionViewGlobal(this IDataRecord dataRecord)
        {
            return new InscriptionViewGlobal()
            {
                Id = Convert.ToInt32(dataRecord["Id"]),
                DateDebut = Convert.ToDateTime(dataRecord["DateDebut"]),
                DateFin = dataRecord["DateFin"] is DBNull ? null : Convert.ToDateTime(dataRecord["DateFin"]),
                NomEleve= Convert.ToString(dataRecord["NomEleve"]),
                NomCreateur = Convert.ToString(dataRecord["NomCreateur"])
            };
        }
    }
}
