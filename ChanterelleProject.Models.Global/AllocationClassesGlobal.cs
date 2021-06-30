﻿using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Global
{
    public class AllocationClassesGlobal : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public int Classe_Id { get; set; }
        public int Utilisateur_Id { get; set; }
    }
}
