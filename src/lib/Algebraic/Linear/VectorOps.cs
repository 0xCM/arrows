namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static corefunc;

    public static class VectorSemiring
    {
        public static VectorOps<N,T> define<N,T>()
            where N : TypeNat, new()
                => CVectorSemiring<N,T>.Inhabitant.instance();
    }

    readonly struct CVectorSemiring<N, T> : TypeClass<CVectorSemiring<N, T>,VectorOps<N, T>, TVectorSemiring<N, T>>
        where N : TypeNat, new()
    {
        public static readonly CVectorSemiring<N, T> Inhabitant = default;

        public CVectorSemiring<N, T> inhabitant 
            => Inhabitant;

        public VectorOps<N, T> instance()
            => VectorOps<N,T>.Inhabitant;
    }

    public readonly struct VectorOps<N, T> : TVectorSemiring<N, T>
        where N : TypeNat, new()
    {
        public static VectorOps<N, T> Inhabitant = default;

        static readonly Traits.Semiring<T> Semiring = ops<T,Traits.Semiring<T>>();

        public Addition<Vector<N, T>> addition 
            => Addition.define(this);

        public Vector<N, T> zero 
            => vector<N,T>(Semiring.zero);

        public Vector<N, T> one 
            => vector<N,T>(Semiring.one);

        public Multiplication<Vector<N, T>> multiplication 
            => Multiplication.define(this);

        public VectorOps<N, T> inhabitant 
            => Inhabitant;

        [MethodImpl(Inline)]   
        public Vector<N, T> add(Vector<N, T> lhs, Vector<N, T> rhs)
            => vector<N,T>(zip(lhs, rhs, Semiring.add));

        [MethodImpl(Inline)]   
        public Vector<N, T> mul(Vector<N, T> lhs, Vector<N, T> rhs)
            => vector<N,T>(zip(lhs,rhs, Semiring.mul));

        [MethodImpl(Inline)]   
        public Vector<N, T> distribute(Vector<N, T> lhs, (Vector<N, T> x, Vector<N, T> y) rhs)
            => add(mul(lhs, rhs.x), mul(lhs, rhs.y));


        [MethodImpl(Inline)]   
        public Vector<N, T> distribute((Vector<N, T> x, Vector<N, T> y) lhs, Vector<N, T> rhs)
            => add(mul(lhs.x, rhs), mul(lhs.y, rhs));

        [MethodImpl(Inline)]   
        public bool eq(Vector<N, T> lhs, Vector<N, T> rhs)
            => any(zip(lhs,rhs), Semiring.neq);

        [MethodImpl(Inline)]   
        public bool neq(Vector<N, T> lhs, Vector<N, T> rhs)
            => not(eq(lhs,rhs));

        public Covector<N, T> tranpose(Vector<N, T> src)
            => src.tranpose();
    }
}