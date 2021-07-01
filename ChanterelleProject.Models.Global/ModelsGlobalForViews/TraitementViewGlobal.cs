using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global.ModelsGlobalForViews
{
    public class TraitementViewGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public string NomMedicament { get; set; }
        public string Posologie { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string Objectif { get; set; }
        public string TargetPrescriptionMedical { get; set; }
        public string NomCreateur { get; set; }
        public string NomEleve { get; set; }
    }
}
