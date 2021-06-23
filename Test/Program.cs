using ChanterelleProject.GlobalServices.Services;
using ChanterelleProject.Models.Global;
using ConnectionDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Utilisateur> l = new List<Utilisateur>();
            Connection connection = new Connection(SqlClientFactory.Instance, @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ChanterelleProjectDataBase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            UtilisateurServices utilisateurServices = new UtilisateurServices(connection);
            Utilisateur utilisateur = new Utilisateur()
            {
                Nom = "bigboom",
                Prenom = "bilku",
                Adresse = "Rue de morgue casier C",
                DateDebutContrat = DateTime.Now,
                DateNaissance = new DateTime(1970, 1, 1),
                RegistreNational = "00002928389",
                Telephone = "0498567894",
                TypeUtilisateur_Id = 1,
                Sexe = "Homme",
                Mail = "john.doe@unknow.com",
                MotDePasse = "Test1234="
            };
            l = utilisateurServices.GetAll().ToList();
            //Console.WriteLine(utilisateurServices.Insert(utilisateur));

            //for (int i = 0; i < l.Count; i++)
            //{
            //    Console.WriteLine(l[i].Nom);
            //}

            ////Console.WriteLine(utilisateurServices.Get(9).Nom);
            ////Console.WriteLine(utilisateurServices.Delete(9));
            ////Console.ReadLine();
            //Console.WriteLine(utilisateurServices.CheckPassword("Test1234", "john.doe@unknow.com"));
        }
    }
}
