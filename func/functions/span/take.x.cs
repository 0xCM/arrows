//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;
    using static As;

    partial class xfunc
    {
       [MethodImpl(Inline)]
        public static sbyte TakeInt8<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.Slice(offset).AsSBytes()[0];

        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.Slice(offset).AsBytes()[0];
        
        [MethodImpl(Inline)]
        public static short TakeInt16<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(ushort) ? src.Slice(offset).AsInt16()[0] : (short)0;

        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(ushort) ? src.Slice(offset).AsUInt16()[0] : (ushort)0;

        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(uint) ? src.Slice(offset).AsUInt32()[0] : 0;

        [MethodImpl(Inline)]
        public static int TakeInt32<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(int) ? src.Slice(offset).AsInt32()[0] : 0;

        [MethodImpl(Inline)]
        public static long TakeInt64<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => src.ByteCount(offset) >= sizeof(long) ? src.Slice(offset).AsInt64()[0] : 0;

        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct
                => src.ByteCount(offset) >= sizeof(ulong) ? src.Slice(offset).AsUInt64()[0] : 0;
                
        /// <summary>
        /// Counts the number of bytes stored in a span following an offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The offset value</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize ByteCount<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct        
                => (src.Length - offset) * Unsafe.SizeOf<T>();
        

       [MethodImpl(Inline)]
        public static sbyte TakeInt8<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeInt8(offset);

        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeUInt8(offset);
        
        [MethodImpl(Inline)]
        public static short TakeInt16<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeInt16(offset);

        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeUInt16(offset);

        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeUInt32(offset);

        [MethodImpl(Inline)]
        public static int TakeInt32<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeInt32(offset);

        [MethodImpl(Inline)]
        public static long TakeInt64<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeInt64(offset);

        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this Span<T> src, int offset = 0)
            where T : struct        
                => src.ReadOnly().TakeUInt64(offset);


 

    }

}