using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client.ModelClientForViews
{
    public class AllocationClassesFullAttributeForViewClient : IEntity<int>
    {
        public AllocationClassesFullAttributeForViewClient(int id, DateTime dateDebut, string nomClasse, string nomProfesseur)
        {
            Id = id;
            DateDebut = dateDebut;
            NomClasse = nomClasse;
            NomProfesseur = nomProfesseur;
        }

        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public string NomClasse { get; set; }
        public string NomProfesseur { get; set; }
    }
}
