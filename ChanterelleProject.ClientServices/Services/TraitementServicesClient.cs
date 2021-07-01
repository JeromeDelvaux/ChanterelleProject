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
    public class TraitementServicesClient : ITraitement<int, TraitementClient, TraitementViewClient>
    {
        private readonly ITraitement<int, TraitementGlobal, TraitementViewGlobal> _traitementServicesGlobal;

        public TraitementServicesClient(ITraitement<int, TraitementGlobal, TraitementViewGlobal> traitementServicesGlobal)
        {
            _traitementServicesGlobal = traitementServicesGlobal;
        }

        public bool DeleteTraitement(int key)
        {
            return _traitementServicesGlobal.DeleteTraitement(key);
        }

        public TraitementViewClient Get(int key)
        {
            return _traitementServicesGlobal.Get(key).ToTraitementViewClient(); ;
        }

        public IEnumerable<TraitementViewClient> GetAll()
        {
            return _traitementServicesGlobal.GetAll().Select(u => u.ToTraitementViewClient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurClientFullAttributeForView
        }

        public int InsertTraitement(TraitementClient entity)
        {
            return _traitementServicesGlobal.InsertTraitement(entity.ToTraitementGlobal()); ;
        }

        public bool UpdateTraitement(int key, TraitementClient entity)
        {
            return _traitementServicesGlobal.UpdateTraitement(key, entity.ToTraitementGlobal());
        }
    }
}
