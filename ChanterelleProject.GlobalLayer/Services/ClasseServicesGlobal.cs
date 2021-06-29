using ChanterelleProject.GlobalServices.Mappers;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using ConnectionDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChanterelleProject.GlobalServices.Services
{
    public class ClasseServicesGlobal : IClasse<int, ClasseGlobal, ClasseFullAttributeForViewGlobal>
    {
        private readonly IConnection _connection;

        public ClasseServicesGlobal(IConnection connection)
        {
            _connection = connection;
        }

        public bool DeleteClasse(int key)
        {
            int id;

            Commands command = new Commands("SP_ChtlePrj_DeleteClasse", true);
            command.AddParameter("@Id", key);

            id = _connection.ExecuteNonQuery(command);
            return id != 0;
        }

        public ClasseFullAttributeForViewGlobal Get(int key)
        {
            Commands command = new Commands("SP_ChtlePrj_GetClasseById", true);
            command.AddParameter("@Id", key);
            return _connection.ExecuteReader(command, sp => sp.ToClasseFullAttributeForViewGlobal()).SingleOrDefault();
        }

        public IEnumerable<ClasseFullAttributeForViewGlobal> GetAll()
        {
            Commands command = new Commands("SP_ChtlePrj_GetAllClasse", true);
            return _connection.ExecuteReader(command, sp => sp.ToClasseFullAttributeForViewGlobal());
        }

        public int InsertClasse(ClasseGlobal entity)
        {
            int? idNewClasseGlobal;

            Commands command = new Commands("SP_ChtlePrj_AddClasse", true);
            command.AddParameter("IntituleClasse", entity.IntituleClasse);
            command.AddParameter("NbEleveMax", entity.NbEleveMax);
            command.AddParameter("Utilisateur_Id", entity.Utilisateur_Id);

            idNewClasseGlobal = (int?)_connection.ExecuteScalar(command);

            return (command.ReturnValue == 0) ? idNewClasseGlobal.Value : -1;
        }

        public bool UpdateClasse(int key, ClasseGlobal entity)
        {
            Commands command = new Commands("SP_ChtlePrj_UpdateClasse", true);
            command.AddParameter("Id", key);
            command.AddParameter("IntituleClasse", entity.IntituleClasse);
            command.AddParameter("NbEleveMax", entity.NbEleveMax);
            command.AddParameter("Utilisateur_Id", entity.Utilisateur_Id);

            int nbRows = _connection.ExecuteNonQuery(command);
            return nbRows == 1;
        }
    }
}
