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
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(sbyte src)
            => ntz((int)src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(byte src)
            => ntz((uint)src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(short src)
            => ntz((int)src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(ushort src)
            => ntz((uint)src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
         [MethodImpl(Inline)]
         public static int ntz(int src)
            => BitOperations.TrailingZeroCount(src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(uint src)
            => (int)Bmi1.TrailingZeroCount(src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
         [MethodImpl(Inline)]
         public static int ntz(long src)
            => BitOperations.TrailingZeroCount(src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong ntz(ulong src)
            => Bmi1.X64.TrailingZeroCount(src);
    }
}