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
    
    partial class Bits
    {                
        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static sbyte range(in sbyte src, in BitPos start, in byte length)        
            => (sbyte)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static byte range(in byte src, in BitPos start, in byte length)        
            => (byte)Bmi1.BitFieldExtract(src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static short range(in short src, in BitPos start, in byte length)        
            => (short)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static ushort range(in ushort src, in BitPos start, in byte length)        
            => (ushort)Bmi1.BitFieldExtract(src, start, length);


        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static uint range(in uint src, in BitPos start, in byte length)        
            => Bmi1.BitFieldExtract(src, start, length);

        [MethodImpl(Inline)]
        public static int range(in int src, in BitPos start, in byte length)        
            => (int)Bmi1.BitFieldExtract((uint)src, start, length);

        [MethodImpl(Inline)]
        public static long range(in long src, in BitPos start, in byte length)
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, start, length);            

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static ulong range(in ulong src, in BitPos start, in byte length)
            => Bmi1.X64.BitFieldExtract(src, start, length);            
    }
}