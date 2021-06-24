using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.Interfaces
{
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }
}
