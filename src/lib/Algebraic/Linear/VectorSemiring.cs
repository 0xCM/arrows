//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;


    partial class Reify
    {
        /// <summary>
        /// Reifies a semiring of vectors over a semiring of elements
        /// </summary>
        public readonly struct VectorSemiring<N, T> : Operative.Semiring<Vector<N,T>>
            where N : TypeNat, new()
            where T : Structure.Semiring<T>, new()
        {
            static VectorSemiring<N, T> Inhabitant = default;

            static readonly Structure.Semiring<T> SR = new T();            

            static readonly Func<T,T,T> srAdd = (x, y) => x.add(y);

            static readonly Func<T,T,T> srMul = (x, y) => x.mul(y);

            public static Vector<N,T> Zero = vector<N,T>(SR.zero);

            public static Vector<N,T> One = vector<N,T>(SR.one);

            public Vector<N, T> zero 
                => Zero;

            public Vector<N, T> one 
                => One;

            public bool nonzero(Vector<N, T> x)
                => x.eq(Zero);

            public VectorSemiring<N, T> inhabitant 
                => Inhabitant;


            [MethodImpl(Inline)]   
            public Vector<N, T> add(Vector<N, T> lhs, Vector<N, T> rhs)
                => vector(dim<N>(), fuse(lhs, rhs, srAdd));

            [MethodImpl(Inline)]   
            public Vector<N, T> mul(Vector<N, T> lhs, Vector<N, T> rhs)
                => vector(dim<N>(), fuse(lhs,rhs, srMul));

            [MethodImpl(Inline)]   
            public Vector<N, T> distribute(Vector<N, T> lhs, (Vector<N, T> x, Vector<N, T> y) rhs)
                => add(mul(lhs, rhs.x), mul(lhs, rhs.y));


            [MethodImpl(Inline)]   
            public Vector<N, T> distribute((Vector<N, T> x, Vector<N, T> y) lhs, Vector<N, T> rhs)
                => add(mul(lhs.x, rhs), mul(lhs.y, rhs));

            [MethodImpl(Inline)]   
            public bool eq(Vector<N, T> lhs, Vector<N, T> rhs)
                => any(zip(lhs,rhs), SR.neq);

            [MethodImpl(Inline)]   
            public bool neq(Vector<N, T> lhs, Vector<N, T> rhs)
                => not(eq(lhs,rhs));

            [MethodImpl(Inline)]   
            public Covector<N, T> tranpose(Vector<N, T> src)
                => src.tranpose();
        }

    }
}