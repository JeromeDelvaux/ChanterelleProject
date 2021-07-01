using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IClasse<TKey, TEntity, TEntity2>
        where TEntity : IEntity<TKey>
        where TEntity2 : IEntity<TKey>
    {
        TKey InsertClasse(TEntity entity);
        bool UpdateClasse(TKey key, TEntity entity);
        bool DeleteClasse(TKey key);
        TEntity2 Get(TKey key);
        IEnumerable<TEntity2> GetAll();
    }
}
