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
        ///<intrinsic>unsigned int _pdep_u32 (unsigned int a, unsigned int mask) PDEP r32a, r32b, reg/m32</intrinsic>
        [MethodImpl(Inline)]
        public static byte deposit(in byte src, byte mask)  
            => (byte)Bmi2.ParallelBitDeposit(src,mask); 

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ushort deposit(in ushort src, ushort mask)          
            => (ushort)Bmi2.ParallelBitDeposit(src,mask); 

        /// <summary>
        /// unsigned int _pdep_u32 (unsigned int a, unsigned int mask) PDEP r32a, r32b, reg/m32
        /// Sets mask-identified bits in the source
        /// "Scatter contiguous low order bits of the source to the result at the positions specified by the mask."
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static uint deposit(in uint src, uint mask)  
            => Bmi2.ParallelBitDeposit(src, mask); 

        /// <summary>
        /// unsigned __int64 _pdep_u64 (unsigned __int64 a, unsigned __int64 mask) PDEP r64a, r64b, reg/m64
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ulong deposit(in ulong src, ulong mask)        
            => Bmi2.X64.ParallelBitDeposit(src,mask);

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The value to be manipulated</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref byte deposit(ref byte src, in byte mask)        
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
        public static ref ushort deposit(ref ushort src, in ushort mask)        
        {
            src = (ushort)Bmi2.ParallelBitDeposit(src,mask); 
            return ref src;
        }

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The value to be manipulated</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref uint deposit(ref uint src, in uint mask)        
        {
            src = Bmi2.ParallelBitDeposit(src,mask); 
            return ref src;
        }

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="src">The value to be manipulated</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref ulong deposit(ref ulong src, in ulong mask)        
        {
            src = Bmi2.X64.ParallelBitDeposit(src,mask);
            return ref src;
        }            
    }
}