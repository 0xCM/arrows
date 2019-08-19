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
        /// <summary>
        /// Condenses readonly bitspan into a bytespan
        /// </summary>
        /// <param name="src">The source bits</param>
        public static Span<byte> Pack(this ReadOnlySpan<Bit> src)
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

        /// <summary>
        /// Condenses bitspan into a bytespan
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static Span<byte> Pack(this Span<Bit> src)
            => src.ReadOnly().Pack();   

        /// <summary>
        /// Condenses a span of bools to a span of bytes where each bit represents the value of a bool
        /// </summary>
        /// <param name="src">The source bits</param>
        public static Span<byte> Pack(this ReadOnlySpan<bool> src)
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
        public static Span<byte> Pack(this Span<bool> src)
            => src.ReadOnly().Pack();

        [MethodImpl(Inline)]
        static byte TakeByte(this ReadOnlySpan<bool> src)
        {
            var dst = (byte)0;
            var lastIndex = Math.Min(7,src.Length);
            for(var i = 0; i<= lastIndex; i++)
                dst ^= (byte) ( (src[i] ? 1 : 0) << i); 
            return dst;                       
        }

        [MethodImpl(Inline)]
        static byte TakeByte(this ReadOnlySpan<Bit> src)
        {
            var dst = (byte)0;
            var lastIndex = Math.Min(7,src.Length);
            for(var i = 0; i<= lastIndex; i++)
                dst ^= (byte) ((byte)src[i] << i); 
            return dst;                       
        }

    }

}