namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    public static class Vector
    {

        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(Dim<N> dim, params T[] src) 
                where N : TypeNat, new() => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(Dim<N> dim, IEnumerable<T> src) 
                where N : TypeNat, new() => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(Dim<N> dim, IReadOnlyList<T> src) 
                where N : TypeNat, new() => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(params T[] src) 
                where N : TypeNat, new() => new Vector<N,T>(src);


        [MethodImpl(Inline)]
        public static Vector<N,T> add<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
            where N : TypeNat, new() 
            where T : Traits.Semiring<T>, new()
                => Slice.add(lhs.cells,rhs.cells);

        [MethodImpl(Inline)]
        public static Vector<N,T> mul<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
            where N : TypeNat, new() 
            where T : Traits.Semiring<T>, new()
                => Slice.mul(lhs.cells,rhs.cells);

        [MethodImpl(Inline)]
        public static T sum<N,T>(Vector<N,T> x) 
            where N : TypeNat, new() 
            where T : Traits.Semiring<T>, new()
                => Slice.sum(x.cells);

        [MethodImpl(Inline)]
        public static Vector<N,T> NatVec<N,T>(this Z0.TypeNat<N> n, IEnumerable<T> components)
            where N : TypeNat, new()
                => new Vector<N, T>(components);
    }

    /// <summary>
    /// Reifies a semiring of vectors over a semiring of elements
    /// </summary>
    public readonly struct VectorSemiring<N, T> : Traits.Semiring<Vector<N,T>>
        where N : TypeNat, new()
        where T : Traits.Semiring<T>, new()
    {
        static VectorSemiring<N, T> Inhabitant = default;

        static readonly Traits.Semiring<T> SR = new T();

        public static Vector<N,T> Zero = vector<N,T>(SR.zero);

        public static Vector<N,T> One = vector<N,T>(SR.one);

        public Vector<N, T> zero 
            => Zero;

        public Vector<N, T> one 
            => One;

        public VectorSemiring<N, T> inhabitant 
            => Inhabitant;

        public Addition<Vector<N, T>> addition 
            => Addition.define(this);

        public Multiplication<Vector<N, T>> multiplication 
            => Multiplication.define(this);

        [MethodImpl(Inline)]   
        public Vector<N, T> add(Vector<N, T> lhs, Vector<N, T> rhs)
            => vector(dim<N>(), zip(lhs, rhs, SR.add));

        [MethodImpl(Inline)]   
        public Vector<N, T> mul(Vector<N, T> lhs, Vector<N, T> rhs)
            => vector(dim<N>(), zip(lhs,rhs, SR.mul));

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