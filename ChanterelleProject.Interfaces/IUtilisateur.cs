using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IUtilisateur<TKey, TEntity, TEntityFull>
        where TEntity : IEntity<TKey> 
    {
        // Create
        TKey Insert(TEntity entity);

        // Update
        bool Update(TKey key, TEntity entity);

        // Delete
        bool Delete(TKey key);

        //Read
        TEntityFull Get(TKey key);
        IEnumerable<TEntityFull> GetAll();
    }
}
