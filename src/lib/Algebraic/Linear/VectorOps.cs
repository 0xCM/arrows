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

    public static class Vector
    {

        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(Dim<N> dim, params T[] src) 
            where N : TypeNat, new() 
            where T : Equatable<T>, new()
                => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(Dim<N> dim, IEnumerable<T> src) 
            where N : TypeNat, new() 
            where T : Equatable<T>, new()
                => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(Dim<N> dim, IReadOnlyList<T> src) 
            where T : Equatable<T>, new()
            where N : TypeNat, new() 
                => new Vector<N,T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> define<N,T>(params T[] src) 
            where T : Equatable<T>, new()                
            where N : TypeNat, new() 
                => new Vector<N,T>(src);


        [MethodImpl(Inline)]
        public static Vector<N,T> add<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
            where N : TypeNat, new() 
            where T : Structure.Semiring<T>, new()
                => new Vector<N,T>(fuse(lhs,rhs, (x,y) => x.add(y)));

        [MethodImpl(Inline)]
        public static Vector<N,T> mul<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
            where N : TypeNat, new() 
            where T : Structure.Semiring<T>, new()
                =>  new Vector<N,T>(fuse(lhs,rhs, (x,y) => x.add(y)));

        [MethodImpl(Inline)]
        public static T sum<N,T>(Vector<N,T> x) 
            where N : TypeNat, new() 
            where T : Structure.Semiring<T>, new()
                => Slice.sum(x.cells);

        [MethodImpl(Inline)]
        public static Vector<N,T> NatVec<N,T>(this Z0.TypeNat<N> n, IEnumerable<T> components)
            where N : TypeNat, new()
            where T : Equatable<T>, new()                                
                => new Vector<N, T>(components);
    }

}