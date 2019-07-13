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

    partial class xfunc
    {
        public static Span<Bit> ToBits(this ReadOnlySpan<char> src, out Span<Bit> dst)
        {
            dst = span<Bit>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this Span<char> src, out Span<Bit> dst)
            => src.ReadOnly().ToBits(out dst);


        [MethodImpl(Inline)]
        public static Bit ToBit(this BinaryDigit digit)
            => digit == BinaryDigit.One;

        public static Span<Bit> ToBits(this ReadOnlySpan<BinaryDigit> src, out Span<Bit> dst)
        {
            dst = span<Bit>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i].ToBit();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this Span<BinaryDigit> src, out Span<Bit> dst)
            => src.ReadOnly().ToBits(out dst);

        /// <summary>
        /// Consructs a bit sream from a stream of bools
        /// </summary>
        /// <param name="src">The bitstring source</param>
        public static Span<Bit> ToBits(this ReadOnlySpan<bool> src, out Span<Bit> dst)
        {
            dst = span<Bit>(src.Length);
            for(var i = 0; i < src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<bool> ToBools(this ReadOnlySpan<Bit> src)
        {
            var dst = span<bool>(src.Length);
            for(var i=0; i< dst.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> ToBools(this Span<Bit> src)
            => src.ReadOnly().ToBools();

        public static Span<char> ToBitChars(this Span<Bit> src)
        {
            Span<char> dst = new char[src.Length];
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            return dst;
        }
            
        [MethodImpl(Inline)]
        public static byte TakeByte(this ReadOnlySpan<Bit> src)
        {
            var dst = (byte)0;
            var lastIndex = Math.Min(7,src.Length);
            for(var i = 0; i<= lastIndex; i++)
                dst ^= (byte) ((byte)src[i] << i); 
            return dst;                       

        }

        [MethodImpl(Inline)]
        public static byte TakeByte(this ReadOnlySpan<bool> src)
        {
            var dst = (byte)0;
            var lastIndex = Math.Min(7,src.Length);
            for(var i = 0; i<= lastIndex; i++)
                dst ^= (byte) ( (src[i] ? 1 : 0) << i); 
            return dst;                       
        }

        /// <summary>
        /// Condenses readonly bitspan into a bytespan
        /// </summary>
        /// <param name="src">The source bits</param>
        public static Span<byte> CompressToBytes(this ReadOnlySpan<Bit> src)
        {   
            const int dstSize = 8;
            var wholeByteCount =  Math.DivRem(src.Length,dstSize, out int remainder);
            var dstByteCount = remainder == 0 ? wholeByteCount : wholeByteCount + 1;
            var dst = span<byte>(dstByteCount);
            var lastDstIndex = dstByteCount - 1;
            for(int i = 0, srcOffset = 0; i< dst.Length; i++, srcOffset += dstSize)
            {
                var srcLen = i != lastDstIndex ? dstSize : (remainder == 0 ? dstSize : remainder);
                var srcBits = src.Slice(srcOffset, srcLen);                
                dst[i] = srcBits.TakeByte();
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> CompressToBytes(this Span<Bit> src)
            => src.ReadOnly().CompressToBytes();   

        public static Span<byte> CompressToBytes(this ReadOnlySpan<bool> src)
        {
            const int dstSize = 8;
            var wholeByteCount =  Math.DivRem(src.Length,dstSize, out int remainder);
            var dstByteCount = remainder == 0 ? wholeByteCount : wholeByteCount + 1;
            var dst = span<byte>(dstByteCount);
            var lastDstIndex = dstByteCount - 1;
            for(int i=0, srcOffset = 0; i<dst.Length; i++, srcOffset += dstSize)
            {
                var srcLen = i != lastDstIndex ? dstSize : (remainder == 0 ? dstSize : remainder);
                var srcBits = src.Slice(srcOffset, srcLen);                
                dst[i] = src.Slice(srcOffset, srcLen).TakeByte();
            }
            return dst;

        }            

        [MethodImpl(Inline)]
        public static Span<byte> CompressToBytes(this Span<bool> src)
            => src.ReadOnly().CompressToBytes();
    }

}