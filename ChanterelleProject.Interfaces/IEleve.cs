using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IEleve<TKey, TEntity, TEntity2>
        where TEntity : IEntity<TKey>
        where TEntity2 : IEntity<TKey>
    {
        TKey InsertEleve(TEntity entity);
        bool UpdateEleve(TKey key, TEntity entity);
        bool DeleteEleve(TKey key);
        TEntity2 Get(TKey key);
        IEnumerable<TEntity2> GetAll();
    }
}
