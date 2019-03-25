//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static corefunc;

    public class Setoid<T> : Traits.Setoid<DiscreteEqClass<T>, T>
        where T : IEquatable<T>

    {
        
        readonly Traits.FiniteSet<T> membership;
        
        readonly Traits.Equivalence<T> equivalence;
        
        readonly Slice<DiscreteEqClass<T>> parts;
        
        public Setoid(Traits.FiniteSet<T> data, Traits.Equivalence<T> equivalence)
        {
            this.membership = data;
            this.equivalence = equivalence;
            this.parts = equivalence.Partition(data.members()).ToSlice();

        }
        
        public bool empty 
            => false;

        public bool member(T candidate)
            => membership.member(candidate);

        public bool member(object candidate)
            => membership.member(candidate);

        public Seq<DiscreteEqClass<T>> partition()
            => parts.ToSeq();
    
        public DiscreteEqClass<T> project(T x)
            => parts.First(c => related(c.representative,x));

        public bool related(T x, T y)
            => equivalence.related(x,y);
    }
}