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
    using static Reify;

    partial class Structures
    {
        /// <summary>
        /// Characterizes a discrete partition over a discrete set and, consequently, 
        /// is a constructive presentation of an equivalence relation. In this context, a parition
        /// is a collection of mutually disjoint subsets of a given set whose union
        /// is recovers the original set
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Setoid</remarks>
        public interface Setoid<C,T> : QuotientSet<C,T>
            where C : DiscreteEqivalenceClass<C,T>, new()
            where T : Structure<T>, new()
        {

        }
    }

    public class Setoid<T> : Structures.Setoid<FiniteEquivalenceClass<T>, T>
        where T : Structure<T>, new()
    {
        
        readonly FiniteSet<T> membership;
        
        readonly Operative.Equivalence<T> equivalence;
        
        readonly Reify.FiniteEquivalenceClass<T>[] parts;
        
        
        public Setoid()
        {
            this.membership = new FiniteSet<T>();
        }
        public Setoid(FiniteSet<T> data, Operative.Equivalence<T> equivalence)
        {
            this.membership = data;
            this.equivalence = equivalence;
            this.parts = equivalence.Partition(data.members().content).ToArray();

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
            => membership.member(candidate);

        public bool member(object candidate)
            => membership.member(candidate);

        public IEnumerable<FiniteEquivalenceClass<T>> partition()
            => parts;
    
        public FiniteEquivalenceClass<T> project(T x)
            => parts.First(c => related(c.representative,x));

        public bool related(T x, T y)
            => equivalence.related(x,y);
    }
}