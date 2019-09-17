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
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static sbyte between(in sbyte src, BitPos i0, BitPos i1)        
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static byte between(in byte src, BitPos i0, BitPos i1)        
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static short between(in short src, BitPos i0, BitPos i1)        
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ushort between(in ushort src, BitPos i0, BitPos i1)        
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static uint between(in uint src, BitPos i0, BitPos i1)        
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static int between(in int src, BitPos i0, BitPos i1)        
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ulong between(in ulong src, BitPos i0, BitPos i1)
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static long between(in long src, BitPos i0, BitPos i1)
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static float between(in float src, BitPos i0, BitPos i1)
            => BitMask.between(in src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static double between(in double src, BitPos i0, BitPos i1)
            => BitMask.between(in src, i0, i1);

    }

}