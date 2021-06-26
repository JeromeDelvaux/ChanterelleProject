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
    public class SpecialisationParaMedicalServicesGlobal : ISpecialisationParaMedical<int, SpecialisationParaMedicalGlobal>
    {
        private readonly IConnection _connection;

        public SpecialisationParaMedicalServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }

        public bool Delete(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteSpecialisationParaMedical", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public SpecialisationParaMedicalGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetSpecialisationParaMedicalById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToSpecialisationParaMedicalGlobal()).SingleOrDefault();
        }

        public IEnumerable<SpecialisationParaMedicalGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllSpecialisationParaMedical", true);
            return _connection.ExecuteReader(command, sp => sp.ToSpecialisationParaMedicalGlobal());
        }

        public int Insert(SpecialisationParaMedicalGlobal entity)
        {
            int? idNewSpecialisationParaMedicalGlobal;

            Commands command = new Commands("SP_ChtlePrj_AddSpecialisationParaMedicalGlobal", true);
            command.AddParameter("Intitule", entity.Intitule);

            idNewSpecialisationParaMedicalGlobal = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewSpecialisationParaMedicalGlobal.Value : -1;
        }

        public bool Update(int key, SpecialisationParaMedicalGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateSpecialisationParaMedicalGlobal", true);
            command.AddParameter("Id", key);
            command.AddParameter("Nom", entity.Intitule);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
    }
}
