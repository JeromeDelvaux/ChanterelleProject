using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Forms.Create
{
    public class FormsCreateTraitement
    {
        [Required]
        public string NomMedicament { get; set; }
        [Required]
        public string Posologie { get; set; }
        [Required]
        public DateTime DateDebut { get; set; }
        [Required]
        public DateTime DateFin { get; set; }
        [Required]
        public string Objectif { get; set; }
        [Required]
        public string TargetPrescriptionMedical { get; set; }
        [Required]
        public int Utilisateur_Id { get; set; }
        [Required]
        public int Eleve_Id { get; set; }
    }
}
