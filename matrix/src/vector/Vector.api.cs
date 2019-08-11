//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    /// <summary>
    /// Defines the vector api surface
    /// </summary>
    public static class Vector
    {     
        /// <summary>
        /// Allocates a vector of natural length
        /// </summary>
        /// <param name="n">The length, to aid type inference</param>
        /// <param name="exemplar">An example value to aid type inference</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Alloc<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : struct
                =>  Vector<N,T>.LoadAligned(Span256.Alloc<N,T>());

        [MethodImpl(Inline)]
        public static Vector<N,T> Alloc<N,T>(N n, T fill)
            where N : ITypeNat, new()
            where T : struct
                =>  Vector<N,T>.LoadAligned(Span256.Alloc<N,T>(fill));

        
        [MethodImpl(Inline)]
        public static Vector<T> Alloc<T>(int minlen, T? fill = null)               
            where T : struct
                => Span256.Alloc<T>(minlen, fill);

        /// <summary>
        /// Loads a vector of natural length from a span that may not be aligned (Allocating if unaligned)
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(Span<T> src, N length = default)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.LoadAligned(Span256.Load(src));

        /// <summary>
        /// Loads a vector of natural length from a parameter array.
        /// This method allocates if the source array is not 256-bit aligned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(N length, params T[] src)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.LoadAligned(Span256.Load<T>(src));

        [MethodImpl(Inline)]
        public static Vector<T> Load<T>(Span<T> src)
            where T : struct
                => Span256.Load(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(Span<N,T> src)
            where N : ITypeNat, new()
            where T : struct
                => src;

        [MethodImpl(Inline)]
        public static Vector<T> Zero<T>(int minlen)
            where T : struct
                => Alloc<T>(minlen);
    }
}