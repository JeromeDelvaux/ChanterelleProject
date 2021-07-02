using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IInscription<TKey, TEntity, TEntity2>
        where TEntity : IEntity<TKey>
        where TEntity2 : IEntity<TKey>
    {
        TKey InsertInscription(TEntity entity);
        bool UpdateInscription(TKey key, TEntity entity);
        bool DeleteInscription(TKey key);
        TEntity2 Get(TKey key);
        IEnumerable<TEntity2> GetAll();
    }
}
