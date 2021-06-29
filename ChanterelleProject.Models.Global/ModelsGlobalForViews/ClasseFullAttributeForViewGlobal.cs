using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global.ModelsGlobalForViews
{
    public class ClasseFullAttributeForViewGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public string IntituleClasse { get; set; }
        public int NbEleveMax { get; set; }
        public string NomTitulaire { get; set; }
    }
}
