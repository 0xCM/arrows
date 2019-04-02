//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using static zcore;

    partial class Operative
    {

        /// <summary>
        /// Characterizes monoidal operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Monoid<T> : Semigroup<T>
        {


        }


        /// <summary>
        /// Characterizes multiplicative monoidal operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface MonoidM<T> : Monoid<T>, SemigroupM<T>, Unital<T>
        {

        }



        /// <summary>
        /// Characterizes additive monoidal operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface MonoidA<T> : Monoid<T>, SemigroupA<T>, Nullary<T>
        {
            

        }


    }   

    partial class Structure
    {
        public interface Monoid<S> : Semigroup<S>
        {

        }

        /// <summary>
        /// Characterizes monoidal structure
        /// </summary>
        /// <typeparam name="S">The classified structure</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface Monoid<S,T> : Monoid<S>, Semigroup<S,T>
            where S : Monoid<S,T>, new()
        {
            
        }            

        public interface MonoidM<S> : Monoid<S>, SemigroupM<S>, Unital<S>
        {

        }

        public interface MonoidA<S> : Monoid<S>, SemigroupA<S>, Nullary<S>
        {

        }

        /// <summary>
        /// Characterizes multiplicative monoidal structure
        /// </summary>
        /// <typeparam name="S">The classified structure</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface MonoidM<S,T> : MonoidM<S>, Monoid<S,T>, SemigroupM<S,T>
            where S : MonoidM<S,T>, new()
        {

        }            

        /// <summary>
        /// Characterizes additive monoidal structure
        /// </summary>
        /// <typeparam name="S">The classified structure</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface MonoidA<S,T> :  MonoidA<S>, Monoid<S,T>, SemigroupA<S,T>
            where S : MonoidA<S,T>, new()
        {

        }            

    }

    partial class Reify
    {
        public readonly struct MonoidM<T> : Operative.MonoidM<T>
            where T : Operative.MonoidM<T>, new()
        {    
            static readonly Operative.MonoidM<T> Ops = new T();

            public T one 
                => Ops.one;

            [MethodImpl(Inline)]
            public T mul(T lhs, T rhs)
                => Ops.mul(lhs,rhs);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs)
                => Ops.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs)
                => Ops.neq(lhs,rhs);


        }

        public readonly struct MonoidA<T> : Operative.MonoidA<T>
            where T : Operative.MonoidA<T>, new()
        {    
            static readonly Operative.MonoidA<T> Ops = new T();

            public T zero 
                => Ops.zero;

            [MethodImpl(Inline)]
            public bool nonzero(T a) 
                => Ops.eq(Ops.zero, a);

            [MethodImpl(Inline)]
            public T add(T a, T b) 
                => Ops.add(a,b);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => Ops.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => Ops.neq(lhs,rhs);


        }
    }

}