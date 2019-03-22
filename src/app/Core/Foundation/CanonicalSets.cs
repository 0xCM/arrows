//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;


    /// <summary>
    /// Represents the set that contains all potential values of a specified type
    /// </summary>
    public readonly struct TotalSet<T> : Traits.Set<TotalSet<T>, T>, Singleton<TotalSet<T>>
    {
        public static readonly TotalSet<T> Inhabitant = default;

        public TotalSet<T> inhabitant 
            => Inhabitant;

        public bool empty => false;

        public bool contains(T item) 
            => true;
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
    }

    /// <summary>
    /// Represents the set that contains no values of a specified type
    /// </summary>
    public readonly struct EmptySet<T> : Traits.Set<EmptySet<T>, T>, Singleton<EmptySet<T>>
    {
        public static readonly EmptySet<T> Inhabitant = default;

        public EmptySet<T> inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public bool contains(T item) 
            => false;
    }

    /// <summary>
    /// Represents the set of natural numbers
    /// </summary>
    public readonly struct N : Traits.DiscreteSet<bigint>, Singleton<N> 
    {
        internal static readonly N Inhabitant = default;

        public bool contains(bigint item)
            => true;

        static IEnumerable<bigint> peano()
        {
            var p = new bigint(0);
            for(;;)               
                yield return p++;
           
        }

        public bool empty => false;

        public N inhabitant 
            => Inhabitant;

        public Enumerable<bigint> individuals()
            => peano().Reify();
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

        public Func<bigint, bigint, bigint> addition 
            => add;

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

        public Enumerable<bigint> individuals()
            => integers().Reify();

        public bigint add(bigint lhs, bigint rhs)
            => lhs + rhs;

        public bool contains(bigint item)
            => true;

        public bool eq(bigint lhs, bigint rhs)
            => lhs == rhs;

        public bigint negate(bigint x)
            => -x;

        public bool neq(bigint lhs, bigint rhs)
            => lhs != rhs;

        public bigint sub(bigint lhs, bigint rhs)
            => lhs - rhs;

        bigint Traits.BinaryOp<bigint>.apply(bigint lhs, bigint rhs)
            => lhs + rhs;

        bigint Traits.Invertive<bigint>.invert(bigint x)
            => negate(x);
    }

    /// <summary>
    /// Represents the set of rational numbers
    /// </summary>
    public readonly struct Q : Traits.Set<Q>, Singleton<Q>
    {
        internal static readonly Q Inhabitant = default(Q);

        public Q inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public bool contains(Q item) 
            => true;
    }

    /// <summary>
    /// Represents the set of real numbers
    /// </summary>
    public readonly struct R : Traits.Set<R>, Singleton<R>
    {
        internal static readonly R Inhabitant = default(R);
    
        public R inhabitant => Inhabitant;  

        public bool empty => false;

        public bool contains(R item) => true;  
    }

}