//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rng
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static math;

    public static class PcgX
    {
        /// <summary>
        /// Takes one sample from each generator
        /// </summary>
        /// <param name="generators">A set of sequenced PCG32 generators</param>
        public static Span<ulong> Next(this Span<Pcg32> generators)
        {
            var dst = span<ulong>(generators.Length);
            for(var i=0; i<generators.Length; i++)
                dst[i] = generators[i].Next();
            return dst;
        }

    }

}