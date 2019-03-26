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
    public readonly struct ModOps<N,T> : ModN<N,T>,
        TypeClass
        <
            ModOps<N,T>,
            Integer<T>,
            ModN<N,T>
        >
        where N : TypeNat, new()
    {
        public static readonly ModOps<N,T> Inhabitant = default;
        
        static readonly Traits.Integer<T> Ops = ops<T,Integer<T>>();
        
        static readonly intg<T> @base =  natval<N>().ToIntG<T>();

        public IEnumerable<T> members 
            => range<T>(@base.zero, @base.dec()).Unwrap();

        public T one 
            => @base.one;

        public T zero 
            => @base.zero;


        public ModOps<N, T> inhabitant 
            => Inhabitant;

        public Addition<T> addition 
            => Addition.define(this);

        public Multiplication<T> multiplication 
            => Multiplication.define(this);

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
        public bool eq(T lhs, T rhs)
            => Ops.eq(reduce(lhs), reduce(rhs));

        [MethodImpl(Inline)]
        public T mul(T a, T b)
            => Ops.mul(a,b);

        [MethodImpl(Inline)]
        public T negate(T x)
            => Ops.abs(reduce(Ops.negate(x)));

        [MethodImpl(Inline)]
        public T invert(T x)
            => negate(x);

        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs)
            => Ops.neq(reduce(lhs), reduce(rhs));


        [MethodImpl(Inline)]
        public T sub(T lhs, T rhs)
            => Ops.mod(Ops.sub(lhs,rhs), @base);

        public T apply(T lhs, T rhs)
        {
            throw new NotImplementedException();
        }
    }

}