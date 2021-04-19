using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Distributed;
using zepllin.Interfaces;
using Newtonsoft.Json;
namespace zepllin.Extra
{
    public class JsonCache<C> : IJsonCache<C> where C : class 
    {
        private readonly IDistributedCache cachedist;
        public JsonCache(IDistributedCache cachedist)
        {
            this.cachedist = cachedist;
        }
        public IEnumerable<C> jsonCache(List<C> cache,string key,TimeSpan dt)
        {
            string serialize = JsonConvert.SerializeObject(cache);

            byte[] data = Encoding.UTF8.GetBytes(serialize);

            cachedist.Set(key, data, new DistributedCacheEntryOptions
            {
                SlidingExpiration = dt
            });
            byte[] gettingdatakey = cachedist.Get(key);

            string convertbytes = Encoding.UTF8.GetString(gettingdatakey);

            IEnumerable<C> deserializecategory = JsonConvert.DeserializeObject<IEnumerable<C>>(convertbytes);

            return deserializecategory.AsEnumerable();
        }
    }
}
