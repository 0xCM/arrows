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
        public static byte extract(in sbyte src, in byte mask)        
            => (byte)Bmi2.ParallelBitExtract((uint)src,mask);

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
        public static uint extract(in int src, in uint mask)        
            => Bmi2.ParallelBitExtract((uint)src,mask);

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
        public static ulong extract(in long src, in ulong mask)        
            => Bmi2.X64.ParallelBitExtract((ulong)src,mask);

        /// <summary>
        /// Extracts mask-identified bits from the source 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        /// <intrinsic>__int64 _pext_u64 (unsigned __int64 a, unsigned __int64 mask) PEXT r64a, r64b, reg/m64 </intrinsic>
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

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static byte between(in byte src, BitPos i0, BitPos i1)        
            => (byte)Bmi1.BitFieldExtract(src, i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ushort between(in ushort src, BitPos i0, BitPos i1)        
            => (ushort)Bmi1.BitFieldExtract(src, i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static uint between(in uint src, BitPos i0, BitPos i1)        
            => Bmi1.BitFieldExtract(src, i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ulong between(in ulong src, BitPos i0, BitPos i1)
            => Bmi1.X64.BitFieldExtract(src, i0, (byte)(i1 - i0));            

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort hi(in uint src)
            => (ushort)(src >> 16); 

        /// <summary>
        /// Extracts the lower 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort lo(in uint src)
            => (ushort)src;

        /// <summary>
        /// Extracts the upper 32 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint hi(in ulong src)
            => (uint)(src >> 32);

        /// <summary>
        /// Extracts the lower 32 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint lo(in ulong src)
            => (uint)src;

        /// <summary>
        /// Extracts the upper 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]        
        public static sbyte hi(in sbyte src)
            => (sbyte)(src >> 4);

        /// <summary>
        /// Extracts the lower 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static sbyte lo(in sbyte src)
            => (sbyte)(((sbyte)(src << 4)) >> 4);

        /// <summary>
        /// Extracts the upper 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte hi(in byte src)
            => (byte)(src >> 4);

        /// <summary>
        /// Extracts the lower 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte lo(in byte src)
            => (byte)(((byte)(src << 4)) >> 4);

        /// <summary>
        /// Extracts the upper 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(in ushort src)
            => (byte)(src >> 8);

        /// <summary>
        /// Extracts the lower 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo(in ushort src)
            => (byte)src;

        /// <summary>
        /// Extracts the upper 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte hi(in short src)
            => (sbyte)(src >> 8);            

        /// <summary>
        /// Extracts the lower 8 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static sbyte lo(in short src)
            => (sbyte)src;

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static short hi(in int src)
            => (short)(src >> 16);

        /// <summary>
        /// Extracts the lower 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static short lo(in int src)
            => (short)src;        

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int hi(in long src)
            => (int)(src >> 32);

        /// <summary>
        /// Extracts the lower half of the bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int lo(in long src)
            => (int)src;
     }
}