//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;

    using static corefunc;

    partial class Traits
    {

        public interface ModN<N,T> : Traits.Ring<T>
            where N : TypeNat
            where T : new()
        {

            IEnumerable<T> members {get;}
        }

    }

    partial class Reify
    {
 
        
        public readonly struct ModN<N,T> : Traits.ModN<N,T>, Singleton<ModN<N,T>>
            where N : TypeNat
            where T : new()
        {
            public static readonly ModN<N,T> Inhabitant = default;
            
            static readonly Traits.Integer<T> Ops = ops<T,Traits.Integer<T>>();
            
            static readonly intg<T> @base =  natval<N>().ToIntG<T>();

            static T reduce(T src) => Ops.mod(src, @base);

            public IEnumerable<T> members 
                => range<T>(@base.zero, @base.dec());

            public T one 
                => @base.one;

            public T add(T lhs, T rhs)
                => reduce(Ops.add(lhs,rhs));

            public Func<T, T, T> addition 
                => add;

            public T zero 
                => @base.zero;

            public Func<T, T, T> multiplication 
                => mul;

            public ModN<N, T> inhabitant 
                => Inhabitant;

            public T distribute(T lhs, (T x, T y) rhs)
                => reduce(Ops.distribute(lhs, rhs));

            public T distribute((T x, T y) lhs, T rhs)
                => reduce(Ops.distribute(lhs, rhs));

            public bool eq(T lhs, T rhs)
                => Ops.eq(reduce(lhs), reduce(rhs));

            public T mul(T a, T b)
                => Ops.mul(a,b);

            public T negate(T x)
                => Ops.abs(reduce(Ops.negate(x)));

            public T invert(T x)
                => negate(x);

            public bool neq(T lhs, T rhs)
                => Ops.neq(reduce(lhs), reduce(rhs));


            public T sub(T lhs, T rhs)
                => Ops.mod(Ops.sub(lhs,rhs), @base);

            public T apply(T lhs, T rhs)
            {
                throw new NotImplementedException();
            }

        }
    }
}

