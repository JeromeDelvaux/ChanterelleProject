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

        public Traitement Get(int key, int eleveId)
        {
            Commands command = new Commands("SP_ChtlePrj_GetTraitement", true);
            command.AddParameter("@Id", key);
            command.AddParameter("@idEleve", eleveId);
            
            return _connection.ExecuteReader(command, sp => sp.ToTraitement()).SingleOrDefault();
        }

        public IEnumerable<Traitement> GetAll(int eleveId)
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllTraitementForOneEleve", true);
            command.AddParameter("@idEleve", eleveId);

            return _connection.ExecuteReader(command, sp => sp.ToTraitement());
        }

        public int Insert(Traitement entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int key, Traitement entity)
        {
            throw new NotImplementedException();
        }
    }
}
