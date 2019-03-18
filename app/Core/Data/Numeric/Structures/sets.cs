//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using static corefunc;

    using C = Contracts;

    /// <summary>
    /// Represents the set of natural numbers
    /// </summary>
    public readonly struct N : C.Set<bigint>, C.DiscreteSet<bigint>
    {
        public bool contains(bigint item)
            => true;

        static IEnumerable<bigint> peano()
        {
            var next = bigint(0);
            for(;;)                
                yield return next++;
        }

        public Enumerable<bigint> individuals()
            => peano().Reify();
    }

    /// <summary>
    /// Represents the set of integers
    /// </summary>
    public readonly struct Z : C.Set<Z>, C.Singleton<Z>
    {
        internal static readonly Z Inhabitant = default(Z);           
    
        public bool contains(Z item) => true;

        public Z inhabitant => Inhabitant;
    }

    /// <summary>
    /// Represents the set of rational numbers
    /// </summary>
    public readonly struct Q : C.Set<Q>, C.Singleton<Q>
    {
        internal static readonly Q Inhabitant = default(Q);

        public Q inhabitant => Inhabitant;

        public bool contains(Q item) => true;
    }

    /// <summary>
    /// Represents the set of real numbers
    /// </summary>
    public readonly struct R : C.Set<R>, C.Singleton<R>
    {
        internal static readonly R Inhabitant = default(R);
    
        public R inhabitant => Inhabitant;  

        public bool contains(R item) => true;  
    }


}