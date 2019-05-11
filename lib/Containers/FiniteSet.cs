//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static zfunc;

    public static class FiniteSet
    {
        /// <summary>
        /// Constructs a finite set from supplied members
        /// </summary>
        /// <param name="members">The defining members</param>
        /// <typeparam name="T">The member type</typeparam>
        /// <returns></returns>
        public static FiniteSet<T> define<T>(params T[] members)
            where T : ISemigroup<T>, new()
                => new FiniteSet<T>(members);

        /// <summary>
        /// Constructs a finite set from supplied sequence
        /// </summary>
        /// <param name="members">The defining members</param>
        /// <typeparam name="T">The member type</typeparam>
        /// <returns></returns>
        public static FiniteSet<T> define<T>(IEnumerable<T> members)
            where T : ISemigroup<T>, new()
                => new FiniteSet<T>(members);
    }    


    /// <summary>
    /// Contains a finite set of values
    /// </summary>
    public readonly struct FiniteSet<T> : IFiniteSet<FiniteSet<T>,T>
        where T : ISemigroup<T>, new()
    {
        static readonly IEqualityComparer<HashSet<T>> setcomparer = HashSet<T>.CreateSetComparer();        

        static HashSet<T> hashset(IEnumerable<T> members)
            => new HashSet<T>(members);

        public static implicit operator FiniteSet<T>(HashSet<T> src)
            => new FiniteSet<T>(src);

        readonly HashSet<T> data;


        [MethodImpl(Inline)]   
        public FiniteSet(IEnumerable<T> members)
            => this.data = hashset(members);

        [MethodImpl(Inline)]   
        public FiniteSet(HashSet<T> members)
            => this.data = members;

        public int Count 
            => data.Count;

        public bool IsEmpty 
            => Count == 0;

        public bool IsFinite
            => true;

        public bool IsDiscrete
            => true;
        

        [MethodImpl(Inline)]   
        public bool Equals(FiniteSet<T> other)
            => setcomparer.Equals(data, other.data);

        [MethodImpl(Inline)]   
        public bool IsMember(T candidate)
            => data.Contains(candidate);

        [MethodImpl(Inline)]   
        public bool IsMember(object candidate)
            => candidate is T ? IsMember((T)candidate) :false;

        
        public IEnumerable<T> Content
            => data;

        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]   
        public bool IsSubset(FiniteSet<T> rhs, bool proper = true)
            => proper ? data.IsProperSubsetOf(rhs.data) : data.IsSubsetOf(rhs.data);

        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]   
        public bool IsSuperset(FiniteSet<T> rhs, bool proper = true)
            => proper ? data.IsProperSupersetOf(rhs.data) : data.IsSubsetOf(rhs.data);

        /// <summary>
        /// Calculates the union between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to union/param>
        [MethodImpl(Inline)]   
        public FiniteSet<T> Union(FiniteSet<T> rhs)
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
        [MethodImpl(Inline)]   
        public FiniteSet<T> Intersect(FiniteSet<T> rhs)
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
        [MethodImpl(Inline)]   
        public FiniteSet<T> Difference(FiniteSet<T> rhs, bool symmetric = false)
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
        [MethodImpl(Inline)]   
        public bool intersects(FiniteSet<T> rhs)
            => data.Overlaps(rhs.data);

        /// <summary>
        /// Adjudicates equality between the current set and a specified set
        /// </summary>
        public bool eq(FiniteSet<T> rhs)
            => data.SetEquals(rhs.data);

        /// <summary>
        /// Adjudicates inequality between the current set and a specified set
        /// </summary>
        [MethodImpl(Inline)]   
        public bool neq(FiniteSet<T> rhs)
            => not(eq(rhs));

        [MethodImpl(Inline)]   
        public int hash()
            => data.GetHashCode();

    }
}