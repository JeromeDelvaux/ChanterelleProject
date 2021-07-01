using ChanterelleProject.GlobalServices.InterfacesSpecifiques;
using ChanterelleProject.GlobalServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using ConnectionDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChanterelleProject.GlobalServices.Services
{
    public class EleveServicesGlobal : IEleve<int, EleveGlobal, EleveViewGlobal>
    {
        private readonly IConnection _connection;
        private readonly ITraitementSpecifique _traitementServicesGlobal;

        public EleveServicesGlobal(IConnection connection, ITraitementSpecifique traitementServicesGlobal)
        {
            _connection = connection;
            _traitementServicesGlobal = traitementServicesGlobal;
        }
        public bool DeleteEleve(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteEleve", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }
        public EleveViewGlobal Get(int key)
        {
            EleveViewGlobal eleveViewGlobal = new EleveViewGlobal();

            Commands command = new Commands("SP_ChtlePrj_GetEleveById", true);
            command.AddParameter("@Id", key);
            
            eleveViewGlobal= _connection.ExecuteReader(command, sp => sp.ToEleveViewGlobal()).SingleOrDefault();
            eleveViewGlobal.TraitementsAdministres = _traitementServicesGlobal.GetAllTraitementByEleveId(key); // Remplissage d'une liste avec tous les traitements liés à l'élèves

            return eleveViewGlobal;
        }
        public IEnumerable<EleveViewGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllEleve", true);
            return _connection.ExecuteReader(command, sp => sp.ToEleveViewGlobal());
        }
        public int InsertEleve(EleveGlobal entity)
        {
            int? idNewAllocationClasses;

            Commands command = new Commands("SP_ChtlePrj_AddEleve", true);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Adresse", entity.Adresse);
            command.AddParameter("DateNaissance", entity.DateNaissance);
            command.AddParameter("RegistreNational", entity.RegistreNational);
            command.AddParameter("Sexe", entity.Sexe);
            command.AddParameter("Classe_Id", entity.Classe_Id);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("MedecinExterne_Id", entity.MedecinExterne_Id);

            idNewAllocationClasses = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewAllocationClasses.Value : -1;
        }
        public bool UpdateEleve(int key, EleveGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateEleve", true);
            command.AddParameter("Id", key);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Adresse", entity.Adresse);
            command.AddParameter("DateNaissance", entity.DateNaissance);
            command.AddParameter("RegistreNational", entity.RegistreNational);
            command.AddParameter("Sexe", entity.Sexe);
            command.AddParameter("Classe_Id", entity.Classe_Id);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("MedecinExterne_Id", entity.MedecinExterne_Id);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
    }
}
