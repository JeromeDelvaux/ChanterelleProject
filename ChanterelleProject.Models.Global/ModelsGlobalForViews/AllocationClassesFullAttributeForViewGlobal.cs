using ChanterelleProject.Interfaces;
using System;


namespace ChanterelleProject.Models.Global.ModelsGlobalForViews
{
    public class AllocationClassesFullAttributeForViewGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public string NomClasse { get; set; }
        public string NomProfesseur { get; set; }
    }
}
