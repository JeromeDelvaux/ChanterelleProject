using ChanterelleProject.ClientServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Client.ModelClientForViews;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using System.Collections.Generic;
using System.Linq;

namespace ChanterelleProject.ClientServices.Services
{
    public class InscriptionServicesClient : IInscription<int, InscriptionClient, InscriptionViewClient>
    {
        private readonly IInscription<int, InscriptionGlobal, InscriptionViewGlobal> _inscriptionServicesGlobal;

        public InscriptionServicesClient(IInscription<int, InscriptionGlobal, InscriptionViewGlobal> inscriptionServicesGlobal)
        {
            _inscriptionServicesGlobal = inscriptionServicesGlobal;
        }

        public bool DeleteInscription(int key)
        {
            return _inscriptionServicesGlobal.DeleteInscription(key);
        }

        public InscriptionViewClient Get(int key)
        {
            return _inscriptionServicesGlobal.Get(key).ToInscriptionViewClient();
        }

        public IEnumerable<InscriptionViewClient> GetAll()
        {
            return _inscriptionServicesGlobal.GetAll().Select(u => u.ToInscriptionViewClient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurClientFullAttributeForView
        }

        public int InsertInscription(InscriptionClient entity)
        {
            return _inscriptionServicesGlobal.InsertInscription(entity.ToInscriptionGlobal());
        }

        public bool UpdateInscription(int key, InscriptionClient entity)
        {
            return _inscriptionServicesGlobal.UpdateInscription(key, entity.ToInscriptionGlobal());
        }
    }
}
