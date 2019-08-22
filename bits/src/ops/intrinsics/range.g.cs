//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    

    partial class gbits
    {                        
        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source,
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static T range<T>(in T src, BitPos i0, BitPos i1)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.range(int8(src),i0,i1));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.range(uint8(src),i0,i1));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.range(int16(src),i0,i1));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.range(uint16(src),i0,i1));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.range(int32(src),i0,i1));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.range(uint32(src),i0,i1));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.range(int64(src),i0,i1));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.range(uint64(src),i0,i1));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Reads a contiguous range of bits and deposits the result in a bytespan
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void range<T>(in T src, BitPos i0, BitPos i1, Span<byte> dst, int offset)
            where T : struct
                => bytes(gbits.range(src,i0,i1)).Slice(0, ByteCount(i0,i1)).CopyTo(dst,offset);                 
        
        [MethodImpl(Inline)]
        static ByteSize ByteCount(BitPos i0, BitPos i1)
            => ByteCount(i1 - i0);


        [MethodImpl(Inline)]
        static ByteSize ByteCount(uint bitcount)
            => (uint)(Mod<N8>.div(bitcount) + (Mod<N8>.mod(bitcount) == 0 ? 0 : 1));

    }

}