//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    public static partial class Bits
    {                
        const byte Zero = 0;

        const byte One = 1;
 

        /// <summary>
        /// Calculates the base-2 log of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int log2(byte src)
            => log2((uint)src);

        /// <summary>
        /// Calculates the base-2 log of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int log2(ushort src)
            => log2((uint)src);

        /// <summary>
        /// Calculates the base-2 log of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int log2(uint src)
            => BitOperations.Log2(src);

        /// <summary>
        /// Calculates the base-2 log of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int log2(ulong src)
            => BitOperations.Log2(src);

        [MethodImpl(Inline)]
        public static ulong rotate(ulong src, int offset, bool left = false)            
            => left ? BitOperations.RotateLeft(src,offset) 
                    : BitOperations.RotateRight(src,offset);

        [MethodImpl(Inline)]
        public static uint rotate(uint src, int offset, bool left = false)            
            => left ? BitOperations.RotateLeft(src,offset) 
                    : BitOperations.RotateRight(src,offset);

        [MethodImpl(Inline)]
        public static ulong andnot(ulong lhs, ulong rhs)
            => Bmi1.X64.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static uint andnot(uint lhs, uint rhs)
            => Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static uint leastOnBit(uint src)
            => Bmi1.ExtractLowestSetBit(src);

        [MethodImpl(Inline)]
        public static ulong leastOnBit(ulong src)
            => Bmi1.X64.ExtractLowestSetBit(src);
 
        [MethodImpl(Inline)]
        public static Span<Bit> many(params Bit[] src)
            => src.Reverse();

        /// <summary>
        /// Reinterprets the Bits of a float as the Bits of an int
        /// </summary>
        /// <param name="src">The source value to reinterpret</param>
        [MethodImpl(Inline)]   
        public static int bitsI32(float src)
            => BitConverter.SingleToInt32Bits(src);

        /// <summary>
        /// Reinterprets the Bits of a double as the Bits of a long
        /// </summary>
        /// <param name="src">The source value to reinterpret</param>
        [MethodImpl(Inline)]   
        public static long bitsI64(double src)
            => BitConverter.DoubleToInt64Bits(src);

        /// <summary>
        /// Reinterprets the Bits of an int as the Bits of a float
        /// </summary>
        /// <param name="src">The source value to reinterpret</param>
        [MethodImpl(Inline)]   
        public static float bitsF32(int src)
            => BitConverter.Int32BitsToSingle(src);

        /// <summary>
        /// Reinterprets the Bits of a long as the Bits of a double
        /// </summary>
        /// <param name="src">The source value to reinterpret</param>
        [MethodImpl(Inline)]   
        public static double bitsF64(long src)
            => BitConverter.Int64BitsToDouble(src);        
    }
}