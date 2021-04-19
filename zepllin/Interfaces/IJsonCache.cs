using System;
using System.Collections.Generic;
namespace zepllin.Interfaces
{
    public interface IJsonCache<C>
    {
        IEnumerable<C> jsonCache(List<C> cache,string key,TimeSpan dt);
    }
}
