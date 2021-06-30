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
    public class AllocationParaMedicalsServicesGlobal : IAllocationParaMedicals<int, AllocationParaMedicalsGlobal, AllocationParaMedicalsFullAttributeForViewGlobal>
    {
        private readonly IConnection _connection;

        public AllocationParaMedicalsServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }
        public bool DeleteAllocationParaMedicals(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteAllocationParaMedicals", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public AllocationParaMedicalsFullAttributeForViewGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllocationParaMedicalsById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToAllocationParaMedicalsFullAttributeForViewGlobal()).SingleOrDefault();
        }

        public IEnumerable<AllocationParaMedicalsFullAttributeForViewGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllAllocationParaMedicals", true);
            return _connection.ExecuteReader(command, sp => sp.ToAllocationParaMedicalsFullAttributeForViewGlobal());
        }

        public int InsertAllocationParaMedicals(AllocationParaMedicalsGlobal entity)
        {
            int? idNewAllocationParaMedicals;

            Commands command = new Commands("SP_ChtlePrj_AddAllocationParaMedicals", true);
            command.AddParameter("DateDebut", entity.DateDebut);
            command.AddParameter("Classe_Id", entity.Classe_Id);
            command.AddParameter("ParaMedical_Id", entity.ParaMedical_Id);

            idNewAllocationParaMedicals = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewAllocationParaMedicals.Value : -1;
        }

        public bool UpdateAllocationParaMedicals(int key, AllocationParaMedicalsGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateAllocationParaMedicals", true);
            command.AddParameter("Id", key);
            command.AddParameter("Classe_Id", entity.Classe_Id);
            command.AddParameter("ParaMedical_Id", entity.ParaMedical_Id);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
    }
}
