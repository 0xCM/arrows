//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static corefunc;


    /// <summary>
    /// Defines the canonical reification of a discrete equivalence class
    /// </summary>
    public readonly struct DiscreteEqClass<T> : Traits.DiscreteEqClass<T>
        where T : IEquatable<T>
    {
        
        Traits.Equivalence<T> equivalence {get;}
        
        Seq<T> membership {get;}

        public DiscreteEqClass(T representative, Traits.Equivalence<T> equivalence, IEnumerable<T> members)
        {
            this.representative = representative;
            this.equivalence = equivalence;
            this.membership = Seq.define(members);
        }

        public T representative {get;}

        public bool empty 
            => false;

        public bool member(T candidate)
            => equivalence.related(representative, candidate);

        public bool member(object candidate)
            => candidate is T ? member((T)candidate) : false;

        public Seq<T> members()
            => membership;
    }


}