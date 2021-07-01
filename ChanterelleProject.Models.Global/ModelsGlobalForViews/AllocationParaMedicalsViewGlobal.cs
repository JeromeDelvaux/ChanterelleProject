using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global.ModelsGlobalForViews
{
    public class AllocationParaMedicalsViewGlobal: IEntity<int>
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public string NomClasse { get; set; }
        public string NomParaMedical { get; set; }
    }
}
