using ChanterelleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client.ModelClientForViews
{
    public class InscriptionViewClient:IEntity<int>
    {
        public InscriptionViewClient(int id, DateTime dateDebut, DateTime? dateFin, string nomEleve, string nomCreateur)
        {
            Id = id;
            DateDebut = dateDebut;
            DateFin = dateFin;
            NomEleve = nomEleve;
            NomCreateur = nomCreateur;
        }

        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string NomEleve { get; set; }
        public string NomCreateur { get; set; }
    }
}
