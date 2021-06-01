using System;
using System.Collections.Generic;
using System.Text;

namespace PatternRepository.IRepository
{
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }
}
