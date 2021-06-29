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
    public class MedecinExterneServicesClient : IServices<int, MedecinExterneClient>
    {
        private readonly IServices<int, MedecinExterneGlobal> _medecinExterneServicesGlobal;

        public MedecinExterneServicesClient(IServices<int, MedecinExterneGlobal> medecinExterneServicesGlobal)
        {
            _medecinExterneServicesGlobal = medecinExterneServicesGlobal;
        }
        public bool Delete(int key)
        {
            return _medecinExterneServicesGlobal.Delete(key);
        }

        public MedecinExterneClient Get(int key)
        {
            return _medecinExterneServicesGlobal.Get(key).ToMedecinExterneClient();
        }

        public IEnumerable<MedecinExterneClient> GetAll()
        {
            return _medecinExterneServicesGlobal.GetAll().Select(s => s.ToMedecinExterneClient());
        }

        public int Insert(MedecinExterneClient entity)
        {
            return _medecinExterneServicesGlobal.Insert(entity.ToMedecinExterneGlobal());
        }

        public bool Update(int key, MedecinExterneClient entity)
        {
            return _medecinExterneServicesGlobal.Update(key, entity.ToMedecinExterneGlobal());
        }
    }
}
