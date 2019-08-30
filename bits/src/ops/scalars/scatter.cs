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
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static byte scatter(in byte src, in byte mask)  
            => (byte)ParallelBitDeposit(src,mask); 

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ushort scatter(in ushort src, in ushort mask)          
            => (ushort)ParallelBitDeposit(src,mask); 

        /// <summary>
        /// unsigned int _pdep_u32 (unsigned int a, unsigned int mask) PDEP r32a, r32b, reg/m32
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static uint scatter(in uint src, in uint mask)  
            => ParallelBitDeposit(src, mask); 

        /// <summary>
        /// unsigned __int64 _pdep_u64 (unsigned __int64 a, unsigned __int64 mask) PDEP r64a, r64b, reg/m64
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ulong scatter(in ulong src, in ulong mask)        
            => X64.ParallelBitDeposit(src,mask);

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static byte scatter(byte src, BitMask8 mask)  
            => (byte)ParallelBitDeposit(src,(uint)mask); 

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ushort scatter(ushort src, BitMask16 mask)          
            => (ushort)ParallelBitDeposit(src,(uint)mask); 

        /// <summary>
        /// unsigned int _pdep_u32 (unsigned int a, unsigned int mask) PDEP r32a, r32b, reg/m32
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static uint scatter(uint src, BitMask32 mask)  
            => ParallelBitDeposit(src, (uint)mask); 

        /// <summary>
        /// unsigned __int64 _pdep_u64 (unsigned __int64 a, unsigned __int64 mask) PDEP r64a, r64b, reg/m64
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ulong scatter(ulong src, BitMask64 mask)        
            => X64.ParallelBitDeposit(src,(ulong)mask);

    }
}