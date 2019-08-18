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
    

    partial class Bits
    {                        
        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source,
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        /// <intrinsic>unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static sbyte range(sbyte src, BitPos i0, BitPos i1)
            => (sbyte)range((byte)src, i0, i1);

        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source,
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        /// <intrinsic>unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static byte range(byte src, BitPos i0, BitPos i1)
            => (byte)Bmi1.BitFieldExtract(src, i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        /// <intrinsic>unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static ushort range(ushort src, BitPos i0, BitPos i1)
            => (ushort)Bmi1.BitFieldExtract(src, i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source,
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        /// <intrinsic>unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static short range(short src, BitPos i0, BitPos i1)
            => (short)range((ushort)src, i0, i1);

        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        /// <intrinsic>unsigned __int64 _bextr_u64(unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b </intrinsic>
        [MethodImpl(Inline)]
        public static uint range(uint src, BitPos i0, BitPos i1)
            => Bmi1.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source,
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        /// <intrinsic>unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static int range(int src, BitPos i0, BitPos i1)
            => (int)range((uint)src, i0, i1);

        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        /// <intrinsic>unsigned __int64 _bextr_u64(unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b </intrinsic>
        [MethodImpl(Inline)]
        public static ulong range(ulong src, BitPos i0, BitPos i1)
            => Bmi1.X64.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0));
 
        /// <summary>
        /// Extracts an index-identified contiguous range of bits from the source,
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        /// <intrinsic>unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b</intrinsic>
        [MethodImpl(Inline)]
        public static long range(long src, BitPos i0, BitPos i1)
            => (long)range((ulong)src, i0, i1);

    }

}