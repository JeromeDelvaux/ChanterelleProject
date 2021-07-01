using ChanterelleProject.ClientServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Client.ModelClientForViews;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChanterelleProject.ClientServices.Services
{
    public class AllocationParaMedicalsServicesClient : IAllocationParaMedicals<int, AllocationParaMedicalsClient, AllocationParaMedicalsViewClient>
    {
        private readonly IAllocationParaMedicals<int, Models.Global.AllocationParaMedicalsGlobal, Models.Global.ModelsGlobalForViews.AllocationParaMedicalsViewGlobal> _allocationParaMedicalsServicesGlobal;
        
        public AllocationParaMedicalsServicesClient(IAllocationParaMedicals<int, Models.Global.AllocationParaMedicalsGlobal, Models.Global.ModelsGlobalForViews.AllocationParaMedicalsViewGlobal> allocationParaMedicalsServicesGlobal)
        {
            _allocationParaMedicalsServicesGlobal = allocationParaMedicalsServicesGlobal;
        }

        public bool DeleteAllocationParaMedicals(int key)
        {
            return _allocationParaMedicalsServicesGlobal.DeleteAllocationParaMedicals(key);
        }

        public AllocationParaMedicalsViewClient Get(int key)
        {
            return _allocationParaMedicalsServicesGlobal.Get(key).ToAllocationParaMedicalsViewClient(); ;
        }

        public IEnumerable<AllocationParaMedicalsViewClient> GetAll()
        {
            return _allocationParaMedicalsServicesGlobal.GetAll().Select(u => u.ToAllocationParaMedicalsViewClient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurClientFullAttributeForView

        }

        public int InsertAllocationParaMedicals(AllocationParaMedicalsClient entity)
        {
            return _allocationParaMedicalsServicesGlobal.InsertAllocationParaMedicals(entity.ToAllocationParaMedicalsGlobal()); ;
        }

        public bool UpdateAllocationParaMedicals(int key, AllocationParaMedicalsClient entity)
        {
            return _allocationParaMedicalsServicesGlobal.UpdateAllocationParaMedicals(key, entity.ToAllocationParaMedicalsGlobal());

        }
    }
}
