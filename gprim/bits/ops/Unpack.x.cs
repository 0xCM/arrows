//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    
    using static zfunc;
    using static Bits;

    partial class BitX
    {

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static Span<byte> Unpack<T>(this T src, out Span<byte> dst)
            where T : struct
                => dst = Bytes.bytes(in src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> Unpack(this in byte src, out Span<Bit> dst)
            => unpack(in src, out dst);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> Unpack(this in ushort src, out Span<Bit> dst)
            => unpack(in src, out dst);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> Unpack(this in int src, out Span<Bit> dst)
            => unpack(in src, out dst);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> Unpack(this in ulong src, out Span<Bit> dst)
            => unpack(in src, out dst);

        public static Span<Bit> Unpack(this ReadOnlySpan<byte> src, out Span<Bit> dst)
        {            
            dst = span<Bit>(src.Length*8);
            var offset = 0;
            for(var i = 0; i<src.Length; i++, offset += 8)
                src[i].Unpack(out Span<Bit> _).CopyTo(dst.Slice(offset));
            return dst;
        }

        [MethodImpl(Inline)]        
        public static Span<Bit> Unpack(this Span<byte> src, out Span<Bit> dst)
            => src.ToReadOnlySpan().Unpack(out dst);


    }
}