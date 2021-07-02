using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global.ModelsGlobalForViews
{
    public class InscriptionViewGlobal: IEntity<int>
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string NomEleve { get; set; }
        public string NomCreateur { get; set; }
    }
}
