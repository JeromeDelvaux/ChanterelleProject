using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IUtilisateur<TKey, TEntity, TEntity2, TEntity3>
        where TEntity2 : IEntity<TKey> 
    {
        TKey InsertUtilisateur(TEntity entity);
        bool UpdateUtilisateur(TKey key, TEntity entity);
        bool DeleteUtilisateur(TKey key);
        TKey InsertParaMedical(TEntity3 entity);
        bool UpdateParaMedical(TKey key, TEntity3 entity);
        TEntity2 Get(TKey key);
        IEnumerable<TEntity2> GetAll();
    }
}
