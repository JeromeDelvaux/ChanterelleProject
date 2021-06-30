using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client.ModelClientForViews
{
    public class AllocationParaMedicalsFullAttributeForViewClient : IEntity<int>
    {
        public AllocationParaMedicalsFullAttributeForViewClient(int id, DateTime dateDebut, string nomClasse, string nomParaMedical)
        {
            Id = id;
            DateDebut = dateDebut;
            NomClasse = nomClasse;
            NomParaMedical = nomParaMedical;
        }

        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public string NomClasse { get; set; }
        public string NomParaMedical { get; set; }
    }
}
