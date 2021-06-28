using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class TypeUtilisateurGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public string IntituleTypeUtilisateur { get; set; }
    }
}
