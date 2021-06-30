using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class AllocationClassesClient : IEntity<int>
    {
        public AllocationClassesClient(int id, DateTime dateDebut, int classe_Id, int utilisateur_Id)
        {
            Id = id;
            DateDebut = dateDebut;
            Classe_Id = classe_Id;
            Utilisateur_Id = utilisateur_Id;
        }

        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public int Classe_Id { get; set; }
        public int Utilisateur_Id { get; set; }
    }
}
