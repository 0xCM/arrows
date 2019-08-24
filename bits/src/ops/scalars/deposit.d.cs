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
        /// <param name="io">The value to be manipulated</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref byte deposit(ref byte io, byte mask)        
        {
            io = (byte)Bmi2.ParallelBitDeposit(io,mask); 
            return ref io;
        }

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="io">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref ushort deposit(ref ushort io, ushort mask)        
        {
            io = (ushort)Bmi2.ParallelBitDeposit(io,mask); 
            return ref io;
        }

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="io">The value to be manipulated</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref uint deposit(ref uint io, uint mask)        
        {
            io = Bmi2.ParallelBitDeposit(io,mask); 
            return ref io;
        }

        /// <summary>
        /// Sets mask-identified bits in the source
        /// </summary>
        /// <param name="io">The value to be manipulated</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static ref ulong deposit(ref ulong io, ulong mask)        
        {
            io = Bmi2.X64.ParallelBitDeposit(io,mask);
            return ref io;
        }            
    }
}