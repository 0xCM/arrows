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
        [MethodImpl(Inline)]
        public static byte extract(in byte src, in byte mask)        
            => (byte)Bmi2.ParallelBitExtract(src,mask);

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
    }
}