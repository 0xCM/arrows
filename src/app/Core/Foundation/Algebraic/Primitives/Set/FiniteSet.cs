//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;



    public readonly struct FiniteSet<T> : Traits.FiniteSet<T>
    {
        readonly HashSet<T> container;
        
        public FiniteSet(IEnumerable<T> members)
            => this.container = new HashSet<T>(members);

        public int count 
            => container.Count;

        public bool empty 
            => count == 0;

        public bool member(T candidate)
            => container.Contains(candidate);

        public bool member(object candidate)
            => candidate is T ? member((T)candidate) :false;

        public Enumerable<T> members()
            => Enumerable.define<T>(container);
    }




}