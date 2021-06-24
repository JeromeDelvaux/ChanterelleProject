using System.Collections.Generic;
using ChanterelleProject.Models.Client;
using ChanterelleProject.ClientServices.Mappers;
using System.Linq;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Interfaces;

namespace ChanterelleProject.ClientServices.Services
{
    public class UtilisateurServiceClient : IUtilisateur<int, UtilisateurClient, UtilisateurClientView>
    {
        private readonly IUtilisateur<int, UtilisateurGlobal, UtilisateurGlobalView> _globalUtilisateurServices;


        public UtilisateurServiceClient(IUtilisateur<int, UtilisateurGlobal, UtilisateurGlobalView> globalUtilisateurServices)
        {
            _globalUtilisateurServices = globalUtilisateurServices;
        }

        public bool Delete(int key)
        {
            return _globalUtilisateurServices.Delete(key);
        }

        public UtilisateurClientView Get(int key)
        {
            return _globalUtilisateurServices.Get(key).ToUtilisateursClientView();
        }

        public IEnumerable<UtilisateurClientView> GetAll()
        {
            return _globalUtilisateurServices.GetAll().Select(u => u.ToUtilisateursClientView()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurCLient
           
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
