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
    using static nfunc;
    
    public static class NatSpan
    {        
        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<M,N,T> Load<M,N,T>(ref T src, M m = default, N n = default)    
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Span<M,N,T>(ref src);

        /// <summary>
        ///  Injects a readonly source span into a readonly natural span without replication
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural lenght</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<N,T> ReadOnly<N,T>(ref ReadOnlySpan<T> src, N len = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new ReadOnlySpan<N,T>(ref src);

        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> Load<N,T>(ReadOnlySpan<T> src, N len = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);

        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> Load<N,T>(ref T src, N len = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(ref src);

        [MethodImpl(Inline)]   
        public static ReadOnlySpan<M,N,T> Load<M,N,T>(ref ReadOnlySpan<T> src, N len = default(N))    
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new ReadOnlySpan<M,N,T>(ref src);

        [MethodImpl(Inline)]   
        public static Span<M,N,T> Load<M,N,T>(ReadOnlySpan<T> src, M m = default, N n = default)    
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Span<M,N,T>(src);

        [MethodImpl(Inline)]   
        public static Span<N,T> Load<N,T>(Span<T> src, N n = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);

        [MethodImpl(Inline)]   
        public static Span<N,T> Load<N,T>(Span<N,T> src, N n = default(N))    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);


        [MethodImpl(Inline)]   
        public static Span<M,N,T> Load<M,N,T>(Span<T> src, M m = default, N n = default)    
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Span<M,N,T>(src);

        [MethodImpl(Inline)]   
        public static Span<N,T> Alloc<N,T>(T value = default(T), N n = default) 
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(value);

        [MethodImpl(Inline)]   
        public static Span<M,N,T> Alloc<M,N,T>(T value = default(T), M m = default, N n = default) 
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Span<M,N,T>(value);

        [MethodImpl(Inline)]   
        public static Span<N,T> Zero<N,T>(N n = default) 
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(default(T));

        [MethodImpl(Inline)]   
        public static Span<M,N,T> Zero<M,N,T>(M m = default, N n = default) 
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Span<M,N,T>(default(T));

    }
}