//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Operative;
    using static Structures;


    public readonly struct Semiring<T> : ISemiringOps<T>
        where T : ISemiring<T>, new()
    {
        static readonly ISemiring<T> exemplar = new T();

        public static readonly Semiring<T> Inhabitant = default;
        
        public T zero 
            => exemplar.zero;

        public T one 
            => exemplar.one;

        public bool nonzero(T x)
            => !x.Equals(zero);

        public T add(T lhs, T rhs)
            => lhs.add(rhs);

        public T distribute(T lhs, (T x, T y) rhs)
            => lhs.distributeL(rhs);

        public T distribute((T x, T y) lhs, T rhs)
            => rhs.distributeR(lhs);

        public bool eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        public T mul(T lhs, T rhs)
            => lhs.mul(rhs);

        public bool neq(T lhs, T rhs)
            => lhs.Equals(rhs);

        public T muladd(T x, T y, T z)
            => x.muladd(y,z);
    }

}