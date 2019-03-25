//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static corefunc;

    /// <summary>
    /// Contains a finite set of values
    /// </summary>
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

        public Seq<T> members()
            => Seq.define<T>(container);

    }




}