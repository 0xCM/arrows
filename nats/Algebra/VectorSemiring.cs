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
    
    using static nconst;
    using static nfunc;

    /// <summary>
    /// Reifies a semiring of vectors over a semiring of elements
    /// </summary>
    public readonly struct VectorSemiring<N, T> : ISemiringOps<Vector<N,T>>
        where N : ITypeNat, new()
        where T : struct, ISemiring<T> 
    {
        static VectorSemiring<N, T> Inhabitant = default;

        static readonly ISemiring<T> SR = new T();            

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
            =>  lhs.fuse(rhs, srAdd);

        [MethodImpl(Inline)]   
        public Vector<N, T> mul(Vector<N, T> lhs, Vector<N, T> rhs)
            =>  lhs.fuse(rhs, srMul);

        [MethodImpl(Inline)]   
        public Vector<N, T> distribute(Vector<N, T> lhs, (Vector<N, T> x, Vector<N, T> y) rhs)
            => add(mul(lhs, rhs.x), mul(lhs, rhs.y));


        [MethodImpl(Inline)]   
        public Vector<N, T> distribute((Vector<N, T> x, Vector<N, T> y) lhs, Vector<N, T> rhs)
            => add(mul(lhs.x, rhs), mul(lhs.y, rhs));

        [MethodImpl(Inline)]   
        public bool eq(Vector<N, T> lhs, Vector<N, T> rhs)
            => lhs.fuse(rhs, (x,y) => x.Equals(y)).any(x => x != true); 

        [MethodImpl(Inline)]   
        public bool neq(Vector<N, T> lhs, Vector<N, T> rhs)
            => !eq(lhs,rhs);

        [MethodImpl(Inline)]   
        public Covector<N, T> tranpose(Vector<N, T> src)
            => src.tranpose();

        public Vector<N, T> muladd(Vector<N, T> x, Vector<N, T> y, Vector<N, T> z)
            =>add(mul(x,y), z);
    }

}
