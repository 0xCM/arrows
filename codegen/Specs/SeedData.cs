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
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class SeedGenerators
    {
        public static void GenSeeds64(int count)
        {
            var entropy = Seed.Entropy<ulong>(count).AsBytes();
            var code = InlineData.GenAccessor(entropy.ToArray(),"RawBytes");
            print(code);               
        }
    }

}