//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zcore;

    /// <summary>
    /// Implementation of a basic multiset
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Multiset</remarks>
    public readonly struct Multiset<T>  : Structure.FiniteSet<Multiset<T>>
        where T : Operative.Ordered<T>,  new()        
        
    {
        static Operative.Ordered<T> Ops = new T();
        
        readonly SortedDictionary<T,int> data;

        public Multiset(IEnumerable<T> src)
        {            
            data = new SortedDictionary<T,int>(Ops.ToComparer());
            foreach(var item in src)
            {
                if(data.ContainsKey(item))
                    data[item] = ++data[item];
                else
                    data[item] = 1;
            }
        }

        public bool finite
            => true;

        public bool discrete
            => true;

        public int count 
            => data.Count;

        public bool empty 
            => count != 0;

        public bool member(T candidate)
            => data.ContainsKey(candidate);
        

        public bool member(object candidate)
            => candidate is T ? member((T)candidate) : false;

        public IEnumerable<(T item, int multiplicity)> multiplicities()
            => data.Select(x => (x.Key,x.Value));

        public Seq<T> members()
            => data.Keys.ToSeq();

        public bool Equals(Multiset<T> other)
            => throw new NotImplementedException();
   }
}
