using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client.ModelClientForViews
{
    public class TraitementViewClient : IEntity<int>
    {
        public TraitementViewClient(int id, string nomMedicament, string posologie, DateTime dateDebut, DateTime? dateFin, string objectif, string targetPrescriptionMedical, string nomCreateur, string nomEleve)
        {
            Id = id;
            NomMedicament = nomMedicament;
            Posologie = posologie;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Objectif = objectif;
            TargetPrescriptionMedical = targetPrescriptionMedical;
            NomCreateur = nomCreateur;
            NomEleve = nomEleve;
        }

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
