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

        public bool IsEmpty 
            => false;

        public bool IsFinite
            => true;

        public bool IsDiscrete
            => true;

        public IEnumerable<T> Members
            => membership.Content;

        IEnumerable<T> IDiscreteContainer<FiniteEquivalenceClass<T>, T>.Content 
            => Members;

        public bool IsMember(T candidate)
            => equivalence.related(representative, candidate);

        public bool IsMember(object candidate)
            => candidate is T ? IsMember((T)candidate) : false;


        public bool Equals(FiniteEquivalenceClass<T> rhs)
            => membership.Equals(rhs.membership);

    }
}