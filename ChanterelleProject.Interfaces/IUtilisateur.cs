using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IUtilisateur<TKey, TUtilisateur, TUtilisateurFullAttributeForView, TParaMedical>
        where TUtilisateurFullAttributeForView : IEntity<TKey> 
    {
        TKey InsertUtilisateur(TUtilisateur entity);
        bool UpdateUtilisateur(TKey key, TUtilisateur entity);
        bool DeleteUtilisateur(TKey key);
        TKey InsertParaMedical(TParaMedical entity);
        bool UpdateParaMedical(TKey key, TParaMedical entity);
        TUtilisateurFullAttributeForView Get(TKey key);
        IEnumerable<TUtilisateurFullAttributeForView> GetAll();
    }
}
