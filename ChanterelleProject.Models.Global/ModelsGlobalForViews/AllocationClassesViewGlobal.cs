using ChanterelleProject.Interfaces;
using System;


namespace ChanterelleProject.Models.Global.ModelsGlobalForViews
{
    public class AllocationClassesViewGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string NomClasse { get; set; }
        public string NomProfesseur { get; set; }
    }
}
