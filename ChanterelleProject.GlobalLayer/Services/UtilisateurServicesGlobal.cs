using ChanterelleProject.GlobalServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using ConnectionDataBase;
using System.Collections.Generic;
using System.Linq;

namespace ChanterelleProject.GlobalServices.Services
{
    public class UtilisateurServicesGlobal : IUtilisateur<int, UtilisateurGlobal,UtilisateurViewGlobal, ParaMedicalGlobal>
    {
        private readonly IConnection _connection;
       
        public UtilisateurServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }

        public bool DeleteUtilisateur(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteUtilisateur", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public UtilisateurViewGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetUtilisateursById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToUtilisateurViewGlobal()).SingleOrDefault();
        }

        public IEnumerable<UtilisateurViewGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllUtilisateurs", true);
            return _connection.ExecuteReader(command, sp => sp.ToUtilisateurViewGlobal());
        }

        public int InsertParaMedical(ParaMedicalGlobal entity)
        {
            int? idNewUtilisateur;

            Commands command = new Commands("SP_ChtlePrj_AddParaMedical", true);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Adresse", entity.Adresse);
            command.AddParameter("DateNaissance", entity.DateNaissance);
            command.AddParameter("RegistreNational", entity.RegistreNational);
            command.AddParameter("Sexe", entity.Sexe);
            command.AddParameter("DateDebutContrat", entity.DateDebutContrat);
            command.AddParameter("Telephone", entity.Telephone);
            command.AddParameter("Mail", entity.Mail);
            command.AddParameter("TypeUtilisateurId", entity.TypeUtilisateur_Id);
            command.AddParameter("MotDePasse", entity.MotDePasse);
            command.AddParameter("NumInami", entity.NumInami);
            command.AddParameter("SpecialisationId", entity.SpecialisationId);

            idNewUtilisateur = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewUtilisateur.Value : -1;
        }

        public int InsertUtilisateur(Models.Global.UtilisateurGlobal entity)
        {
            int? idNewUtilisateur;

            Commands command = new Commands("SP_ChtlePrj_AddUtilisateur", true);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Adresse", entity.Adresse);
            command.AddParameter("DateNaissance", entity.DateNaissance);
            command.AddParameter("RegistreNational", entity.RegistreNational);
            command.AddParameter("Sexe", entity.Sexe);
            command.AddParameter("DateDebutContrat", entity.DateDebutContrat);
            command.AddParameter("Telephone", entity.Telephone);
            command.AddParameter("Mail", entity.Mail);
            command.AddParameter("TypeUtilisateurId", entity.TypeUtilisateur_Id);
            command.AddParameter("MotDePasse", entity.MotDePasse);

            idNewUtilisateur = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewUtilisateur.Value : -1;
        }

        public bool UpdateParaMedical(int key, ParaMedicalGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateParaMedical", true);
            command.AddParameter("Id", key);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Adresse", entity.Adresse);
            command.AddParameter("DateNaissance", entity.DateNaissance);
            command.AddParameter("RegistreNational", entity.RegistreNational);
            command.AddParameter("Sexe", entity.Sexe);
            command.AddParameter("DateDebutContrat", entity.DateDebutContrat);
            command.AddParameter("Telephone", entity.Telephone);
            command.AddParameter("Mail", entity.Mail);
            command.AddParameter("TypeUtilisateurId", entity.TypeUtilisateur_Id);
            command.AddParameter("MotDePasse", entity.MotDePasse);
            command.AddParameter("NumInami", entity.NumInami);
            command.AddParameter("SpecialisationId", entity.SpecialisationId);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }

        public bool UpdateUtilisateur(int key, Models.Global.UtilisateurGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateUtilisateur", true);
            command.AddParameter("Id", key);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Adresse", entity.Adresse);
            command.AddParameter("DateNaissance", entity.DateNaissance);
            command.AddParameter("RegistreNational", entity.RegistreNational);
            command.AddParameter("Sexe", entity.Sexe);
            command.AddParameter("DateDebutContrat", entity.DateDebutContrat);
            command.AddParameter("Telephone", entity.Telephone);
            command.AddParameter("Mail", entity.Mail);
            command.AddParameter("TypeUtilisateurId", entity.TypeUtilisateur_Id);
            command.AddParameter("MotDePasse", entity.MotDePasse);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }

        public UtilisateurViewGlobal LoginUtilisateur(string email, string password)
        {
            Commands command = new Commands("SP_ChtlePrj_CheckPassword", true);
            command.AddParameter("@MotDePasse", password);
            command.AddParameter("@identifiant", email);

            password = null; //remise a null pour la sécurité du password avant le passage de garbage collector

            return _connection.ExecuteReader(command, sp => sp.ToUtilisateurViewGlobal()).SingleOrDefault();
        }
    }
}
