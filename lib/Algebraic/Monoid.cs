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
        public static IMonoidalOps<T> additive<T>()
            where T : struct, IMonoidA<T> 
                => new Monoidal<T>((x,y) => x.add(y), default(T).zero);

        /// <summary>
        /// Reifies a monoidal operator predicated on multiplicative monoidal structure
        /// </summary>
        /// <typeparam name="T">The reification type of a multiplicative monoid</typeparam>
        [MethodImpl(Inline)]
        public static IMonoidalOps<T> multiplicative<T>()
            where T : struct, IMonoidM<T> 
                => new Monoidal<T>((x,y) => x.mul(y), default(T).one);

    }

    public readonly struct Monoidal<T> : IMonoidalOps<T>
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


    public readonly struct MonoidM<T> : IMonoidMOps<T>, IMonoidalOps<T>
        where T : IMonoidM<T>, new()
    {    

        static readonly IMonoidM<T>  exemplar = default;

        public T one 
            => exemplar.one;

        public T identity 
            => exemplar.one;

        [MethodImpl(Inline)]
        public T mul(T lhs, T rhs)
            => lhs.mul(rhs);

        [MethodImpl(Inline)]
        public bool eq(T lhs, T rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public T compose(T lhs, T rhs)
            => lhs.mul(rhs);
    }

    public readonly struct MonoidA<T> : IMonoidAOps<T>, IMonoidalOps<T>
        where T : IMonoidA<T>, new()
    {    
        static readonly IMonoidA<T> exemplar = default;

        public T zero 
            => exemplar.zero;

        public T identity 
            => exemplar.zero;

        [MethodImpl(Inline)]
        public bool nonzero(T x) 
            => !x.Equals(zero);

        [MethodImpl(Inline)]
        public T add(T lhs, T rhs) 
        => lhs.add(rhs);

        [MethodImpl(Inline)]
        public bool eq(T lhs, T rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public T compose(T lhs, T rhs)
            => lhs.add(rhs);

    }


}