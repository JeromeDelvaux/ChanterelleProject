using ChanterelleProject.Interfaces;
using System;


namespace ChanterelleProject.Models.Global
{
    public class TraitementGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public string NomMedicament { get; set; }
        public string Posologie { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string Objectif { get; set; }
        public string TargetPrescriptionMedical { get; set; }
        public int Utilisateur_Id { get; set; }
        public int Eleve_Id { get; set; }
    }
}

