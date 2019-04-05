//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Traits;
    using static zcore;

    /// <summary>
    /// Defines interal operations modulo N
    /// </summary>
    public readonly struct ModOps<N,T> : Operative.ModN<N,T>
        where N : TypeNat, new()
    {
        public static readonly ModOps<N,T> Inhabitant = default;
        
        static readonly Operative.Integer<T> Ops = Resolver.integer<T>();
        
        static readonly intg<T> @base =  natval<N>().ToIntG<T>();

        public IEnumerable<T> members 
            => range<T>(@base.zero.unwrap(), @base.dec().unwrap()).Unwrap();

        public T one 
            => @base.one;

        public T zero 
            => @base.zero;


        [MethodImpl(Inline)]
        public T reduce(T src) 
            => Ops.mod(src, @base);

        [MethodImpl(Inline)]
        public T add(T lhs, T rhs)
            => reduce(Ops.add(lhs,rhs));

        [MethodImpl(Inline)]
        public T distribute(T lhs, (T x, T y) rhs)
            => reduce(Ops.distribute(lhs, rhs));

        [MethodImpl(Inline)]
        public T distribute((T x, T y) lhs, T rhs)
            => reduce(Ops.distribute(lhs, rhs));

        [MethodImpl(Inline)]
        public T mul(T a, T b)
            => Ops.mul(a,b);

        [MethodImpl(Inline)]
        public T negate(T x)
            => Ops.abs(reduce(Ops.sub(Ops.zero, x)));

        [MethodImpl(Inline)]
        public T invert(T x)
            => negate(x);


        [MethodImpl(Inline)]
        public T sub(T lhs, T rhs)
            => Ops.mod(Ops.sub(lhs,rhs), @base);

        public bool eq(T lhs, T rhs)
            => Ops.eq(lhs,rhs);
 
        public bool neq(T lhs, T rhs)
            => Ops.neq(lhs,rhs);
    }
}