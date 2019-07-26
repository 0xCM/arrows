//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    

    public static class BitVector
    {   
        /// <summary>
        /// Creates a generic bitvector of natural length
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Define<N,T>(N len = default, in T src = default)        
            where N : ITypeNat, new()
            where T : struct
                => new BitVector<N,T>(src);

        /// <summary>
        /// Creates a generic bitvector over an arbitrary number of elements
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The element type</typeparam>
        public static BitVector<T> Define<T>(params T[] src)
            where T : struct
                => BitVector<T>.Define(src);

        public static BitVector<T> Counted<T>(BitSize bitcount, params T[] src)
            where T : struct
                => BitVector<T>.Define(bitcount, src);

    }


}