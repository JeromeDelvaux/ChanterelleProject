using ChanterelleProject.ClientServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChanterelleProject.ClientServices.Services
{
    public class TypeUtilisateurServicesClient : IServices<int, TypeUtilisateurClient>
    {
        private readonly IServices<int, TypeUtilisateurGlobal> _TypeUtilisateurServicesGlobal;

        public TypeUtilisateurServicesClient(IServices<int, TypeUtilisateurGlobal> typeUtilisateurServicesGlobal)
        {
            _TypeUtilisateurServicesGlobal = typeUtilisateurServicesGlobal;
        }
        public bool Delete(int key)
        {
            return _TypeUtilisateurServicesGlobal.Delete(key);
        }

        public TypeUtilisateurClient Get(int key)
        {
            return _TypeUtilisateurServicesGlobal.Get(key).ToTypeUtilisateurClient();
        }

        public IEnumerable<TypeUtilisateurClient> GetAll()
        {
            return _TypeUtilisateurServicesGlobal.GetAll().Select(s => s.ToTypeUtilisateurClient());
        }

        public int Insert(TypeUtilisateurClient entity)
        {
            return _TypeUtilisateurServicesGlobal.Insert(entity.ToTypeUtilisateurGlobal());
        }

        public bool Update(int key, TypeUtilisateurClient entity)
        {
            return _TypeUtilisateurServicesGlobal.Update(key, entity.ToTypeUtilisateurGlobal());
        }
    }
}
