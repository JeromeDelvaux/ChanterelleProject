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
    public class AllocationClassesServicesClient : IAllocationClasses<int, AllocationClassesClient, AllocationClassesFullAttributeForViewClient>
    {
        private readonly IAllocationClasses<int, AllocationClassesGlobal, AllocationClassesFullAttributeForViewGlobal> _allocationClassesServicesGlobal;

        public AllocationClassesServicesClient(IAllocationClasses<int, AllocationClassesGlobal, AllocationClassesFullAttributeForViewGlobal> allocationClassesServicesGlobal)
        {
            _allocationClassesServicesGlobal = allocationClassesServicesGlobal;
        }

        public bool DeleteAllocationClasses(int key)
        {
            return _allocationClassesServicesGlobal.DeleteAllocationClasses(key);
        }

        public AllocationClassesFullAttributeForViewClient Get(int key)
        {
            return _allocationClassesServicesGlobal.Get(key).ToAllocationClassesFullAttributeForViewClient(); ;
        }

        public IEnumerable<AllocationClassesFullAttributeForViewClient> GetAll()
        {
            return _allocationClassesServicesGlobal.GetAll().Select(u => u.ToAllocationClassesFullAttributeForViewClient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurClientFullAttributeForView
        }

        public int InsertAllocationClasses(AllocationClassesClient entity)
        {
            return _allocationClassesServicesGlobal.InsertAllocationClasses(entity.ToAllocationClassesGlobal()); ;
        }

        public bool UpdateAllocationClasses(int key, AllocationClassesClient entity)
        {
            return _allocationClassesServicesGlobal.UpdateAllocationClasses(key, entity.ToAllocationClassesGlobal());
        }
    }
}