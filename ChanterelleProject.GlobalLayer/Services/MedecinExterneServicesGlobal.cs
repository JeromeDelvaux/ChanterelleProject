using ChanterelleProject.GlobalServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Global;
using ConnectionDataBase;
using System.Collections.Generic;
using System.Linq;

namespace ChanterelleProject.GlobalServices.Services
{
    public class MedecinExterneServicesGlobal : IServices<int, MedecinExterneGlobal>
    {
        private readonly IConnection _connection;

        public MedecinExterneServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }
        public bool Delete(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteMedecinExterne", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public MedecinExterneGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetMedecinExterneById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToMedecinExterneGlobal()).SingleOrDefault();
        }

        public IEnumerable<MedecinExterneGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllMedecinExterne", true);
            return _connection.ExecuteReader(command, sp => sp.ToMedecinExterneGlobal());
        }

        public int Insert(MedecinExterneGlobal entity)
        {
            int? idNewMedecin;

            Commands command = new Commands("SP_ChtlePrj_AddMedecinExterne", true);
            command.AddParameter("NumInami", entity.NumInami);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Adresse", entity.Adresse);
            command.AddParameter("Mail", entity.Mail);
            command.AddParameter("DateNaissance", entity.DateNaissance);
            command.AddParameter("TelephonePerso", entity.TelephonePerso);
            command.AddParameter("TelephoneCabinet", entity.TelephoneCabinet);

            idNewMedecin = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewMedecin.Value : -1;
        }

        public bool Update(int key, MedecinExterneGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateMedecinExterne", true);
            command.AddParameter("Id", key);
            command.AddParameter("NumInami", entity.NumInami);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            command.AddParameter("Adresse", entity.Adresse);
            command.AddParameter("Mail", entity.Mail);
            command.AddParameter("DateNaissance", entity.DateNaissance);
            command.AddParameter("TelephonePerso", entity.TelephonePerso);
            command.AddParameter("TelephoneCabinet", entity.TelephoneCabinet);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
    }
}
