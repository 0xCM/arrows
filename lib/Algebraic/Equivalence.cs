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

    using static zcore;
    using static zfunc;


    /// <summary>
    /// Defines the canonical reification of a discrete equivalence class
    /// </summary>
    public readonly struct FiniteEquivalenceClass<T> 
        : IDiscreteEqivalenceClass<FiniteEquivalenceClass<T>,T>,  
            ISemigroup<FiniteEquivalenceClass<T>>
            where T : ISemigroup<T>, new()
    {
                
        IEquivalenceOps<T> equivalence {get;}
        
        FiniteSet<T> membership {get;}

        public FiniteEquivalenceClass(T representative, IEquivalenceOps<T> equivalence, IEnumerable<T> members)
        {
            this.representative = representative;
            this.equivalence = equivalence;
            this.membership = members.ToFiniteSet();
        }

        public T representative {get;}

        public bool empty 
            => false;

        public bool finite
            => true;

        public bool discrete
            => true;

        public int count 
            => membership.count;

        public IEnumerable<T> content 
            => membership.content;

        public bool member(T candidate)
            => equivalence.related(representative, candidate);

        public bool member(object candidate)
            => candidate is T ? member((T)candidate) : false;

        public IEnumerable<T> members()
            => membership.content;

        public bool eq(FiniteEquivalenceClass<T> lhs, FiniteEquivalenceClass<T> rhs)
            => lhs.membership.Equals(rhs.membership);

        public bool neq(FiniteEquivalenceClass<T> lhs, FiniteEquivalenceClass<T> rhs)
            => not(eq(lhs,rhs));

        public bool Equals(FiniteEquivalenceClass<T> rhs)
            => eq(this, rhs);

        public bool eq(FiniteEquivalenceClass<T> rhs)
            => membership.eq(rhs.membership);
        
        public bool neq(FiniteEquivalenceClass<T> rhs)
            => ! membership.eq(rhs.membership);

        public int hash()
            => membership.GetHashCode();
    }


}