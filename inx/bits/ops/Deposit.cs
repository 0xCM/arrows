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
        public static byte deposit(in byte src, in byte mask)  
            => (byte)Bmi2.ParallelBitDeposit(src,mask); 

        [MethodImpl(Inline)]
        public static ushort deposit(in ushort src, in ushort mask)  
            => (ushort)Bmi2.ParallelBitDeposit(src,mask); 

        [MethodImpl(Inline)]
        public static uint deposit(in uint src, in uint mask)  
            => Bmi2.ParallelBitDeposit(src,mask); 

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong deposit(in ulong src, in ulong mask)        
            => Bmi2.X64.ParallelBitDeposit(src,mask);

    }

}