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
        public static void mcg_64_rxs_m_32_test()
        {
            PrintHeader();

            var batchsize = 6;
            var seed = (ushort)42;

            var rng = new pcg_state_64();
            pcg_mcg_64_srandom_r(rng,seed);

            var unbound = pcg_mcg_64_rxs_m_32_random_r_stream(rng);
            var bound2 = pcg_mcg_64_rxs_m_32_boundedrand_r_stream(rng,2);
            var bound6 = pcg_mcg_64_rxs_m_32_boundedrand_r_stream(rng,6);
            
            var batch1 = unbound.Take(batchsize).ToHexStrings().Concat(" | ");
            print(batch1);
            
            pcg_mcg_64_advance_r(rng, ~5ul);
            var batch2 = unbound.Take(6).ToHexStrings().Concat(" | ");
            print(batch2);
            
            var coins = bound2.Take(65).Select(x => x == 1 ? 'H' : 'T').Concat();
            print(Labels.Label(coins, "Coins"));

            var rolls = bound6.Take(33).Select(x =>  (x + 1)).ToCharDigits().Concat(' ');
            print(Labels.Label(rolls, "Rolls"));
            
            PrintFooter();
        }

    }
}