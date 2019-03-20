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
    public readonly struct TotalSet<T> : Set<TotalSet<T>, T>, Singleton<TotalSet<T>>
    {
        public static readonly TotalSet<T> Inhabitant = default;

        public TotalSet<T> inhabitant 
            => Inhabitant;

        public bool contains(T item) 
            => true;
    }

    /// <summary>
    /// Represents the universal empty set
    /// </summary>
    public readonly struct EmptySet : Set, Singleton<EmptySet>
    {
        public static readonly EmptySet Inhabitant = default;
        
        public EmptySet inhabitant 
            => Inhabitant;
    }

    /// <summary>
    /// Represents the set that contains no values of a specified type
    /// </summary>
    public readonly struct EmptySet<T> : Set<EmptySet<T>, T>, Singleton<EmptySet<T>>
    {
        public static readonly EmptySet<T> Inhabitant = default;

        public EmptySet<T> inhabitant 
            => Inhabitant;

        public bool contains(T item) 
            => false;
    }

    /// <summary>
    /// Represents the set of natural numbers
    /// </summary>
    public readonly struct N : Set<bigint>, DiscreteSet<bigint>
    {
        public bool contains(bigint item)
            => true;

        static IEnumerable<bigint> peano()
        {
            var next = new bigint(0);
            for(;;)                
                yield return next++;
        }

        public Enumerable<bigint> individuals()
            => peano().Reify();
    }

    /// <summary>
    /// Represents the set of integers
    /// </summary>
    public readonly struct Z : Set<Z>, Singleton<Z>
    {
        internal static readonly Z Inhabitant = default(Z);           
    
        public bool contains(Z item) => true;

        public Z inhabitant => Inhabitant;
    }

    /// <summary>
    /// Represents the set of rational numbers
    /// </summary>
    public readonly struct Q : Set<Q>, Singleton<Q>
    {
        internal static readonly Q Inhabitant = default(Q);

        public Q inhabitant => Inhabitant;

        public bool contains(Q item) => true;
    }

    /// <summary>
    /// Represents the set of real numbers
    /// </summary>
    public readonly struct R : Set<R>, Singleton<R>
    {
        internal static readonly R Inhabitant = default(R);
    
        public R inhabitant => Inhabitant;  

        public bool contains(R item) => true;  
    }

}