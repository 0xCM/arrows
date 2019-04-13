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
    public readonly struct TotalSet<T> : Contain.Set<TotalSet<T>,T>
        where T : IEquatable<T>
    {
        public static readonly TotalSet<T> Inhabitant = default;

        public TotalSet<T> inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public bool member(T item) 
            => true;

        public bool finite
            => false;

        public bool discrete
            => false;

        public bool member(object candidate)
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
    public readonly struct EmptySet : Contain.Set
    {
        public static readonly EmptySet Inhabitant = default;

        public bool empty 
            => true;

        public bool finite
            => true;

        public bool discrete
            => true;

        public EmptySet inhabitant 
            => Inhabitant;

        public bool member(object candidate)
            => false;
    }

    /// <summary>
    /// Represents the set that contains no values of a specified type
    /// </summary>
    public readonly struct EmptySet<T> : Contain.Set<EmptySet<T>, T>
        where T : IEquatable<T>
    {
        public static readonly EmptySet<T> Inhabitant = default;

        public EmptySet<T> inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public bool finite
            => true;

        public bool discrete
            => true;

        public bool eq(EmptySet<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool Equals(EmptySet<T> other)
            => true;

        public int hash()
            => 0;

        public bool member(T item) 
            => false;

        public bool member(object candidate)
            => (candidate is T) 
             ? member((T)candidate) 
             : false;

        public bool neq(EmptySet<T> rhs)
            => false;
    }

    /// <summary>
    /// Represents the set of natural numbers
    /// </summary>
    public readonly struct N : Contain.DiscreteSet<N,bigint>
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

        public bool finite
            => false;

        public bool discrete
            => true;

        public N inhabitant 
            => Inhabitant;

        public IEnumerable<bigint> content 
            => peano();

        public Seq<bigint> members()
            => peano().ToSeq();

        public bool member(object candidate)
            => candidate is bigint 
            ? member((bigint)candidate) 
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
    public readonly struct Z : Contain.DiscreteSet<Z,bigint>, Operative.GroupA<bigint>
    {
        internal static readonly Z Inhabitant = default;
    
        public Z inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public bool finite
            => false;

        public bool discrete
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

        public IEnumerable<bigint> content 
            => integers();
        
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
    public readonly struct Q : Contain.Set<Q>
    {
        internal static readonly Q Inhabitant = default(Q);

        public Q inhabitant 
            => Inhabitant;

        public bool empty 
            => false;

        public bool finite
            => false;

        public bool discrete
            => true;

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
    public readonly struct R : Contain.Set<R>
    {
        internal static readonly R Inhabitant = default(R);
    
        public R inhabitant 
            => Inhabitant;  

        public bool empty 
            => false;

        public bool finite
            => false;

        public bool discrete
            => false;

        public bool Equals(R other)
            => true;
 
        public bool member(R x) 
            => true;

        public bool member(object x)
            => x is R;
    }

}