//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zcore;

    partial class Traits
    {

        /// <summary>
        /// Characteriizes a set that contains a finite number of values
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        public interface FiniteSet<T> : DiscreteSet<T>
        {
            /// <summary>
            /// Evidence that the set is indeed finite
            /// </summary>
            int count {get;}

        }

        /// <summary>
        /// Characteriizes a reified set that contains a finite number of values
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="T">The member type</typeparam>
        public interface FiniteSet<S,T> : FiniteSet<T>, DiscreteSet<S,T>, IEquatable<S>
            where S : FiniteSet<S,T>, new()
        {

            /// <summary>
            /// Determines whether the current set is a subset of a specified set.
            /// </summary>
            /// <param name="rhs">The candidate superset</param>
            /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
            bool subset(S rhs, bool proper = true);
            
            /// <summary>
            /// Determines whether the current set is a superset of a specified set.
            /// </summary>
            /// <param name="rhs">The candidate subset</param>
            /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
            /// <returns></returns>
            bool superset(S rhs, bool proper = true);

            /// <summary>
            /// Calculates the union between the current set and a specified set and
            /// returns a new set that embodies this result
            /// </summary>
            /// <param name="rhs">The set with which to union/param>
            S union(S rhs);
            
            /// <summary>
            /// Calculates the intersection between the current set and a specified set and
            /// returns a new set that embodies this result
            /// </summary>
            /// <param name="rhs">The set with which to intersect</param>
            S intersect(S rhs);
            
            /// <summary>
            /// Calculates the set difference, or symmetric difference, between the current 
            /// set and a specified set and returns a new set that embodies this result
            /// </summary>
            /// <param name="rhs">The set that should be differenced</param>
            /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
            S difference(S rhs, bool symmetric = false);

        }


    }

    /// <summary>
    /// Contains a finite set of values
    /// </summary>
    public readonly struct FiniteSet<T> : Traits.FiniteSet<FiniteSet<T>,T>
    {
        static readonly IEqualityComparer<HashSet<T>> setcomparer = HashSet<T>.CreateSetComparer();

        static HashSet<T> hashset(IEnumerable<T> members)
            => new HashSet<T>(members, ops<T,Traits.Equatable<T>>().ToEqualityComparer());

        public static implicit operator FiniteSet<T>(HashSet<T> src)
            => new FiniteSet<T>(src);

        readonly HashSet<T> data;


        public FiniteSet(IEnumerable<T> members)
            => this.data = hashset(members);

        public FiniteSet(HashSet<T> members)
            => this.data = members;

        public int count 
            => data.Count;

        public bool empty 
            => count == 0;

        public bool finite
            => true;

        public bool discrete
            => true;

        public bool Equals(FiniteSet<T> other)
            => setcomparer.Equals(data, other.data);

        public bool member(T candidate)
            => data.Contains(candidate);

        public bool member(object candidate)
            => candidate is T ? member((T)candidate) :false;

        public Seq<T> members()
            => Seq.define<T>(data);

        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        /// <returns></returns>
        public bool subset(FiniteSet<T> rhs, bool proper = true)
            => proper ? data.IsProperSubsetOf(rhs.data) : data.IsSubsetOf(rhs.data);

        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        /// <returns></returns>
        public bool superset(FiniteSet<T> rhs, bool proper = true)
            => proper ? data.IsProperSupersetOf(rhs.data) : data.IsSubsetOf(rhs.data);

        /// <summary>
        /// Calculates the union between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to union/param>
        public FiniteSet<T> union(FiniteSet<T> rhs)
        {
            var result = hashset(data);
            result.UnionWith(rhs.data);
            return result;
        }

        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to intersect</param>
        public FiniteSet<T> intersect(FiniteSet<T> rhs)
        {
            var result = hashset(data);
            result.IntersectWith(rhs.data);
            return result;
        }

        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current 
        /// set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        public FiniteSet<T> difference(FiniteSet<T> rhs, bool symmetric = false)
        {
            var result = hashset(data);
            if(symmetric)
                result.SymmetricExceptWith(rhs.data);
            else
                result.ExceptWith(rhs.data);
            return result;
        }

    
        /// <summary>
        /// Determine whether the current set and a specified set have a nonemtpy intersection
        /// </summary>
        /// <param name="rhs">The set to compare</param>
        /// <returns></returns>
        public bool intersects(FiniteSet<T> rhs)
            => data.Overlaps(rhs.data);        
    }
}