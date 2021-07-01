using ChanterelleProject.ClientServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Client.ModelClientForViews;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using System.Collections.Generic;
using System.Linq;


namespace ChanterelleProject.ClientServices.Services
{
    public class ClasseServicesClient : IClasse<int, ClasseClient, ClasseViewClient>
    {
        private readonly IClasse<int, ClasseGlobal, ClasseViewGlobal> _classeServicesGlobal;

        public ClasseServicesClient(IClasse<int, ClasseGlobal, ClasseViewGlobal> classeServicesGlobal)
        {
            _classeServicesGlobal = classeServicesGlobal;
        }

        public bool DeleteClasse(int key)
        {
            return _classeServicesGlobal.DeleteClasse(key);
        }

        public ClasseViewClient Get(int key)
        {
            return _classeServicesGlobal.Get(key).ToClasseViewClient();
        }

        public IEnumerable<ClasseViewClient> GetAll()
        {
            return _classeServicesGlobal.GetAll().Select(s => s.ToClasseViewClient());
        }

        public int InsertClasse(ClasseClient entity)
        {
            return _classeServicesGlobal.InsertClasse(entity.ToClasseGlobal());
        }

        public bool UpdateClasse(int key, ClasseClient entity)
        {
            return _classeServicesGlobal.UpdateClasse(key, entity.ToClasseGlobal());
        }
    }
}
