using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IAllocationParaMedicals<TKey, TEntity, TEntity2>
        where TEntity2 : IEntity<TKey>
    {
        TKey InsertAllocationParaMedicals(TEntity entity);
        bool UpdateAllocationParaMedicals(TKey key, TEntity entity);
        bool DeleteAllocationParaMedicals(TKey key);
        TEntity2 Get(TKey key);
        IEnumerable<TEntity2> GetAll();
    }
}
