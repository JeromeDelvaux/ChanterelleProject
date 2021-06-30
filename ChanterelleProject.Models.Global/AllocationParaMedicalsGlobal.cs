using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class AllocationParaMedicalsGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public int Classe_Id { get; set; }
        public int ParaMedical_Id { get; set; }
    }
}
