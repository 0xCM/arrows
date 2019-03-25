//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;


    /// <summary>
    /// Represents the set that contains all potential values of a specified type
    /// </summary>
    public readonly struct TotalSet<T> : Traits.Set<TotalSet<T>, T>, Singleton<TotalSet<T>>
        where T : IEquatable<T>
    {
        public static readonly TotalSet<T> Inhabitant = default;

        public TotalSet<T> inhabitant 
            => Inhabitant;

        public bool empty => false;

        public bool member(T item) 
            => true;

        public bool member(object candidate)
            => candidate is T ? true : false;
    }

    /// <summary>
    /// Represents the universal empty set
    /// </summary>
    public readonly struct EmptySet : Traits.Set, Singleton<EmptySet>
    {
        public static readonly EmptySet Inhabitant = default;

        public bool empty => true;

        public EmptySet inhabitant 
            => Inhabitant;

        public bool member(object candidate)
            => false;
    }

    /// <summary>
    /// Represents the set that contains no values of a specified type
    /// </summary>
    public readonly struct EmptySet<T> : Traits.Set<EmptySet<T>, T>, Singleton<EmptySet<T>>
        where T : IEquatable<T>
    {
        public static readonly EmptySet<T> Inhabitant = default;

        public EmptySet<T> inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public bool member(T item) 
            => false;

        public bool member(object candidate)
            => (candidate is T) 
             ? member((T)candidate) 
             : false;
    }

    /// <summary>
    /// Represents the set of natural numbers
    /// </summary>
    public readonly struct N : Traits.DiscreteSet<bigint>, Singleton<N> 
    {
        internal static readonly N Inhabitant = default;

        public bool member(bigint item)
            => item >= bigint.Zero;

        static IEnumerable<bigint> peano()
        {
            var p = new bigint(0);
            for(;;)               
                yield return p++;
    
        }

        public bool empty 
            => false;

        public N inhabitant 
            => Inhabitant;

        public Seq<bigint> members()
            => peano().Reify();

        public bool member(object candidate)
            => candidate is bigint 
            ? member((bigint)candidate) 
            : false;
    }

    /// <summary>
    /// Represents the set of integers
    /// </summary>
    public readonly struct Z : Traits.DiscreteSet<bigint>, Traits.GroupA<bigint>,  Singleton<Z> 
    {
        internal static readonly Z Inhabitant = default;
    
        public Z inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public Addition<bigint> addition 
            => Addition.define(this);

        public bigint zero 
            => bigint.Zero;

        public IEnumerable<bigint> integers()
        {
            var p = new bigint(0);
            var n = new bigint(0);
            for(;;)               
            { 
                yield return p++;
                yield return --n;
            }
        }

        public Seq<bigint> members()
            => integers().Reify();

        public bigint add(bigint lhs, bigint rhs)
            => lhs + rhs;

        public bool member(bigint item)
            => true;

        public bool eq(bigint lhs, bigint rhs)
            => lhs == rhs;

        public bigint negate(bigint x)
            => -x;

        public bool neq(bigint lhs, bigint rhs)
            => lhs != rhs;

        public bigint sub(bigint lhs, bigint rhs)
            => lhs - rhs;

        public bool member(object candidate)
            => candidate is bigint;
    }

    /// <summary>
    /// Represents the set of rational numbers
    /// </summary>
    public readonly struct Q : Traits.Set<Q>, Singleton<Q>, IEquatable<Q>
    {
        internal static readonly Q Inhabitant = default(Q);

        public Q inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public bool Equals(Q other)
            => true;

        public bool member(Q item) 
            => true;

        public bool member(object candidate)
            => candidate is Q;
    }

    /// <summary>
    /// Represents the set of real numbers
    /// </summary>
    public readonly struct R : Traits.Set<R>, Singleton<R>, IEquatable<R>
    {
        internal static readonly R Inhabitant = default(R);
    
        public R inhabitant 
            => Inhabitant;  

        public bool empty 
            => false;

        public bool member(R x) 
            => true;

        public bool Equals(R rhs)
            => true;

        public bool member(object x)
            => x is R;
    }

}