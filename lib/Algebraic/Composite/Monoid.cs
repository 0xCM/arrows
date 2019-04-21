//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zcore;

    public static class Monoid
    {
        /// <summary>
        /// Reifies a monoidal operator predicated on additive monoidal structure
        /// </summary>
        /// <typeparam name="T">The reification type of an additive monoid</typeparam>
        [MethodImpl(Inline)]
        public static Operative.Monoidal<T> additive<T>()
            where T : struct, Structures.MonoidA<T> 
                => new Reify.Monoidal<T>((x,y) => x.add(y), default(T).zero);

        /// <summary>
        /// Reifies a monoidal operator predicated on multiplicative monoidal structure
        /// </summary>
        /// <typeparam name="T">The reification type of a multiplicative monoid</typeparam>
        [MethodImpl(Inline)]
        public static Operative.Monoidal<T> multiplicative<T>()
            where T : struct, Structures.MonoidM<T> 
                => new Reify.Monoidal<T>((x,y) => x.mul(y), default(T).one);

    }

    partial class Operative
    {

        /// <summary>
        /// Characterizes monoidal operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Monoid<T> : Semigroup<T>
        {


        }

        public interface Monoidal<T> : Monoid<T>
        {
            T identity {get;}
            
            T compose(T lhs, T rhs);
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

    partial class Structures
    {
        public interface Monoid<S> : Semigroup<S>
            where S : Monoid<S>, new()
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
            where S: MonoidM<S>, new()
        {

        }

        public interface MonoidA<S> : Monoid<S>, SemigroupA<S>, Nullary<S>
            where S : MonoidA<S>, new()
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

        public readonly struct Monoidal<T> : Operative.Monoidal<T>
            where T : struct, IEquatable<T> 
        {

            readonly Func<T,T,T> composer;
 
            public Monoidal(Func<T,T,T> composer, T identity)
            {
                this.composer = composer;
                this.identity = identity;
            }

            public T identity {get;}

            [MethodImpl(Inline)]
            public T compose(T lhs, T rhs)
                => composer(lhs,rhs);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs)
                => lhs.Equals(rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs)
                => !lhs.Equals(rhs);

        }


        public readonly struct MonoidM<T> : Operative.MonoidM<T>, Operative.Monoidal<T>
            where T : Structures.MonoidM<T>, new()
        {    

            static readonly Structures.MonoidM<T>  exemplar = default;

            public T one 
                => exemplar.one;

            public T identity 
                => exemplar.one;

            [MethodImpl(Inline)]
            public T mul(T lhs, T rhs)
                => lhs.mul(rhs);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => lhs.eq(rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => lhs.neq(rhs);

            [MethodImpl(Inline)]
            public T compose(T lhs, T rhs)
                => lhs.mul(rhs);
        }

        public readonly struct MonoidA<T> : Operative.MonoidA<T>, Operative.Monoidal<T>
            where T : Structures.MonoidA<T>, new()
        {    
            static readonly Structures.MonoidA<T> exemplar = default;

            public T zero 
                => exemplar.zero;

            public T identity 
                => exemplar.zero;

            [MethodImpl(Inline)]
            public bool nonzero(T x) 
                => x.eq(zero);

            [MethodImpl(Inline)]
            public T add(T lhs, T rhs) 
            => lhs.add(rhs);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => lhs.eq(rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => lhs.neq(rhs);

            [MethodImpl(Inline)]
            public T compose(T lhs, T rhs)
                => lhs.add(rhs);

        }
    }

}