//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Operative
    {
         /// <summary>
        /// Characterizes semiring operations
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface ISemiringOps<T> : IMonoidAOps<T>, IMonoidMOps<T>, IDistributiveOps<T>
        {        
            T muladd(T x, T y, T z);            
        }


    }

    partial class Structures
    {

        /// <summary>
        /// Characterizes a semiring structure
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
         public interface Semiring<S> : IMonoidA<S>, IMonoidM<S>, IDistributive<S>
            where S : Semiring<S>, new()
         {
            S muladd(S y, S z);
         }


    }

    partial class Reify
    {
        public readonly struct Semiring<T> : Operative.ISemiringOps<T>
            where T : Structures.Semiring<T>, new()
        {
            static readonly Structures.Semiring<T> exemplar = new T();

            public static readonly Semiring<T> Inhabitant = default;
            
            public T zero 
                => exemplar.zero;

            public T one 
                => exemplar.one;

            public bool nonzero(T x)
                => x.eq(zero);

            public T add(T lhs, T rhs)
                => lhs.add(rhs);

            public T distribute(T lhs, (T x, T y) rhs)
                => lhs.distributeL(rhs);

            public T distribute((T x, T y) lhs, T rhs)
                => rhs.distributeR(lhs);

            public bool eq(T lhs, T rhs)
                => lhs.eq(rhs);

            public T mul(T lhs, T rhs)
                => lhs.mul(rhs);

            public bool neq(T lhs, T rhs)
                => lhs.neq(rhs);

            public T muladd(T x, T y, T z)
                => x.muladd(y,z);
        }
    }

}