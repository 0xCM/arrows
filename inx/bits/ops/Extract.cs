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
        /// Extracts bits from a source at the corresponding bit 
        /// locations specified by mask to contiguous low bits in dst; the remaining 
        /// upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static byte extract(in byte src, in byte mask)        
            => (byte)Bmi2.ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts bits from a source at the corresponding bit 
        /// locations specified by mask to contiguous low bits in dst; the remaining 
        /// upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ushort extract(in ushort src, in ushort mask)        
            => (ushort)Bmi2.ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts bits from a source at the corresponding bit 
        /// locations specified by mask to contiguous low bits in dst; the remaining 
        /// upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint extract(in uint src, in uint mask)        
            => Bmi2.ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts mask-identified bits from the source 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong extract(in ulong src, in ulong mask)        
            => Bmi2.X64.ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static sbyte extract(in sbyte src, in byte start, in byte length)        
            => (sbyte)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static byte extract(in byte src, in byte start, in byte length)        
            => (byte)Bmi1.BitFieldExtract(src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static short extract(in short src, in byte start, in byte length)        
            => (short)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static ushort extract(in ushort src, in byte start, in byte length)        
            => (ushort)Bmi1.BitFieldExtract(src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static uint extract(in uint src, in byte start, in byte length)        
            => Bmi1.BitFieldExtract(src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static int extract(in int src, in byte start, in byte length)        
            => (int)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static long extract(in long src, in byte start, in byte length)
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, start, length);            

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static ulong extract(in ulong src, in byte start, in byte length)
            => Bmi1.X64.BitFieldExtract(src, start, length);            


        /// <intrinsic>unsigned __int64 _bextr_u64(unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b </intrinsic>
        [MethodImpl(Inline)]
        public static ulong bitrange(in byte src, uint i0, uint i1)
            => Bmi1.X64.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0 + 1));            

        /// <intrinsic>unsigned __int64 _bextr_u64(unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b </intrinsic>
        [MethodImpl(Inline)]
        public static ulong bitrange(in ushort src, uint i0, uint i1)
            => Bmi1.X64.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0 + 1));            

        /// <intrinsic>unsigned __int64 _bextr_u64(unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b </intrinsic>
        [MethodImpl(Inline)]
        public static ulong bitrange(in uint src, uint i0, uint i1)
            => Bmi1.X64.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0 + 1));            


        /// <intrinsic>unsigned __int64 _bextr_u64(unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b </intrinsic>
        [MethodImpl(Inline)]
        public static ulong bitrange(in ulong src, uint i0, uint i1)
            => Bmi1.X64.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0 + 1));            

     }
}