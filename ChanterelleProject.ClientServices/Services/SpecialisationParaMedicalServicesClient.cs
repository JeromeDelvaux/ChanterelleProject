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
    public class SpecialisationParaMedicalServicesClient : ISpecialisationParaMedical<int, SpecialisationParaMedicalClient>
    {
        private readonly ISpecialisationParaMedical<int, SpecialisationParaMedicalGlobal> _specialisationParaMedical;

        public SpecialisationParaMedicalServicesClient(ISpecialisationParaMedical<int, SpecialisationParaMedicalGlobal> specialisationParaMedical)
        {
            _specialisationParaMedical = specialisationParaMedical;
        }

        public bool Delete(int key)
        {
            return _specialisationParaMedical.Delete(key);
        }

        public SpecialisationParaMedicalClient Get(int key)
        {
            return _specialisationParaMedical.Get(key).ToSpecialisationParaMedicalClient();
        }

        public IEnumerable<SpecialisationParaMedicalClient> GetAll()
        {
            return _specialisationParaMedical.GetAll().Select(s => s.ToSpecialisationParaMedicalClient());
        }

        public int Insert(SpecialisationParaMedicalClient entity)
        {
            return _specialisationParaMedical.Insert(entity.ToSpecialisationParaMedicalGlobal());
        }

        public bool Update(int key, SpecialisationParaMedicalClient entity)
        {
            return _specialisationParaMedical.Update(key, entity.ToSpecialisationParaMedicalGlobal());
        }
    }
}
