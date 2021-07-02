using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class InscriptionClient:IEntity<int>
    {
        public InscriptionClient(int id, DateTime dateDebut, int eleve_Id, int utilisateur_Id)
        {
            Id = id;
            DateDebut = dateDebut;
            Eleve_Id = eleve_Id;
            Utilisateur_Id = utilisateur_Id;
        }

        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public int Eleve_Id { get; set; }
        public int Utilisateur_Id { get; set; }
    }
}
