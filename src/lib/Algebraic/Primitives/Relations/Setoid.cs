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

    public class Setoid<T> : Traits.Setoid<FiniteEqClass<T>, T>
    {
        
        readonly Traits.FiniteSet<T> membership;
        
        readonly Traits.Equivalence<T> equivalence;
        
        readonly Slice<FiniteEqClass<T>> parts;
        
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

        public Seq<FiniteEqClass<T>> partition()
            => parts.ToSeq();
    
        public FiniteEqClass<T> project(T x)
            => parts.First(c => related(c.representative,x));

        public bool related(T x, T y)
            => equivalence.related(x,y);
    }
}