//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;


    using static zfunc;    

    public static class BitVector
    {
        /// <summary>
        /// Creates a generic bitvector from a source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Define<T>(in T src)        
            where T : struct
                => new BitVector<T>(in src);

        /// <summary>
        /// Creates a natural bitvector from a 1-element source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(ref T src, N rep = default)        
            where T : struct
            where N : INatPow2, new()
                => BitVector<N,T>.Load(ref src);

        /// <summary>
        /// Creates a natural bitvector from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Define<N,T>(in ReadOnlySpan<T> src, N len = default(N))        
            where T : struct
            where N : INatPow2, new()
                => BitVector<N,T>.Define(in src);



    }

}