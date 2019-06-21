//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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

        public static Span<ulong> Next(this Span<Pcg32> suite)
        {
            var dst = span<ulong>(suite.Length);
            for(var i=0; i<suite.Length; i++)
                dst[i] = suite[i].Next();
            return dst;
        }
    }


}