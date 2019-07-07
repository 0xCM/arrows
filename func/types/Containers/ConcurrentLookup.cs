//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IConcurrentLookup<K,V>
    {
        V Acquire(K key, Func<K,V> factory);
    }

    public static class ConcurrentLookup
    {
        [MethodImpl(Inline)]
        public static IConcurrentLookup<K,V> Cached<K,V>()
            => ConcurrentCache<K,V>.TheOnly;

        [MethodImpl(Inline)]
        public static IConcurrentLookup<K,V> New<K,V>()
            => new ConcurrentLookup<K, V>();
    }

    readonly struct ConcurrentCache<K,V> : IConcurrentLookup<K,V>
    {
        static readonly ConcurrentLookup<K,V> Index = new ConcurrentLookup<K, V>();
        
        public static readonly ConcurrentCache<K,V> TheOnly = default;

        [MethodImpl(Inline)]
        public V Acquire(K key, Func<K,V> factory)
            => Index.Acquire(key,factory);
    }

    class ConcurrentLookup<K,V> : IConcurrentLookup<K,V>
    {
        public static ConcurrentLookup<K,V> Create()
            => new ConcurrentLookup<K, V>();

        Dictionary<K,V> _index 
            = new Dictionary<K, V>();

        ConcurrentDictionary<object, SemaphoreSlim> _locks 
            = new ConcurrentDictionary<object, SemaphoreSlim>();
    
        /// <summary>
        /// Implements a thread-safe factory that should only create a value if the key does not exist
        /// </summary>
        /// <param name="key"></param>
        /// <param name="createItem"></param>
        /// <returns></returns>
        /// <remarks>This was derived from https://michaelscodingspot.com/cache-implementations-in-csharp-net/</remarks>
        async Task<V> GetOrCreate(K key, Func<Task<V>> createItem)
        {
            V cacheEntry;
    
            if (!_index.TryGetValue(key, out cacheEntry))// Look for cache key.
            {
                SemaphoreSlim mylock = _locks.GetOrAdd(key, k => new SemaphoreSlim(1, 1));
    
                await mylock.WaitAsync();
                try
                {
                    if (!_index.TryGetValue(key, out cacheEntry))
                    {
                        // Key not in cache, so get data.
                        cacheEntry = await createItem();
                        _index.Add(key, cacheEntry);
                    }
                }
                finally
                {
                    mylock.Release();
                }
                
            }
            return cacheEntry;
        }

        [MethodImpl(Inline)]
        public V Acquire(K key, Func<K,V> factory)
            => GetOrCreate(key, () => task(factory,key)).Result;
    }
}