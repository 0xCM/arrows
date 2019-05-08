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

    partial class Operative
    {
        /// <summary>
        ///  Characterizes a reflexive, symmetric and transitive binary relation over a set
        ///  that, consequently, effects a partition on said set
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Equivalence_relation</remarks>
        public interface IEquivalenceOps<T> : IReflexiveOps<T>, ISymmetricOps<T>, ITransitiveOps<T> { }

    }

    partial class Structures
    {
        public interface IEquivalenceClass<T>
        {
            T representative {get;}
        }


        /// <summary>
        /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
        /// an equivalence relation
        /// </summary>
        /// <typeparam name="T">The classified type</typeparam>
        public interface IEquivalenceClass<S,T> : ISemigroup<S,T>, IEquivalenceClass<T>, INonempySet<S>
            where S : IEquivalenceClass<S,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a constructive equivalence class, i.e. an equivalence class 
        /// with enumerable content
        /// </summary>
        /// <typeparam name="T">The content type</typeparam>
        public interface IDiscreteEqivalenceClass<S,T> : IEquivalenceClass<S,T>, IDiscreteSet<S,T> 
            where S : IDiscreteEqivalenceClass<S,T>, new() { }

        /// <summary>
        /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
        /// an equivalence relation
        /// </summary>
        /// <typeparam name="T">The classified type</typeparam>
        public interface IFiniteEquivalenceClass<S,T> : IDiscreteEqivalenceClass<S,T>//, FiniteSet<S,T> 
            where S : IFiniteEquivalenceClass<S,T>, new()
        { }


    }

    partial class Reify
    {

        /// <summary>
        /// Defines the canonical reification of a discrete equivalence class
        /// </summary>
        public readonly struct FiniteEquivalenceClass<T> 
            : Structures.IDiscreteEqivalenceClass<FiniteEquivalenceClass<T>,T>,  
              Structures.ISemigroup<FiniteEquivalenceClass<T>>
                where T : Structures.ISemigroup<T>, new()
        {
                    
            Operative.IEquivalenceOps<T> equivalence {get;}
            
            FiniteSet<T> membership {get;}

            public FiniteEquivalenceClass(T representative, Operative.IEquivalenceOps<T> equivalence, IEnumerable<T> members)
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
}