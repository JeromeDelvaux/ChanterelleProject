using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client.ModelClientForViews
{
    public class AllocationClassesViewClient : IEntity<int>
    {
        public AllocationClassesViewClient(int id, DateTime dateDebut, DateTime? dateFin, string nomClasse, string nomProfesseur)
        {
            Id = id;
            DateDebut = dateDebut;
            DateFin = dateFin;
            NomClasse = nomClasse;
            NomProfesseur = nomProfesseur;
        }

        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string NomClasse { get; set; }
        public string NomProfesseur { get; set; }
    }
}
