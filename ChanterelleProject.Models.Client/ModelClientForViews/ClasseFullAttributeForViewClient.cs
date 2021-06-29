using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client.ModelClientForViews
{
    public class ClasseFullAttributeForViewClient : IEntity<int>
    {
        public ClasseFullAttributeForViewClient(int id, string intituleClasse, int nbEleveMax, string nomTitulaire)
        {
            Id = id;
            IntituleClasse = intituleClasse;
            NbEleveMax = nbEleveMax;
            NomTitulaire = nomTitulaire;
        }

        public int Id { get; set; }
        public string IntituleClasse { get; set; }
        public int NbEleveMax { get; set; }
        public string NomTitulaire { get; set; }
    }
}
