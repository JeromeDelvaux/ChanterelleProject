using ChanterelleProject.GlobalServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Global;
using ConnectionDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChanterelleProject.GlobalServices.Services
{
    public class TypeUtilisateurServicesGlobal : IServices<int, TypeUtilisateurGlobal>
    {
        private readonly IConnection _connection;

        public TypeUtilisateurServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }
        public bool Delete(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteTypeUtilisateur", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public TypeUtilisateurGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetTypeUtilisateurById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToTypeUtilisateurGlobal()).SingleOrDefault();
        }

        public IEnumerable<TypeUtilisateurGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllTypeUtilisateur", true);
            return _connection.ExecuteReader(command, sp => sp.ToTypeUtilisateurGlobal());
        }

        public int Insert(TypeUtilisateurGlobal entity)
        {
            int? idNewSpecialisationParaMedicalGlobal;

            Commands command = new Commands("SP_ChtlePrj_AddTypeUtilisateur", true);
            command.AddParameter("IntituleTypeUtilisateur", entity.IntituleTypeUtilisateur);

            idNewSpecialisationParaMedicalGlobal = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewSpecialisationParaMedicalGlobal.Value : -1;
        }

        public bool Update(int key, TypeUtilisateurGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateTypeUtilisateur", true);
            command.AddParameter("Id", key);
            command.AddParameter("IntituleTypeUtilisateur", entity.IntituleTypeUtilisateur);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
    }
}
