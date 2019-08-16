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

    using static zfunc;

    public static class BitGrid
    {
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> Define<M,N,T>(M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => BitGrid<M,N,T>.Zeros();

        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> Define<M,N,T>(ReadOnlySpan<T> src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new BitGrid<M,N,T>(src); 

        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> Define<M,N,T>(Span<T> src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new BitGrid<M,N,T>(src); 

        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> Define<M,N,T>(M m = default, N n = default, params T[] src)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new BitGrid<M,N,T>(src); 

        /// <summary>
        /// Defines a bit layout grid as determined by specified type parameters
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        public static BitGridSpec<T> Specify<M,N,T>(M m = default, N n = default, T x = default)
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct
                => new BitGridSpec<T>(bitsize<T>(), m.value, n.value);


    }


}