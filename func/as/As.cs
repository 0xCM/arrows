//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static zfunc;

    public static partial class As
    {
        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span<T> cast<S,T>(in Span<S> src)                
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<T> cast<S,T>(in ReadOnlySpan<S> src)                
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span256<T> cast<S,T>(in Span256<S> src)                
            where S : struct
            where T : struct
                => Span256<T>.LoadAligned(MemoryMarshal.Cast<S,T>(src));

        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static ReadOnlySpan256<T> cast<S,T>(in ReadOnlySpan256<S> src)                
            where S : struct
            where T : struct
                => (ReadOnlySpan256<T>)MemoryMarshal.Cast<S,T>(src);
                
        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal static Span128<T> cast<S,T>(in Span128<S> src)                
            where S : struct
            where T : struct
                =>  Span128.Load(MemoryMarshal.Cast<S,T>(src));

        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        internal  static ReadOnlySpan128<T> cast<S,T>(in ReadOnlySpan128<S> src)                
            where S : struct
            where T : struct
                => (ReadOnlySpan128<T>)MemoryMarshal.Cast<S,T>(src);


        [MethodImpl(Inline)]
        public static ref T asRef<T>(in T src)
            => ref Unsafe.AsRef(in src);
        
        [MethodImpl(Inline)]
        public static ref T refAdd<T>(ref T src, int offset)
            => ref Unsafe.Add(ref src, offset);

        [MethodImpl(Inline)]
        public static ref T refAdd<T>(ref T src, IntPtr offset)
            => ref Unsafe.Add(ref src, offset);

        [MethodImpl(Inline)]
        public static ref T inAdd<T>(in T src, IntPtr offset)
            => ref Unsafe.Add(ref asRef(in src), offset);
    }
}