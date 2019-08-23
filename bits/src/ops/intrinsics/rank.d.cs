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
        /// Calculates the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static uint rank(byte src, BitPos pos)
            => pop(range(src,0,pos));

        /// <summary>
        /// Calculates the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static uint rank(sbyte src, BitPos pos)
            => pop(range(src,0,pos));

        /// <summary>
        /// Calculates the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static uint rank(short src, BitPos pos)
            => pop(range(src,0,pos));

        /// <summary>
        /// Calculates the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static uint rank(ushort src, BitPos pos)
            => pop(range(src,0,pos));

        /// <summary>
        /// Calculates the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static uint rank(int src, BitPos pos)
            => pop(range(src,0,pos));

        /// <summary>
        /// Calculates the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static uint rank(uint src, BitPos pos)
            => pop(range(src,0,pos));

        /// <summary>
        /// Calculates the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static uint rank(long src, BitPos pos)
            => pop(range(src,0,pos));

        /// <summary>
        /// Calculates the number of bits set up to and including the specified position
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit for which rank will be calculated</param>
        [MethodImpl(Inline)]
        public static uint rank(ulong src, BitPos pos)
            => pop(range(src,0,pos));

    }

}