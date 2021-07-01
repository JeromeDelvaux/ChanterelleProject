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
    public class EleveServicesClient : IEleve<int, EleveClient, EleveViewClient>
    {
        private readonly IEleve<int, EleveGlobal, EleveViewGlobal> _eleveServicesGlobal;

        public EleveServicesClient(IEleve<int, EleveGlobal, EleveViewGlobal> eleveServicesGlobal)
        {
            _eleveServicesGlobal = eleveServicesGlobal;
        }

        public bool DeleteEleve(int key)
        {
            return _eleveServicesGlobal.DeleteEleve(key);
        }

        public EleveViewClient Get(int key)
        {
            return _eleveServicesGlobal.Get(key).ToEleveViewClient();
        }

        public IEnumerable<EleveViewClient> GetAll()
        {
            return _eleveServicesGlobal.GetAll().Select(u => u.ToEleveViewClient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurClientFullAttributeForView
        }

        public int InsertEleve(EleveClient entity)
        {
            return _eleveServicesGlobal.InsertEleve(entity.ToEleveGlobal()); ;
        }

        public bool UpdateEleve(int key, EleveClient entity)
        {
            return _eleveServicesGlobal.UpdateEleve(key, entity.ToEleveGlobal());
        }
    }
}
