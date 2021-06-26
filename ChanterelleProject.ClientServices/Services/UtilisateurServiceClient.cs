using System.Collections.Generic;
using ChanterelleProject.Models.Client;
using ChanterelleProject.ClientServices.Mappers;
using System.Linq;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Interfaces;

namespace ChanterelleProject.ClientServices.Services
{
    public class UtilisateurServiceClient : IUtilisateur<int, UtilisateurClient, UtilisateurClientFullAttributeForView>
    {
        private readonly IUtilisateur<int, UtilisateurGlobal, UtilisateurGlobalFullAttributeForView> _globalUtilisateurServices;


        public UtilisateurServiceClient(IUtilisateur<int, UtilisateurGlobal, UtilisateurGlobalFullAttributeForView> globalUtilisateurServices)
        {
            _globalUtilisateurServices = globalUtilisateurServices;
        }

        public bool Delete(int key)
        {
            return _globalUtilisateurServices.Delete(key);
        }

        public UtilisateurClientFullAttributeForView Get(int key)
        {
            return _globalUtilisateurServices.Get(key).ToUtilisateurClientFullAttributeForView();
        }

        public IEnumerable<UtilisateurClientFullAttributeForView> GetAll()
        {
            return _globalUtilisateurServices.GetAll().Select(u => u.ToUtilisateurClientFullAttributeForView()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurCLient
           
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
