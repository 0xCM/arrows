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
        public interface Semiring<T> : MonoidA<T>, MonoidM<T>, Distributive<T>
        {        
            
        }


    }

    partial class Structure
    {

         public interface Semiring<S> : MonoidA<S>, MonoidM<S>, Distributive<S>
         {

         }

        /// <summary>
        /// Characterizes semiring structure
        /// </summary>
        /// <typeparam name="S">The classified structure</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
         public interface Semiring<S,T> : Semiring<S>, MonoidA<S,T>, MonoidM<S,T>, Distributive<S,T>
            where S : Semiring<S,T>, new()
        {
            
        }            

    }

    partial class Reify
    {
        public readonly struct Semiring<T> : Operative.Semiring<T>
            where T : Structure.Semiring<T>, new()
        {
            static readonly Structure.Semiring<T> exemplar = new T();

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
        }
    }

}