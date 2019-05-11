//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    using bigint = intg<System.Numerics.BigInteger>;

    /// <summary>
    /// Represents the set that contains all potential values of a specified type
    /// </summary>
    public readonly struct TotalSet<T> : IMathSet<TotalSet<T>,T>
        where T : IEquatable<T>
    {
        public static readonly TotalSet<T> Inhabitant = default;

        public TotalSet<T> inhabitant 
            => Inhabitant;

        public bool IsEmpty 
            => false;

        public bool IsMember(T item) 
            => true;

        public bool IsFinite
            => false;

        public bool IsDiscrete
            => false;

        public bool IsMember(object candidate)
            => candidate is T ? true : false;

        public bool Equals(TotalSet<T> other)
            => true;

        public int hash()
            => 0;

        public bool eq(TotalSet<T> rhs)
            => true;

        public bool neq(TotalSet<T> rhs)
            => false;
    }

    /// <summary>
    /// Represents the universal empty set
    /// </summary>
    public readonly struct EmptySet : IMathSet
    {
        public static readonly EmptySet Inhabitant = default;

        public bool IsEmpty 
            => true;

        public bool IsFinite
            => true;

        public bool IsDiscrete
            => true;

        public EmptySet inhabitant 
            => Inhabitant;

        public bool IsMember(object candidate)
            => false;
    }

    /// <summary>
    /// Represents the set that contains no values of a specified type
    /// </summary>
    public readonly struct EmptySet<T> : IMathSet<EmptySet<T>, T>
        where T : IEquatable<T>
    {
        public static readonly EmptySet<T> Inhabitant = default;

        public EmptySet<T> inhabitant 
            => Inhabitant;

        public bool IsEmpty 
            => false;

        public bool IsFinite
            => true;

        public bool IsDiscrete
            => true;

        public bool eq(EmptySet<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool Equals(EmptySet<T> other)
            => true;

        public int hash()
            => 0;

        public bool IsMember(T item) 
            => false;

        public bool IsMember(object candidate)
            => (candidate is T) 
             ? IsMember((T)candidate) 
             : false;

        public bool neq(EmptySet<T> rhs)
            => false;
    }

    /// <summary>
    /// Represents the set of natural numbers
    /// </summary>
    public readonly struct N : IDiscreteSet<N,bigint>
    {
        internal static readonly N Inhabitant = default;

        public bool IsMember(bigint item)
            => item >= bigint.Zero;

        static IEnumerable<bigint> peano()
        {
            var p = new bigint(0);
            for(;;)               
                yield return p++;    
        }

        public bool IsEmpty 
            => false;

        public bool IsFinite
            => false;

        public bool IsDiscrete
            => true;

        public N inhabitant 
            => Inhabitant;

        public IEnumerable<bigint> Content 
            => peano();

        public Seq<bigint> members()
            => peano().ToSeq();

        public bool IsMember(object candidate)
            => candidate is bigint 
            ? IsMember((bigint)candidate) 
            : false;


        public bool Equals(N other)
            => true;

        public int hash()
            => 0;

        public bool eq(N rhs)
            => true;

        public bool neq(N rhs)
            => false;
    }

    /// <summary>
    /// Represents the set of integers
    /// </summary>
    public readonly struct Z : IDiscreteSet<Z,bigint>, IGroupAOps<bigint>
    {
        internal static readonly Z Inhabitant = default;
    
        public Z inhabitant 
            => Inhabitant;

        public bool IsEmpty 
            => false;

        public bool IsFinite
            => false;

        public bool IsDiscrete
            => true;

        public bigint zero 
            => bigint.Zero;

        IEnumerable<bigint> integers()
        {
            var p = new bigint(0);
            var n = new bigint(0);
            for(;;)               
            { 
                yield return p++;
                yield return --n;
            }
        }

        public IEnumerable<bigint> Content 
            => integers();
        
        public bigint add(bigint lhs, bigint rhs)
            => lhs + rhs;

        public bool IsMember(bigint item)
            => true;

        public bool eq(bigint lhs, bigint rhs)
            => lhs == rhs;

        public bigint negate(bigint x)
            => -x;

        public bool neq(bigint lhs, bigint rhs)
            => lhs != rhs;

        public bigint sub(bigint lhs, bigint rhs)
            => lhs - rhs;

        public bool IsMember(object candidate)
            => candidate is bigint;

        public bool Equals(Z other)
            => true;
        
        public bool eq(Z rhs)
            => true;

        public bool neq(Z rhs)
            => false;

        public bool nonzero(bigint x)
            => x.neq(x.zero);
    }

    /// <summary>
    /// Represents the set of rational numbers
    /// </summary>
    public readonly struct Q : IMathSet<Q>
    {
        internal static readonly Q Inhabitant = default(Q);

        public Q inhabitant 
            => Inhabitant;

        public bool IsEmpty 
            => false;

        public bool IsFinite
            => false;

        public bool IsDiscrete
            => true;

        public bool Equals(Q other)
            => true;

        public bool member(Q item) 
            => true;

        public bool IsMember(object candidate)
            => candidate is Q;
    }

    /// <summary>
    /// Represents the set of real numbers
    /// </summary>
    public readonly struct R : IMathSet<R>
    {
        internal static readonly R Inhabitant = default(R);
    
        public R inhabitant 
            => Inhabitant;  

        public bool IsEmpty 
            => false;

        public bool IsFinite
            => false;

        public bool IsDiscrete
            => false;

        public bool Equals(R other)
            => true;
 
        public bool member(R x) 
            => true;

        public bool IsMember(object x)
            => x is R;
    }

}