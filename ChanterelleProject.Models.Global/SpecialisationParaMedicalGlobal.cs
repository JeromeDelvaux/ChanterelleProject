using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class SpecialisationParaMedicalGlobal: IEntity<int>
    {
        public int Id { get; set; }
        public string IntituleSpecialisation { get; set; }
    }
}
