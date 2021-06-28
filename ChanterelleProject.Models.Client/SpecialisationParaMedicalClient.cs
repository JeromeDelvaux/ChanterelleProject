using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class SpecialisationParaMedicalClient:IEntity<int>
    {
        public SpecialisationParaMedicalClient(int id, string intituleSpecialisation)
        {
            Id = id;
            IntituleSpecialisation = intituleSpecialisation;
        }

        public int Id { get; set; }
        public string IntituleSpecialisation { get; set; }
    }
}
