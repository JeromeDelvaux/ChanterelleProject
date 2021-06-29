using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class ClasseClient : IEntity<int>
    {
        public ClasseClient(int id, string intituleClasse, int nbEleveMax, int utilisateur_Id)
        {
            Id = id;
            IntituleClasse = intituleClasse;
            NbEleveMax = nbEleveMax;
            Utilisateur_Id = utilisateur_Id;
        }

        public int Id { get; set; }
        public string IntituleClasse { get; set; }
        public int NbEleveMax { get; set; }
        public int Utilisateur_Id { get; set; }
    }
}
