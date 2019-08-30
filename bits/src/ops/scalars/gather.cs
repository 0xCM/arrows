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
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static byte gather(in byte src, in byte mask)        
            => (byte)ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static sbyte gather(in sbyte src, in sbyte mask)        
            => (sbyte)Bmi2.ParallelBitExtract((uint)src, (uint)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static short gather(in short src, in short mask)        
            => (short)ParallelBitExtract((uint)src,(uint)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ushort gather(in ushort src, in ushort mask)        
            => (ushort)ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts bits from the source at the corresponding bit locations specified by mask 
        /// to contiguous low bits in dst; the remaining upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static int gather(in int src, in int mask)        
            => (int)ParallelBitExtract((uint)src,(uint)mask);

        /// <summary>
        /// unsigned int _pext_u32 (unsigned int a, unsigned int mask) PEXT r32a, r32b, reg/m32
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint gather(in uint src, in uint mask)        
            => ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static long gather(in long src, in long mask)        
            => (long)ParallelBitExtract((ulong)src,(ulong)mask);

        /// <summary>
        /// __int64 _pext_u64 (unsigned __int64 a, unsigned __int64 mask) PEXT r64a, r64b, reg/m64 
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong gather(in ulong src, in ulong mask)        
            => ParallelBitExtract(src,mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint gather(in float src, in uint mask)        
            => ParallelBitExtract((uint)src.ToBits(),mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong gather(in double src, in ulong mask)        
            => ParallelBitExtract((ulong)src.ToBits(),mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static byte gather(in byte src, BitMask8 mask)
            => gather(src,(byte)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ushort gather(in ushort src, BitMask16 mask)
            => gather(src,(ushort)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint gather(in uint src, BitMask32 mask)
            => gather(src,(uint)mask);

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong gather(in ulong src, BitMask64 mask)
            => gather(src,(ulong)mask);

        [MethodImpl(Inline)]
        public static ref byte gather(in byte src, in byte mask, ref byte dst)        
        {
            dst = gather(in src, in mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref sbyte gather(in sbyte src, in sbyte mask, ref sbyte dst)        
        {
            dst = gather(in src, in mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short gather(in short src, in short mask, ref short dst)        
        {
            dst = gather(in src, in mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort gather(in ushort src, in ushort mask, ref ushort dst)        
        {
            dst = gather(in src, in mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int gather(in int src, in int mask, ref int dst)        
        {
            dst = gather(in src, in mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint gather(in uint src, in uint mask, ref uint dst)        
        {
            dst = gather(in src, in mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long gather(in long src, in long mask, ref long dst)        
        {
            dst = gather(in src, in mask);   
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong gather(in ulong src, in ulong mask, ref ulong dst)        
        {
            dst = gather(in src, in mask);   
            return ref dst;
        }

    }

}