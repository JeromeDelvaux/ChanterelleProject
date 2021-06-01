using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.IRepository
{
    public interface IRepository<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {
        // Create
        TKey Insert(TEntity entity);

        // Read
        TEntity Get(TKey key);
        IEnumerable<TEntity> GetAll();

        // Update
        bool Update(TKey key, TEntity entity);

        // Delete
        bool Delete(TKey key);
    }
}
