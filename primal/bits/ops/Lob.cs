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
        /// Extracts the least on bit from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint lob(uint src)
            => Bmi1.ExtractLowestSetBit(src);

        /// <summary>
        /// Extracts the least on bit from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong lob(ulong src)
            => Bmi1.X64.ExtractLowestSetBit(src);
 


    }

}