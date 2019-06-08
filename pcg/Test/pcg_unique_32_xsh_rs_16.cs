namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static PCG;

    public static partial class PCGTest
    {
        public static void pcg_unique_32_xsh_rs_16_test()
        {
            PrintHeader();

            var rng = new pcg_state_32();            
            pcg_unique_32_srandom_r(rng,42);
            var stream = pcg_unique_32_xsh_rs_16_random_r_stream(rng);

            var batch1 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch1);
            
            pcg_unique_32_advance_r(rng, ~5u);            
            var batch2 = stream.Take(6).Select(x => x.ToHexString()).Concat(" | ");
            print(batch2);            
            
           PrintFooter();

        }
    }
}