using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class TypeUtilisateurClient : IEntity<int>
    {
        public TypeUtilisateurClient(int id, string intituleTypeUtilisateur)
        {
            Id = id;
            IntituleTypeUtilisateur = intituleTypeUtilisateur;
        }

        public int Id { get; set; }
        public string IntituleTypeUtilisateur { get; set; }
    }
}
