//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;

    partial class RngX
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