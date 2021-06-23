using PatternRepository.IRepository;
using System;
using System.Collections.Generic;
using ChanterelleProject.Models.Client;
using ChanterelleProject.GlobalServices.Services;
using ChanterelleProject.ClientServices.Mappers;
using System.Linq;
using ChanterelleProject.Models.Global;

namespace ChanterelleProject.ClientServices.Services
{
    public class UtilisateursServiceClient : IRepository<int, UtilisateurClient>
    {
        private readonly IRepository<int, Utilisateur> _globalUtilisateurServices;

        public UtilisateursServiceClient(IRepository<int, Utilisateur> globalUtilisateurServices)
        {
            _globalUtilisateurServices = globalUtilisateurServices;
        }

        public bool Delete(int key)
        {
            return _globalUtilisateurServices.Delete(key);
        }

        public UtilisateurClient Get(int key)
        {
            return _globalUtilisateurServices.Get(key).ToUtilisateursCLient();
        }

        public IEnumerable<UtilisateurClient> GetAll()
        {
            return _globalUtilisateurServices.GetAll().Select(u => u.ToUtilisateursCLient()); // Parcours toute la liste,applique les modifications de la lambda a chaques elements et l'envoi à ToUtilisateurCLient
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
