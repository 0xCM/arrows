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
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static byte deposit(in byte src, in byte mask)  
            => (byte)Bmi2.ParallelBitDeposit(src,mask); 

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ushort deposit(in ushort src, in ushort mask)          
            => (ushort)Bmi2.ParallelBitDeposit(src,mask); 

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static uint deposit(in uint src, in uint mask)  
            => Bmi2.ParallelBitDeposit(src,mask); 

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ulong deposit(in ulong src, in ulong mask)        
            => Bmi2.X64.ParallelBitDeposit(src,mask);

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref byte deposit(ref byte src, byte mask)        
        {
            src = (byte)Bmi2.ParallelBitDeposit(src,mask); 
            return ref src;
        }

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref ushort deposit(ref ushort src, ushort mask)        
        {
            src = (ushort)Bmi2.ParallelBitDeposit(src,mask); 
            return ref src;
        }

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref uint deposit(ref uint src, uint mask)        
        {
            src = Bmi2.ParallelBitDeposit(src,mask); 
            return ref src;
        }

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref ulong deposit(ref ulong src, ulong mask)        
        {
            src = Bmi2.X64.ParallelBitDeposit(src,mask);
            return ref src;
        }
            
    }

}