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
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte nlz(in byte src)
            => (byte)(Lzcnt.LeadingZeroCount(src) - 24);

        /// <summary>
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte nlz(in ushort src)
            => (byte)(Lzcnt.LeadingZeroCount(src) - 16);

        /// <summary>
        /// _lzcnt_u32
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte nlz(in uint src)
            => (byte)Lzcnt.LeadingZeroCount(src);

        /// <summary>
        /// _lzcnt_u64:
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte nlz(in ulong src)
            => (byte)Lzcnt.X64.LeadingZeroCount(src);
    }
}