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
    public class AllocationClassesServicesGlobal : IAllocationClasses<int, AllocationClassesGlobal, AllocationClassesViewGlobal>
    {
        private readonly IConnection _connection;

        public AllocationClassesServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }

        public bool DeleteAllocationClasses(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteAllocationClasses", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public AllocationClassesViewGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllocationClassesById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToAllocationClassesViewGlobal()).SingleOrDefault();
        }

        public IEnumerable<AllocationClassesViewGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllAllocationClasses", true);
            return _connection.ExecuteReader(command, sp => sp.ToAllocationClassesViewGlobal());
        }

        public int InsertAllocationClasses(AllocationClassesGlobal entity)
        {
            int? idNewAllocationClasses;

            Commands command = new Commands("SP_ChtlePrj_AddAllocationClasses", true);
            command.AddParameter("DateDebut", entity.DateDebut);
            command.AddParameter("Classe_Id", entity.Classe_Id);
            command.AddParameter("Utilisateur_Id", entity.Utilisateur_Id);

            idNewAllocationClasses = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewAllocationClasses.Value : -1;
        }

        public bool UpdateAllocationClasses(int key, AllocationClassesGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateAllocationClasses", true);
            command.AddParameter("Id", key);
            command.AddParameter("Classe_Id", entity.Classe_Id);
            command.AddParameter("Utilisateur_Id", entity.Utilisateur_Id);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
    }
}
