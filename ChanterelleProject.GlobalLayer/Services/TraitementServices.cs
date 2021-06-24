using ChanterelleProject.GlobalServices.Mappers;
using ChanterelleProject.Models.Global;
using ConnectionDataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChanterelleProject.GlobalServices.Services
{
    public class TraitementServices 
    {
        private readonly IConnection _connection;

        public TraitementServices(IConnection connection)
        {
            _connection = connection;
        }
        public bool Delete(int key)
        {

            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteTraitement", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;

        }

        public TraitementGlobal Get(int key, int eleveId)
        {
            Commands command = new Commands("SP_ChtlePrj_GetTraitement", true);
            command.AddParameter("@Id", key);
            command.AddParameter("@idEleve", eleveId);
            
            return _connection.ExecuteReader(command, sp => sp.ToTraitement()).SingleOrDefault();
        }

        public IEnumerable<TraitementGlobal> GetAll(int eleveId)
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllTraitementForOneEleve", true);
            command.AddParameter("@idEleve", eleveId);

            return _connection.ExecuteReader(command, sp => sp.ToTraitement());
        }

        public int Insert(TraitementGlobal entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int key, TraitementGlobal entity)
        {
            throw new NotImplementedException();
        }
    }
}
