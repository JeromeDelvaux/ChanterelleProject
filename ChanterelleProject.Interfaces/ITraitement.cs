using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface ITraitement<TKey, TEntity, TEntity2>
        where TEntity2 : IEntity<TKey>
    {
        TKey InsertTraitement(TEntity entity);
        bool UpdateTraitement(TKey key, TEntity entity);
        bool DeleteTraitement(TKey key);
        TEntity2 Get(TKey key);
        IEnumerable<TEntity2> GetAll();
    }
}
