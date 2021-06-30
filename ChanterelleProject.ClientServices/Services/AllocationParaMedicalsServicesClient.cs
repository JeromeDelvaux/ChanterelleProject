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
    public class AllocationParaMedicalsServicesClient : IAllocationParaMedicals<int, AllocationParaMedicalsClient, AllocationParaMedicalsFullAttributeForViewClient>
    {
        private readonly IAllocationParaMedicals<int, AllocationParaMedicalsGlobal, AllocationParaMedicalsFullAttributeForViewGlobal> _allocationParaMedicalsServicesGlobal;
        
        public AllocationParaMedicalsServicesClient(IAllocationParaMedicals<int, AllocationParaMedicalsGlobal, AllocationParaMedicalsFullAttributeForViewGlobal> allocationParaMedicalsServicesGlobal)
        {
            _allocationParaMedicalsServicesGlobal = allocationParaMedicalsServicesGlobal;
        }

        public bool DeleteAllocationParaMedicals(int key)
        {
            return _allocationParaMedicalsServicesGlobal.DeleteAllocationParaMedicals(key);
        }

        public AllocationParaMedicalsFullAttributeForViewClient Get(int key)
        {
            return _allocationParaMedicalsServicesGlobal.Get(key).ToAllocationParaMedicalsFullAttributeForViewClient(); ;
        }

        public IEnumerable<AllocationParaMedicalsFullAttributeForViewClient> GetAll()
        {
            return _allocationParaMedicalsServicesGlobal.GetAll().Select(u => u.ToAllocationParaMedicalsFullAttributeForViewClient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurClientFullAttributeForView

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
