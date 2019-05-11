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

    using static Structures;

    using static zcore;
    using static Reify;


    public class Setoid<T> : ISetoid<FiniteEquivalenceClass<T>, T>
        where T : ISemigroup<T>, new()
    {        
        readonly FiniteSet<T> membership;
        
        readonly IEquivalenceOps<T> equivalence;
        
        readonly FiniteEquivalenceClass<T>[] parts;
        
        
        public Setoid()
        {
            this.membership = new FiniteSet<T>();
        }
        public Setoid(FiniteSet<T> data, IEquivalenceOps<T> equivalence)
        {
            this.membership = data;
            this.equivalence = equivalence;
            this.parts = equivalence.Partition(data.Content).ToArray();

        }
        
        public bool empty 
            => false;

         public bool finite
            => true;

        public bool discrete
            => true;

        public bool Equals(Setoid<T> rhs)
            => membership.eq(rhs.membership);

        public bool member(T candidate)
            => membership.IsMember(candidate);

        public bool member(object candidate)
            => membership.IsMember(candidate);

        public IEnumerable<FiniteEquivalenceClass<T>> partition()
            => parts;
    
        public FiniteEquivalenceClass<T> project(T x)
            => parts.First(c => related(c.representative,x));

        public bool related(T x, T y)
            => equivalence.related(x,y);
    }
}