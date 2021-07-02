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
    public class UtilisateurServiceClient : IUtilisateur<int, UtilisateurClient, UtilisateurViewClient, ParaMedicalClient>
    {
        private readonly IUtilisateur<int, Models.Global.UtilisateurGlobal, Models.Global.ModelsGlobalForViews.UtilisateurViewGlobal, ParaMedicalGlobal> _globalUtilisateurServices;


        public UtilisateurServiceClient(IUtilisateur<int, Models.Global.UtilisateurGlobal, Models.Global.ModelsGlobalForViews.UtilisateurViewGlobal, ParaMedicalGlobal> globalUtilisateurServices)
        {
            _globalUtilisateurServices = globalUtilisateurServices;
        }

        public bool DeleteUtilisateur(int key)
        {
            return _globalUtilisateurServices.DeleteUtilisateur(key);
        }

        public UtilisateurViewClient Get(int key)
        {
            return _globalUtilisateurServices.Get(key).ToUtilisateurViewClient();
        }

        public IEnumerable<UtilisateurViewClient> GetAll()
        {
            return _globalUtilisateurServices.GetAll().Select(u => u.ToUtilisateurViewClient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurClientFullAttributeForView
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
        public UtilisateurViewClient LoginUtilisateur(string email, string password)
        {
            UtilisateurViewClient utilisateurViewClient;

            utilisateurViewClient= _globalUtilisateurServices.LoginUtilisateur(email, password).ToUtilisateurViewClient();
            password = null;

            return utilisateurViewClient;
        }
    }
}
