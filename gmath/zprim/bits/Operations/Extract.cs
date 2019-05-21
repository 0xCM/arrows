//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                

        /// <summary>
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(in ushort src)
            => (byte)(src >> 8);

        /// <summary>
        /// Produces a byte by extracting bits [0 .. 7] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte lo(in short src)
            => (sbyte)src;

        /// <summary>
        /// Extracts the low-order bits from a ushort to produce a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo(in ushort src)
            => (byte)src;

        /// <summary>
        /// Produces a byte by extracting bits [8 .. 15] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte hi(in short src)
            => (sbyte)(src >> 8);
            
        [MethodImpl(Inline)]
        public static short lo(in int src)
            => (short)src;        

        [MethodImpl(Inline)]
        public static short hi(in int src)
            => (short)(src >> 16);

        [MethodImpl(Inline)]
        public static ushort lo(in uint src)
            => (ushort)src;
            
        [MethodImpl(Inline)]
        public static ushort hi(in uint src)
            => (ushort)(src >> 16); 
            
        [MethodImpl(Inline)]
        public static int hi(in long src)
            => (int)(src >> 32);

        [MethodImpl(Inline)]
        public static int lo(in long src)
            => (int)src;            

        [MethodImpl(Inline)]
        public static uint hi(in ulong src)
            => (uint)(src >> 32);

        [MethodImpl(Inline)]
        public static uint lo(in ulong src)
            => (uint)src;

        [MethodImpl(Inline)]
        public static ref sbyte hi(in short src, out sbyte dst)        
        {
            dst = (sbyte)(src >> Pow2.T03);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref sbyte lo(in short src, out sbyte dst)        
        {
            dst = (sbyte)src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte hi(in ushort src, out byte dst)        
        {
            dst = (byte)(src >> Pow2.T03);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte lo(in ushort src, out byte dst)        
        {
            dst = (byte)src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short hi(in int src, out short dst)        
        {
            dst = (short)(src >> Pow2.T04);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short lo(in int src, out short dst)        
        {
            dst = (short)src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort hi(in uint src, out ushort dst)        
        {
            dst = (ushort)(src >> Pow2.T04);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort lo(in uint src, out ushort dst)        
        {
            dst = (ushort)src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int hi(in long src, out int dst)        
        {
            dst = (int)(src >> Pow2.T05);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int lo(in long src, out int dst)        
        {
            dst = (int)src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint hi(in ulong src, out uint dst)        
        {
            dst = (uint)(src >> Pow2.T05);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint lo(in ulong src, out uint dst)        
        {
            dst = (uint)src;
            return ref dst;
        }

        /// <summary>
        /// Extract bits from a source interger at the corresponding bit 
        /// locations specified by mask to contiguous low bits in dst; the remaining 
        /// upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ref uint extract(ref uint src, in uint mask)        
        {
            src = Bmi2.ParallelBitExtract(src,mask);
            return ref src;
        }

        /// <summary>
        /// Extracts mask-identified bits from the source 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ref ulong extract(ref ulong src, in ulong mask)        
        {
            src = Bmi2.X64.ParallelBitExtract(src,mask);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref uint extract(ref uint src, in byte start, in byte length)
        {
            src = Bmi1.BitFieldExtract(src, start, length);
            return ref src;
        }


        /// <summary>
        /// Extracts a run of bits from the source beginning at a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset value</param>
        /// <param name="length">The length of the run</param>
        [MethodImpl(Inline)]
        public static ref ulong extract(ref ulong src, in byte offset, in byte length)
        {
            src = Bmi1.X64.BitFieldExtract(src, offset, length);
            return ref src;
        }
            
        /// <summary>
        /// Sets mask-identified bits in the soruce
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ref ulong deposit(ref ulong src, in ulong mask)        
        {
            src = Bmi2.X64.ParallelBitDeposit(src,mask);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint deposit(ref uint src, in uint mask)  
        {      
            src = Bmi2.ParallelBitDeposit(src,mask); 
            return ref src;
        }
    }
}