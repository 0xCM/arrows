//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Projects each source bit into an element of the target span at the corresponding position
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> unpack<S,T>(S src, Span<T> dst, int offset = 0)
            where S : unmanaged
            where T : unmanaged
        {
            var len = bitsize<S>();
            require(dst.Length - offset >= len);
            for(var i=0; i< len; i++)
                dst[offset + i]  = test(src, i) == Bit.On ? one<T>() : zero<T>();            
            return dst;
        }

        /// <summary>
        /// Projects each source bit from each source element into an element of the target span 
        /// at the corresponding position
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="dst">The bit target</param>
        /// <typeparam name="T">The bit source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> unpack<S,T>(Span<S> src, Span<T> dst)
            where S : unmanaged
            where T : unmanaged
        {
            var srcsize = bitsize<S>();
            var bitcount = bitsize<S>()*src.Length;
            require(dst.Length >= bitcount);

            var k = 0;
            for(var i=0; i< src.Length; i++)
            for(var j=0; j< srcsize; j++)
                dst[k++]  = test(src[i], j) == Bit.On ? one<T>() : zero<T>();            
            return dst;
        }

        /// <summary>
        /// Populates a target span with bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> unpack<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return Bits.unpack(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.unpack(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.unpack(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.unpack(uint64(src));
            else            
                throw unsupported<T>();
        }           


    }

}