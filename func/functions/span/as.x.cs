//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;
    using static As;

    partial class xfunc
    {

        /// <summary>
        /// Presents a readonly span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source span element type</typeparam>
        /// <typeparam name="T">The target span element type</typeparam>
        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> As<S,T>(this ReadOnlySpan<S> src)
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);                                    

        /// <summary>
        /// Presents a span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source span element type</typeparam>
        /// <typeparam name="T">The target span element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> As<S,T>(this Span<S> src)
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);                                    
        
        /// <summary>
        /// Reimagines a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);


        /// <summary>
        /// Reimagines a span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<sbyte> AsSBytes<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,sbyte>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of int16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<short> AsInt16<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,short>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of uint16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ushort> AsUInt16<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ushort>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of int32
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<int> AsInt32<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,int>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of uint32
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<uint> AsUInt32<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,uint>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of int64
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<long> AsInt64<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,long>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of uint64
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ulong> AsUInt64<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ulong>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of sbytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> AsSBytes<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,sbyte>(src);

       /// <summary>
        /// Reimagines a readonly span of generic values as a span of readonly bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of int16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> AsInt16<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,short>(src);

        /// <summary>
        /// Reimagines a readonly span of generic values as a readonly span of uint16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> AsUInt16<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ushort>(src);

        /// <summary>
        /// Reimagines a readonly span of generic values as a readonly span of int32
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> AsInt32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,int>(src);

        /// <summary>
        /// Reimagines a readonly span of generic values as a readonly span of uint32
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> AsUInt32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> AsInt64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,long>(src);
        
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> AsUInt64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ulong>(src);


        /// <summary>
        /// Reimagines a 256-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span256<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src.Unblock());

        /// <summary>
        /// Reimagines a 256-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span128<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src.Unblock());
    }
}