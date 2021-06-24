using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IUtilisateurView<TKey, TEntity>
    {
        TEntity Get(TKey key);
        IEnumerable<TEntity> GetAll();
    }
}
