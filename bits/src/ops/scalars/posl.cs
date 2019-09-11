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

    partial class Bits
    {                 
        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte posl(byte src)
            => Pow2.inv(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort posl(ushort src)
            => Pow2.inv(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint posl(uint src)
            => Pow2.inv(blsi(src));

        /// <summary>
        /// Determines the position of the least on bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong posl(ulong src)
            => Pow2.inv(blsi(src));    
    }
}