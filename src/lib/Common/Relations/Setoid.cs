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

    partial class Traits
    {
        /// <summary>
        /// Characterizes a discrete partition over a discrete set and, consequently, 
        /// is a constructive presentation of an equivalence relation. In this context, a parition
        /// is a collection of mutually disjoint subsets of a given set whose union
        /// is recovers the original set
        /// </summary>
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Setoid</remarks>
        public interface Setoid<C,T> : QuotientSet<C,T>
            where C : DiscreteEqClass<T>
        {

        }
    }

    public class Setoid<T> : Traits.Setoid<FiniteEqClass<T>, T>
    {
        
        readonly Traits.FiniteSet<T> membership;
        
        readonly Traits.Equivalence<T> equivalence;
        
        readonly Slice<FiniteEqClass<T>> parts;
        
        public Setoid(Traits.FiniteSet<T> data, Traits.Equivalence<T> equivalence)
        {
            this.membership = data;
            this.equivalence = equivalence;
            this.parts = equivalence.Partition(data.members().stream()).ToSlice();

        }
        
        public bool empty 
            => false;

         public bool finite
            => true;

        public bool discrete
            => true;

        public bool member(T candidate)
            => membership.member(candidate);

        public bool member(object candidate)
            => membership.member(candidate);

        public Seq<FiniteEqClass<T>> partition()
            => parts.cells.ToSeq();
    
        public FiniteEqClass<T> project(T x)
            => parts.cells.First(c => related(c.representative,x));

        public bool related(T x, T y)
            => equivalence.related(x,y);
    }
}