using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class SpecialisationParaMedicalClient:IEntity<int>
    {
        public SpecialisationParaMedicalClient(int id, string intitule)
        {
            Id = id;
            Intitule = intitule;
        }

        public int Id { get; set; }
        public string Intitule { get; set; }
    }
}
