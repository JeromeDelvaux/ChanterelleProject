using System.Collections.Generic;
using ChanterelleProject.Models.Client;
using ChanterelleProject.ClientServices.Mappers;
using System.Linq;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client.ModelClientForViews;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;

namespace ChanterelleProject.ClientServices.Services
{
    public class UtilisateurServiceClient : IUtilisateur<int, UtilisateurClient, UtilisateurFullAttributeForViewClient, ParaMedicalClient>
    {
        private readonly IUtilisateur<int, UtilisateurGlobal, UtilisateurFullAttributeForViewGlobal, ParaMedicalGlobal> _globalUtilisateurServices;


        public UtilisateurServiceClient(IUtilisateur<int, UtilisateurGlobal, UtilisateurFullAttributeForViewGlobal, ParaMedicalGlobal> globalUtilisateurServices)
        {
            _globalUtilisateurServices = globalUtilisateurServices;
        }

        public bool DeleteUtilisateur(int key)
        {
            return _globalUtilisateurServices.DeleteUtilisateur(key);
        }

        public UtilisateurFullAttributeForViewClient Get(int key)
        {
            return _globalUtilisateurServices.Get(key).ToUtilisateurFullAttributeForViewClient();
        }

        public IEnumerable<UtilisateurFullAttributeForViewClient> GetAll()
        {
            return _globalUtilisateurServices.GetAll().Select(u => u.ToUtilisateurFullAttributeForViewClient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurClientFullAttributeForView
        }

        public int InsertParaMedical(ParaMedicalClient entity)
        {
            return _globalUtilisateurServices.InsertParaMedical(entity.ToParaMedicalGlobal());
        }

        public int InsertUtilisateur(UtilisateurClient entity)
        {
            return _globalUtilisateurServices.InsertUtilisateur(entity.ToUtilisateursGlobal());
        }

        public bool UpdateParaMedical(int key, ParaMedicalClient entity)
        {
            return _globalUtilisateurServices.UpdateParaMedical(key, entity.ToParaMedicalGlobal());
        }

        public bool UpdateUtilisateur(int key, UtilisateurClient entity)
        {
            return _globalUtilisateurServices.UpdateUtilisateur(key, entity.ToUtilisateursGlobal());
        }

        //public bool CheckPassword(string password, string mail)
        //{
        //    bool result = _globalUtilisateurServices.CheckPassword(password, mail);
        //    password = null;
        //    return result;

        //}
    }
}
