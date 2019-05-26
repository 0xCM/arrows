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
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong nlz(in byte src)
            => nlz((ushort)src) - 8;

        /// <summary>
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint nlz(in ushort src)
            => (Lzcnt.LeadingZeroCount(src) - 16);

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong nlz(in uint src)
            => Lzcnt.LeadingZeroCount(src);

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong nlz(in ulong src)
            => Lzcnt.X64.LeadingZeroCount(src);
    }
}