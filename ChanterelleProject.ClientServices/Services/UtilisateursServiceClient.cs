using System.Collections.Generic;
using ChanterelleProject.Models.Client;
using ChanterelleProject.ClientServices.Mappers;
using System.Linq;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Interfaces;

namespace ChanterelleProject.ClientServices.Services
{
    public class UtilisateursServiceClient : IUtilisateur<int, UtilisateurClient>, IUtilisateurView<int, UtilisateurClientView>
    {
        private readonly IUtilisateur<int, Utilisateur> _globalUtilisateurServices;
        private readonly IUtilisateurView<int, UtilisateurView> _globalUtilisateurServicesView;

        public UtilisateursServiceClient(IUtilisateur<int, Utilisateur> globalUtilisateurServices, IUtilisateurView<int, UtilisateurView> globalUtilisateurServicesView)
        {
            _globalUtilisateurServices = globalUtilisateurServices;
            _globalUtilisateurServicesView = globalUtilisateurServicesView;
        }

        public bool Delete(int key)
        {
            return _globalUtilisateurServices.Delete(key);
        }

        public UtilisateurClientView Get(int key)
        {
            return _globalUtilisateurServicesView.Get(key).ToUtilisateursClientView();
        }

        public IEnumerable<UtilisateurClientView> GetAll()
        {
            return _globalUtilisateurServicesView.GetAll().Select(u => u.ToUtilisateursClientView()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurCLient

        }

        public int Insert(UtilisateurClient entity)
        {
            return _globalUtilisateurServices.Insert(entity.ToUtilisateursGlobal());
        }

        public bool Update(int key, UtilisateurClient entity)
        {
            return _globalUtilisateurServices.Update(key, entity.ToUtilisateursGlobal());
        }

        //public bool CheckPassword(string password, string mail)
        //{
        //    bool result = _globalUtilisateurServices.CheckPassword(password, mail);
        //    password = null;
        //    return result;

        //}
    }
}
