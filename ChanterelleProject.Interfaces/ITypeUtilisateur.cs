using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface ITypeUtilisateur<TKey, TTypeUtilisateur>
        where TTypeUtilisateur : IEntity<TKey>
    {
        // Create
        TKey Insert(TTypeUtilisateur entity);

        // Update
        bool Update(TKey key, TTypeUtilisateur entity);

        // Delete
        bool Delete(TKey key);

        //Read
        TTypeUtilisateur Get(TKey key);
        IEnumerable<TTypeUtilisateur> GetAll();
    }
}
