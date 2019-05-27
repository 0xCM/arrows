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
    
    using static zfunc;
    using static Bits;


    public static class BitSpanX
    {
        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBitSpan(this in byte src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBitSpan(this in ushort src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBitSpan(this in int src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBitsSpan(this in ulong src)
            => bitspan(src);

        /// <summary>
        /// Consructs a bit sream from a stream of bools
        /// </summary>
        /// <param name="src">The bitstring source</param>
        public static Span<Bit> ToBitSpan(this ReadOnlySpan<bool> src)
        {
            var dst = span<Bit>(src.Length);
            for(var i = 0; i < src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static Bit ToBit(this BinaryDigit digit)
            => digit == BinaryDigit.One;


        [MethodImpl(Optimize)]
        public static Span<Bit> ToBitSpan(this ReadOnlySpan<BinaryDigit> src)
        {
            var dst = span<Bit>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i].ToBit();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit> ToBitSpan(this Span<BinaryDigit> src)
            => src.ToReadOnlySpan().ToBitSpan();
                
        [MethodImpl(Inline)]
        public static Span<Bit> ToBitSpan(this ReadOnlySpan<char> src)
        {
            var dst = span<Bit>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit> ToBitSpan(this Span<char> src)
            => src.ToReadOnlySpan().ToBitSpan();


       [MethodImpl(Optimize)]        
        public static Span<Bit> ToBitSpan(this ReadOnlySpan<byte> src)
        {
            var dst = span<Bit>(src.Length*8);
            var offset = 0;
            for(var i = 0; i<src.Length; i++, offset += 8)
                src[i].ToBitSpan().CopyTo(dst.Slice(offset));
            return dst;
        }

        [MethodImpl(Inline)]        
        public static Span<Bit> ToBitSpan(this Span<byte> src)
            => src.ToReadOnlySpan().ToBitSpan();

        [MethodImpl(Optimize)]        
        public static ulong PopCount(this ReadOnlySpan<Bit> src)
        {
            var count = 0ul;
            for(var i=0; i<src.Length; i++)
                if(src[i]) count++;
            return count;
        }

        [MethodImpl(Inline)]        
        public static ulong PopCount(this Span<Bit> src)
            => src.ToReadOnlySpan().PopCount();

    }

}