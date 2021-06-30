using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class AllocationParaMedicalsClient : IEntity<int>
    {
        public AllocationParaMedicalsClient(int id, DateTime dateDebut, int classe_Id, int paraMedical_Id)
        {
            Id = id;
            DateDebut = dateDebut;
            Classe_Id = classe_Id;
            ParaMedical_Id = paraMedical_Id;
        }

        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public int Classe_Id { get; set; }
        public int ParaMedical_Id { get; set; }
    }
}
