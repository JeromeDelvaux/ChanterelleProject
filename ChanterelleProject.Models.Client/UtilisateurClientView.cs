using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Models.Client
{
    public class UtilisateurClientView:UtilisateurClient
    {
        public UtilisateurClientView(int id, string nom, string prenom, string adresse, DateTime dateNaissance, string registreNational, string sexe, DateTime dateDerniereModif, DateTime dateDebutContrat, string telephone, string mail, int typeUtilisateur_Id, string motDePasse,string numInami,int? specialisationId) 
            :base (id,nom,prenom,adresse,dateNaissance,registreNational,sexe,dateDerniereModif,dateDebutContrat,telephone,mail,typeUtilisateur_Id,motDePasse)
        {
            NumInami = numInami;
            SpecialisationId = specialisationId;
        }
        public string NumInami { get; set; }
        public int? SpecialisationId { get; set; }
    }
}
