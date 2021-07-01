using ChanterelleProject.GlobalServices.InterfacesSpecifiques;
using ChanterelleProject.GlobalServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using ConnectionDataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChanterelleProject.GlobalServices.Services
{
    public class TraitementServicesGlobal : ITraitementSpecifique
    {
        private readonly IConnection _connection;

        public TraitementServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }

        public bool DeleteTraitement(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteTraitement", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public TraitementViewGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetTraitementById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToTraitementViewGlobal()).SingleOrDefault();
        }

        public IEnumerable<TraitementViewGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllTraitement", true);
            return _connection.ExecuteReader(command, sp => sp.ToTraitementViewGlobal());
        }

        public int InsertTraitement(TraitementGlobal entity)
        {
            int? idNewTraitement;

            Commands command = new Commands("SP_ChtlePrj_AddTraitement", true);
            command.AddParameter("DateDebut", entity.NomMedicament);
            command.AddParameter("Posologie", entity.Posologie);
            command.AddParameter("DateDebut", entity.DateDebut);
            command.AddParameter("DateFin", entity.DateFin);
            command.AddParameter("Objectif", entity.Objectif);
            command.AddParameter("TargetPrescriptionMedical", entity.TargetPrescriptionMedical);
            command.AddParameter("Utilisateur_Id", entity.Utilisateur_Id);
            command.AddParameter("Eleve_Id", entity.Eleve_Id);

            idNewTraitement = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewTraitement.Value : -1;
        }

        public bool UpdateTraitement(int key, TraitementGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateTraitement", true);
            command.AddParameter("Id", key);
            command.AddParameter("DateDebut", entity.NomMedicament);
            command.AddParameter("Posologie", entity.Posologie);
            command.AddParameter("DateDebut", entity.DateDebut);
            command.AddParameter("DateFin", entity.DateFin);
            command.AddParameter("Objectif", entity.Objectif);
            command.AddParameter("TargetPrescriptionMedical", entity.TargetPrescriptionMedical);
            command.AddParameter("Utilisateur_Id", entity.Utilisateur_Id);
            command.AddParameter("Eleve_Id", entity.Eleve_Id);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
        public IEnumerable<TraitementViewGlobal> GetAllTraitementByEleveId(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetTraitementByEleveId", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToTraitementViewGlobal());
        }
    }
}

