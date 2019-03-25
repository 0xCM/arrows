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
    public readonly struct FiniteEqClass<T> : Traits.FiniteEqClass<T>, IEquatable<FiniteEqClass<T>>
    {
        
        Traits.Equivalence<T> equivalence {get;}
        
        FiniteSet<T> membership {get;}

        public FiniteEqClass(T representative, Traits.Equivalence<T> equivalence, IEnumerable<T> members)
        {
            this.representative = representative;
            this.equivalence = equivalence;
            this.membership = members.ToFiniteSet();
        }

        public T representative {get;}

        public bool empty 
            => false;

        public int count => throw new NotImplementedException();

        public bool member(T candidate)
            => equivalence.related(representative, candidate);

        public bool member(object candidate)
            => candidate is T ? member((T)candidate) : false;



        public bool Equals(FiniteEqClass<T> other)
        {
            throw new NotImplementedException();
        }

        public Seq<T> members()
            => membership.members();

        public bool eq(T lhs, T rhs)
        {
            throw new NotImplementedException();
        }

        public bool neq(T lhs, T rhs)
        {
            throw new NotImplementedException();
        }
    }


}