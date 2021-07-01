using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class TraitementClient
    {
        public TraitementClient(int id, string nomMedicament, string posologie, DateTime dateDebut, DateTime dateFin, string objectif, string targetPrescriptionMedical, int utilisateur_Id, int eleve_Id)
        {
            Id = id;
            NomMedicament = nomMedicament;
            Posologie = posologie;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Objectif = objectif;
            TargetPrescriptionMedical = targetPrescriptionMedical;
            Utilisateur_Id = utilisateur_Id;
            Eleve_Id = eleve_Id;
        }

        public int Id { get; set; }
        public string NomMedicament { get; set; }
        public string Posologie { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Objectif { get; set; }
        public string TargetPrescriptionMedical { get; set; }
        public int Utilisateur_Id { get; set; }
        public int Eleve_Id { get; set; }
    }
}
