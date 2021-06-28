using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IServices<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {
        // Create
        TKey Insert(TEntity entity);

        // Update
        bool Update(TKey key, TEntity entity);

        // Delete
        bool Delete(TKey key);

        //Read
        TEntity Get(TKey key);
        IEnumerable<TEntity> GetAll();
    }
}
