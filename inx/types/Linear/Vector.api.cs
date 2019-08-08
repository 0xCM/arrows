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
                =>  Vector<N,T>.LoadAligned(Span256.AllocUnaligned<N,T>());

        
        [MethodImpl(Inline)]
        public static Vector<T> Alloc<T>(int minlen, T? fill = null)               
            where T : struct
                => Span256.AllocUnaligned<T>(minlen, fill);

        /// <summary>
        /// Allocates a vector of natural length and fills it with a specified value
        /// </summary>
        /// <param name="fill">The fill value</param>
        /// <param name="n">The length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> AllocFilled<N,T>(T fill, N n = default)
            where N : ITypeNat, new()
            where T : struct
                =>  Vector<N,T>.LoadAligned(Span256.AllocUnaligned<N,T>(fill));

        /// Loads a vector from an existing span of commensuate length (Non-allocating)
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(Span<T> src, N length = default)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.LoadAligned(src);
        
        /// <summary>
        /// Loads a vector from an natural span of commensuate length (Non-allocating)
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(Span<N,T> src)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.LoadAligned(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(N len, params T[] src)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.LoadAligned(src);

        /// <summary>
        /// Loads a natural span from a readonly span that is required to have
        /// the specified natural length. This operation replicates
        /// the source readonly span.
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> Load<N,T>(ReadOnlySpan<T> src, N length = default)
            where N : ITypeNat, new()
            where T : struct
                => Vector<N,T>.LoadAligned(src);

        [MethodImpl(Inline)]
        public static Vector<T> LoadUnaligned<T>(Span<T> src)
            where T : struct
                => Span256.LoadUnaligned(src);

        [MethodImpl(Inline)]
        public static Vector<T> LoadUnaligned<T>(ReadOnlySpan<T> src)
            where T : struct
                => Span256.LoadUnaligned(src.Replicate());

        [MethodImpl(Inline)]
        public static Vector<T> Zero<T>(int minlen)
            where T : struct
                => Alloc<T>(minlen);

        [MethodImpl(Inline)]
        public static Vector<T> Load<T>(Span256<T> src)
            where T : struct
                => new Vector<T>(src);                
                
        [MethodImpl(Inline)]
        public static Vector<T> Load<T>(ReadOnlySpan256<T> src)
            where T : struct
                => new Vector<T>(src); 


    }
}