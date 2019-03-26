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
        /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
        /// an equivalence relation
        /// </summary>
        /// <typeparam name="T">The classified type</typeparam>
        public interface EqClass<T> : NonempySet<T>
        {
            T representative {get;}
        }

        /// <summary>
        /// Characterizes a constructive equivalence class, i.e. an equivalence class 
        /// with enumerable content
        /// </summary>
        /// <typeparam name="T">The content type</typeparam>
        public interface DiscreteEqClass<T> : EqClass<T>, DiscreteSet<T> { }

        /// <summary>
        /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
        /// an equivalence relation
        /// </summary>
        /// <typeparam name="T">The classified type</typeparam>
        public interface FiniteEqClass<T> : DiscreteEqClass<T>, FiniteSet<T> { }

        /// <summary>
        ///  Characterizes a reflexive, symmetric and transitive binary relation over a set
        ///  that, consequently, effects a partition on said set
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Equivalence_relation</remarks>
        public interface Equivalence<T> : Reflexive<T>, Symmetric<T>, Transitive<T> { }

    }

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

        public bool finite
            => true;

        public bool discrete
            => true;

        public int count 
            => membership.count;

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


    }


}