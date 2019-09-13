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
        [MethodImpl(Inline)]
        public static Vector<T> Alloc<T>(int minlen, T? fill = null)               
            where T : unmanaged        
                => new Vector<T>(MemorySpan.Alloc<T>(minlen, fill));

        [MethodImpl(Inline)]
        public static Vector<N,T> Alloc<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                =>  Alloc<T>((int)n.value);

        [MethodImpl(Inline)]
        public static Vector<N,T> Alloc<N,T>(N n, T fill)
            where N : ITypeNat, new()
            where T : unmanaged
                =>  Alloc<T>((int)n.value, fill);

        [MethodImpl(Inline)]
        public static Vector<T> Load<T>(T[] src)
            where T : unmanaged
                => new Vector<T>(src);

        /// <summary>
        /// Loads a vector of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(T[] src, N length = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => new Vector<N, T>(src);

        /// <summary>
        /// Loads a vector of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(N length, params T[] src)
            where N : ITypeNat, new()
            where T : unmanaged
                => new Vector<N, T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> Zero<N,T>()
            where N : ITypeNat, new()
            where T : unmanaged
                => Vector<N,T>.Zero;
    }

}