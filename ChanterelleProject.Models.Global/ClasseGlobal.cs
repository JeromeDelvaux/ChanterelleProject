using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class ClasseGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public string IntituleClasse { get; set; }
        public int NbEleveMax { get; set; }
        public int Utilisateur_Id { get; set; }
    }
}
