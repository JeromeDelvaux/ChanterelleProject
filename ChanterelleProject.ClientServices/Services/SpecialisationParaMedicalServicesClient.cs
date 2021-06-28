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
    public class SpecialisationParaMedicalServicesClient : IServices<int, SpecialisationParaMedicalClient>
    {
        private readonly IServices<int, SpecialisationParaMedicalGlobal> _SpecialisationParaMedicalServicesGlobal;

        public SpecialisationParaMedicalServicesClient(IServices<int, SpecialisationParaMedicalGlobal> specialisationParaMedicalServicesGlobal)
        {
            _SpecialisationParaMedicalServicesGlobal = specialisationParaMedicalServicesGlobal;
        }

        public bool Delete(int key)
        {
            return _SpecialisationParaMedicalServicesGlobal.Delete(key);
        }

        public SpecialisationParaMedicalClient Get(int key)
        {
            return _SpecialisationParaMedicalServicesGlobal.Get(key).ToSpecialisationParaMedicalClient();
        }

        public IEnumerable<SpecialisationParaMedicalClient> GetAll()
        {
            return _SpecialisationParaMedicalServicesGlobal.GetAll().Select(s => s.ToSpecialisationParaMedicalClient());
        }

        public int Insert(SpecialisationParaMedicalClient entity)
        {
            return _SpecialisationParaMedicalServicesGlobal.Insert(entity.ToSpecialisationParaMedicalGlobal());
        }

        public bool Update(int key, SpecialisationParaMedicalClient entity)
        {
            return _SpecialisationParaMedicalServicesGlobal.Update(key, entity.ToSpecialisationParaMedicalGlobal());
        }
    }
}
