//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;
 
    using static zfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// unsigned int _pext_u32 (unsigned int a, unsigned int mask) PEXT r32a, r32b, reg/m32
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static byte gather(byte src, byte mask)        
            => (byte)ParallelBitExtract((uint)src,(uint)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static sbyte gather(sbyte src, sbyte mask)        
            => (sbyte)ParallelBitExtract((uint)src, (uint)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static short gather(short src, short mask)        
            => (short)ParallelBitExtract((uint)src,(uint)mask);

        /// <summary>
        /// unsigned int _pext_u32 (unsigned int a, unsigned int mask) PEXT r32a, r32b, reg/m32
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ushort gather(ushort src, ushort mask)        
            => (ushort)ParallelBitExtract((uint)src,(uint)mask);

        /// <summary>
        /// Extracts bits from the source at the corresponding bit locations specified by mask 
        /// to contiguous low bits dst; the remaining upper bits dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static int gather(int src, int mask)        
            => (int)ParallelBitExtract((uint)src,(uint)mask);

        /// <summary>
        /// unsigned int _pext_u32 (unsigned int a, unsigned int mask) PEXT r32a, r32b, reg/m32
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint gather(uint src, uint mask)        
            => ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static long gather(long src, long mask)        
            => (long)ParallelBitExtract((ulong)src,(ulong)mask);

        /// <summary>
        /// __int64 _pext_u64 (unsigned __int64 a, unsigned __int64 mask) PEXT r64a, r64b, reg/m64 
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong gather(ulong src, ulong mask)        
            => ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint gather(float src, uint mask)        
            => ParallelBitExtract((uint)src.ToBits(),mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong gather(double src, ulong mask)        
            => ParallelBitExtract((ulong)src.ToBits(),mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static byte gather(byte src, BitMask8 mask)
            => gather(src,(byte)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ushort gather(ushort src, BitMask16 mask)
            => gather(src,(ushort)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint gather(uint src, BitMask32 mask)
            => gather(src,(uint)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong gather(ulong src, BitMask64 mask)
            => gather(src,(ulong)mask);

        [MethodImpl(Inline)]
        public static ref byte gather(byte src, byte mask, ref byte dst)        
        {
            dst = gather(src, mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref sbyte gather(sbyte src, sbyte mask, ref sbyte dst)        
        {
            dst = gather(src, mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short gather(short src, short mask, ref short dst)        
        {
            dst = gather(src, mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort gather(ushort src, ushort mask, ref ushort dst)        
        {
            dst = gather(src, mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int gather(int src, int mask, ref int dst)        
        {
            dst = gather(src, mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint gather(uint src, uint mask, ref uint dst)        
        {
            dst = gather(src, mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long gather(long src, long mask, ref long dst)        
        {
            dst = gather(src, mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong gather(ulong src, ulong mask, ref ulong dst)        
        {
            dst = gather(src, mask);   
            return ref dst;
        }

    }

}