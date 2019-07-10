//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    using static Constants;

    partial class Bits
    {                
        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte lopos(byte src)
            => Pow2.exp((byte)Bmi1.ExtractLowestSetBit(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort lopos(ushort src)
            => Pow2.exp((ushort)Bmi1.ExtractLowestSetBit(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint lopos(uint src)
            => Pow2.exp(Bmi1.ExtractLowestSetBit(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong lopos(ulong src)
            => Pow2.exp(Bmi1.X64.ExtractLowestSetBit(src));
    }

}