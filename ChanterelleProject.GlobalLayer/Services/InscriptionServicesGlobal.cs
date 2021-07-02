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
    public class InscriptionServicesGlobal : IInscription<int,InscriptionGlobal,InscriptionViewGlobal>
    {
        private readonly IConnection _connection;

        public InscriptionServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }

        public bool DeleteInscription(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteInscription", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public InscriptionViewGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetInscriptionById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToInscriptionViewGlobal()).SingleOrDefault();
        }

        public IEnumerable<InscriptionViewGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllInscription", true);
            return _connection.ExecuteReader(command, sp => sp.ToInscriptionViewGlobal());
        }

        public int InsertInscription(InscriptionGlobal entity)
        {
            int? idNewAllocationClasses;

            Commands command = new Commands("SP_ChtlePrj_AddInscription", true);
            command.AddParameter("DateDebut", entity.DateDebut);
            command.AddParameter("Classe_Id", entity.Eleve_Id);
            command.AddParameter("Utilisateur_Id", entity.Utilisateur_Id);

            idNewAllocationClasses = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewAllocationClasses.Value : -1;
        }

        public bool UpdateInscription(int key, InscriptionGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateInscription", true);
            command.AddParameter("Id", key);
            command.AddParameter("DateDebut", entity.DateDebut);
            command.AddParameter("Classe_Id", entity.Eleve_Id);
            command.AddParameter("Utilisateur_Id", entity.Utilisateur_Id);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
    }
}
