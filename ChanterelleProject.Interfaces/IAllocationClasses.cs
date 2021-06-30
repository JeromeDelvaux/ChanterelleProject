using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IAllocationClasses<TKey, TEntity, TEntity2>
        where TEntity2 : IEntity<TKey>
    {
        TKey InsertAllocationClasses(TEntity entity);
        bool UpdateAllocationClasses(TKey key, TEntity entity);
        bool DeleteAllocationClasses(TKey key);
        TEntity2 Get(TKey key);
        IEnumerable<TEntity2> GetAll();
    }
}
