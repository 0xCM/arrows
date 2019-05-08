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
        public static Operative.IMonoidalOps<T> additive<T>()
            where T : struct, Structures.IMonoidA<T> 
                => new Reify.Monoidal<T>((x,y) => x.add(y), default(T).zero);

        /// <summary>
        /// Reifies a monoidal operator predicated on multiplicative monoidal structure
        /// </summary>
        /// <typeparam name="T">The reification type of a multiplicative monoid</typeparam>
        [MethodImpl(Inline)]
        public static Operative.IMonoidalOps<T> multiplicative<T>()
            where T : struct, Structures.IMonoidM<T> 
                => new Reify.Monoidal<T>((x,y) => x.mul(y), default(T).one);

    }

    partial class Operative
    {

        /// <summary>
        /// Characterizes monoidal operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface IMonoidOps<T> : ISemigroupOps<T>
        {


        }

        public interface IMonoidalOps<T> : IMonoidOps<T>
        {
            T identity {get;}
            
            T compose(T lhs, T rhs);
        }


        /// <summary>
        /// Characterizes multiplicative monoidal operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface IMonoidMOps<T> : IMonoidOps<T>, ISemigroupMOps<T>, IUnitalOps<T>
        {

        }



        /// <summary>
        /// Characterizes additive monoidal operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface IMonoidAOps<T> : IMonoidOps<T>, ISemigroupAOps<T>, INullaryOps<T>
        {
            

        }


    }   

    partial class Structures
    {
        public interface IMonoid<S> : ISemigroup<S>
            where S : IMonoid<S>, new()
        {

        }

        /// <summary>
        /// Characterizes monoidal structure
        /// </summary>
        /// <typeparam name="S">The classified structure</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface IMonoid<S,T> : IMonoid<S>, ISemigroup<S,T>
            where S : IMonoid<S,T>, new()
        {
            
        }            

        
        public interface IMonoidM<S> : IMonoid<S>, SemigroupM<S>, IUnital<S>
            where S: IMonoidM<S>, new()
        {

        }

        public interface IMonoidA<S> : IMonoid<S>, SemigroupA<S>, INullary<S>
            where S : IMonoidA<S>, new()
        {

        }

        /// <summary>
        /// Characterizes multiplicative monoidal structure
        /// </summary>
        /// <typeparam name="S">The classified structure</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface IMonoidM<S,T> : IMonoidM<S>, IMonoid<S,T>, ISemigroupM<S,T>
            where S : IMonoidM<S,T>, new()
        {

        }            

        /// <summary>
        /// Characterizes additive monoidal structure
        /// </summary>
        /// <typeparam name="S">The classified structure</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface IMonoidA<S,T> :  IMonoidA<S>, IMonoid<S,T>, ISemigroupA<S,T>
            where S : IMonoidA<S,T>, new()
        {

        }            

    }

    partial class Reify
    {

        public readonly struct Monoidal<T> : Operative.IMonoidalOps<T>
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


        public readonly struct MonoidM<T> : Operative.IMonoidMOps<T>, Operative.IMonoidalOps<T>
            where T : Structures.IMonoidM<T>, new()
        {    

            static readonly Structures.IMonoidM<T>  exemplar = default;

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

        public readonly struct MonoidA<T> : Operative.IMonoidAOps<T>, Operative.IMonoidalOps<T>
            where T : Structures.IMonoidA<T>, new()
        {    
            static readonly Structures.IMonoidA<T> exemplar = default;

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