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
    using System.Runtime.InteropServices;    
    using System.Diagnostics;    
    
    using static zfunc;

    public static class NatSpan
    {
        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> load<N,T>(ref T src, N len = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(ref src);

        /// <summary>
        ///  Injects a readonly source span into a readonly natural span without replication
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural lenght</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<N,T> load<N,T>(ref ReadOnlySpan<T> src, N len = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new ReadOnlySpan<N,T>(ref src);
 
        /// <summary>
        ///  Injects a readonly source span into a readonly natural span without replication
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural lenght</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> load<N,T>(ref Span<T> src, N len = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(ref src);

        [MethodImpl(Inline)]   
        public static Span<N,T> alloc<N,T>(T value = default(T)) 
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(value);


        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> replicate<N,T>(ReadOnlySpan<T> src, N len = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);


        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> replicate<N,T>(Span<N,T> src)    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);

        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> replicate<N,T>(ReadOnlySpan<N,T> src)    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);
    }
}